using NUnit.Framework;

namespace LeetcodeTasks.StrStr
{
    public class StrStrTests
    {

        [Test]
        public void Try_hello_SolutionOne_Succeed()
        {
            var str = new StrStr("hello","ll");
            var result = str.SolutionOne();


            Assert.AreEqual(2,result);
        }

        [Test]
        public void Try_aaaaaaaaaaa_SolutionOne_Succeed()
        {
            var str = new StrStr("aaaaa", "bba");
            var result = str.SolutionOne();


            Assert.AreEqual(-1, result);
        }


        [Test]
        public void Try_abracadabra_SolutionOne_Succeed()
        {
            var str = new StrStr("abracadabra", "abra");
            var result = str.SolutionOne();


            Assert.AreEqual(0, result);
        }

        [Test]
        public void Try_Empty_SolutionOne_Succeed()
        {
            var str = new StrStr("", "a");
            var result = str.SolutionOne();


            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Try_EmptyHayStackAndNeedle_SolutionOne_Succeed()
        {
            var str = new StrStr("", "");
            var result = str.SolutionOne();


            Assert.AreEqual(0, result);
        }


        [Test]
        public void Try_a_a_SolutionOne_Succeed()
        {
            var str = new StrStr("a", "a");
            var result = str.SolutionOne();


            Assert.AreEqual(0, result);
        }

        [Test]
        public void Try_aaa_aaa_SolutionOne_Succeed()
        {
            var str = new StrStr("aaa", "aaa");
            var result = str.SolutionOne();


            Assert.AreEqual(0, result);
        }

        [Test]
        public void Try_mississippi_pi_SolutionOne_Succeed()
        {
            var str = new StrStr("mississippi", "pi");
            var result = str.SolutionOne();


            Assert.AreEqual(9, result);
        }


        [Test]
        public void Try_aaa_aaaa_SolutionOne_Succeed()
        {
            var str = new StrStr("aaa", "aaaa");
            var result = str.SolutionOne();


            Assert.AreEqual(-1, result);
        }


        [Test]
        public void Try_mississippi_sippia_SolutionOne_Succeed()
        {
            var str = new StrStr("mississippi", "sippia");
            var result = str.SolutionOne();

            Assert.AreEqual(-1, result);
        }


        [Test]
        public void Try_hello_SolutionKMP_Succeed()
        {
            var str = new StrStr("hello", "ll");
            var result = str.SolutionKMP();


            Assert.AreEqual(2, result);
        }

        [Test]
        public void Try_AABRAACADABRAACAADABRA_AACAA_SolutionKMP_Succeed()
        {
            var str = new StrStr("AABRAACADABRAACAADABRA", "AACAA");
            var result = str.SolutionKMP();


            Assert.AreEqual(13, result);
        }



    }
}