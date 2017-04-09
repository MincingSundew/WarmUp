namespace NUnit.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit.Framework;
    using SoftwareTest;

    [TestFixture]
    public class RunLengthEncodingChallengeTest
    {
        [Test]
        public void EncodeTest()
        {
            SoftwareTest.RunLengthEncodingChallenge sut = new RunLengthEncodingChallenge();

            string input = "aaaaaaabbbbccccddddd";
            byte[] array1 = Encoding.ASCII.GetBytes(input);
            string result = "7a4b4c5d";
            byte[] array = Encoding.ASCII.GetBytes(result);
            Assert.That(sut.Encode(array1), Is.EqualTo(array));
        }
    }
}