using System;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}
class Student : Person
{
    private int[] testScores;

    public Student(string sfirstName, string slastName, int sid, int[] sscores)
    {
        firstName = sfirstName;
        lastName = slastName;
        id = sid;
        testScores = sscores;
    }

    public char Calculate(int[] testScores)
    {
        int sum = 0;
        int average = 0;
        char Grade = ' ';
        for(int i=0;i<testScores.Length;i++)
        {
            sum = sum + testScores[i];
        }
        average = sum / testScores.Length;
        if(90<=average && average<=100)
        {
            Grade = 'O';
        }
        else if(80 <= average && average < 90)
        {
            Grade = 'E';

        }
        else if (70 <= average && average < 80)
        {
            Grade = 'A';

        }
        else if (55 <= average && average < 70)
        {
            Grade = 'P';

        }
        else if (40 <= average && average < 55)
        {
            Grade = 'D';

        }
        else if (average < 40)
        {
            Grade = 'T';

        }
        return Grade;
    }
  
}