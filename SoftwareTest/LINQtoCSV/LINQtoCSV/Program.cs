using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mlp.interviews.boxing.problem
{
    public class TraderList{
        public string Trader;
        public string Broker;
        public string Symbol;
        public long Quantity;
        public string Price;
 
       

        public List<TraderList> ReadValuesfromFile(string fileName)
        {
            string[] allLines = File.ReadAllLines(@fileName);
            List<TraderList> RecordsfromFile = (from line in allLines.Skip(1)
                        let data = line.Split(',')
                        select new TraderList
                        {
                            Trader = data[0],
                            Broker = data[1],
                            Symbol = data[2],
                            Quantity = long.Parse(data[3]),
                            Price = data[4]
                        }).ToList();


            return RecordsfromFile;
  }
        public List<TraderList> getNetPosition(List<TraderList> RecordsfromFile)
        {
            
            List<TraderList> RecordswithNetPositions = RecordsfromFile.GroupBy(x => new { x.Trader, x.Symbol })
                               .Select(x => new TraderList
                               {
                                   Trader = x.Key.Trader,
                                   Symbol = x.Key.Symbol,
                                   Quantity = x.Sum(y => y.Quantity)
                               }).ToList();
                
            return RecordswithNetPositions;
        }

        public List<TraderList> getBoxedPosition(List<TraderList> RecordsfromFile)
        {

            var newListWithSameSymbol = RecordsfromFile
                  .GroupBy(x => new { x.Symbol, x.Trader }).Where(grp => grp.Count() > 1)
                  .SelectMany(grp => grp).ToList();

            var tradersWithShortValues = newListWithSameSymbol.Where(x => x.Quantity < 0).Select(x=>x.Trader);
            var tradersWithLongValues = newListWithSameSymbol.Where(x => x.Quantity > 0).Select(x => x.Trader);
                                       

            var result = tradersWithLongValues.Intersect(tradersWithShortValues).ToList();


            var AddingThePositiveTotals = newListWithSameSymbol
                .Where(a => tradersWithLongValues.Contains(a.Trader) && a.Quantity > 0)
                .GroupBy(x => new { x.Trader, x.Symbol })
                .Select(x => new TraderList
                {
                    Trader = x.Key.Trader,
                    Symbol = x.Key.Symbol,
                    Quantity = x.Sum(y => y.Quantity)
                })
               .ToList();
            var AddingTheNegativeTotals = newListWithSameSymbol
                 .Where(a => tradersWithShortValues.Contains(a.Trader) && a.Quantity < 0)
                .GroupBy(x => new { x.Trader, x.Symbol })
                .Select(x => new TraderList
                {
                    Trader = x.Key.Trader,
                    Symbol = x.Key.Symbol,
                    Quantity = x.Sum(y => Math.Abs(y.Quantity))
                })
               .ToList();

            var RecordsContainingBothNegandPosValues = AddingThePositiveTotals.Union(AddingTheNegativeTotals).ToList();
            var varRecordswithBoxedPositions = from a in RecordsContainingBothNegandPosValues
                           .Where(a => result.Contains(a.Trader))
                          group a by new { a.Symbol, a.Trader } into grp
                          select new TraderList
                          {
                              Trader = grp.Key.Trader,
                              Symbol = grp.Key.Symbol,
                              Quantity = grp.Max(x => x.Quantity)
                          };           
            List<TraderList> RecordswithBoxedPositions = varRecordswithBoxedPositions.ToList();
            return RecordswithBoxedPositions;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TraderList TraderList = new TraderList();
            List<TraderList> FileValues = TraderList.ReadValuesfromFile(@"C:\Users\sharmi\Downloads\test_data.csv");
            if (FileValues.Any())
            {
                List<TraderList> NetPositionValues = TraderList.getNetPosition(FileValues);
                List<TraderList> NetBoxedPositionValues = TraderList.getBoxedPosition(FileValues);
            }
        }
    }
}
///Improvements to this class.
//Error handling is missing
//Decrease the dependency between classes 
//The getBoxedPosition can be further split into more methods so each method will have a single function


//Below testcases are needed

//To check for null values in the input parameters
//to check when null values are returned from query
//Format of columns like Quantity and price


