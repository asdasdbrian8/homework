using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeDataAndDoc
{
    [TestFixture]
    public class test
    {
        [Test]
        public void Test()
        {
            StringReader input = new StringReader("陳彥儒\t1050301\t1年");
            StringReader input1 = new StringReader("name先生(身分證字號id)為本校專任教師，聘期time此聘校長");
            StringWriter output = new StringWriter();
            Program.come(intput, input1, output);

        }
    }
}
