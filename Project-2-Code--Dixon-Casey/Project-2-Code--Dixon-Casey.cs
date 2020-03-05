/*
 * Written by Casey Dixon
 * A not so great way to guess and check and crack two time pad using a ciphertext only attack
 */
using System;
using System.Collections.Generic;

public class Project_2_Code__Dixon_Casey
{
    public static string xorString(string cipherText1, string cipherText2)
    {
        int min = cipherText1.Length;
        string result = "";

        if (cipherText1.Length > cipherText2.Length)
        {
            min = cipherText2.Length;  
        }

        for (int i = 0; i < min; i++)
        {
            int decimalText1 = Convert.ToInt32(cipherText1[i].ToString(), 16);
            int decimalText2 = Convert.ToInt32(cipherText2[i].ToString(), 16);
            int intResult = decimalText1^decimalText2;
            result += intResult.ToString("X").ToLower();
        }
        return result;
    }
    public static string textToHex(string plainText)
    {
        string hexString = "";
        for (int i = 0; i < plainText.Length; i++)
        {
            int numText = Convert.ToInt32(Convert.ToChar(plainText[i]));
            hexString += numText.ToString("X").ToLower();
        }
        return hexString;
    }
    public static string hexToText(string hexText)
    {
        string plainText = "";
        for (int i = 0; i < hexText.Length; i += 2)
        {
            if ((i + 1) < hexText.Length)
            {
                string hexChar = hexText.Substring(i, 2);
                int hexInt = Convert.ToInt32(hexChar, 16);
                plainText += Char.ConvertFromUtf32(hexInt);
            }
        }
        return plainText;
    }
    public static void Main()
    {
        List<string> hexList = new List<string>();
        string hex1 = "9d6e7a7d155295eef8512c087da56084f743aaa9985ee3848a768c3484d2e2ea6b3f4e5483f612d55987ff4782f360bd4809bab835fa1e65f8459c6814472508cc7f72241ee70c34fb9e7c8c4c246132845d5d73d070de99a73efe1e9ee627ea8f4aaae147087cce6c8cd08813f81caf9d7120486b16";
        string hex2 = "8968617d0f1b97e5ee51280f3aec72caf106bdb48d44a68291339e35db86b6f56f2140548bf253cd1593e8498baa34ba4f02fda070e25075b04387681b473610cc7f75614ae21a3efb8672d85d3e2031cc5b5a23c17ad9cda334ef10";
        string hex3 = "8f6f3779154f99e8e014375c34a267c1e745bbad895fe391c526873383cfa1e86632575481e803c41c93f94d97a738f54d02a9ec66bb1360b44ed3210206254fcc627b240bfb1d38b899788a093d2f2a9b4b1327c17edf99b224fe1e9ee66effc649a3b5430c7c9a2a91d7c51bab14e9d57d39566a5634c4340c858c5a93fff89e0394f3f49369ce9c6ee6f26b29a82e29fb9ca0a8657c48ad2c60eaf70a6b44918a40630392171ca29b87cd9e9e037c6ad2bc4be08c61ba6223a8bac0a024741b71b270a0579ab1d0308ce9b54b391a6a49ebacfc5eb5b57dd56caf0b1694544cfa6e";
        string hex4 = "9a697e6b415897fef902205c34a267d6fa42abbe985fe393972f963598c1b0fc7a3b4c17c2f101c51488f94199b667f54009b9eb7df40721ac4a963156473406cc62707406ea043cb586789c093f2f658d48433fc07ccacdaf23f54dd9a853e4df41ace6130e61986f8cd48156b11daad1692d433518349d2d0ec09a4ddafdf59e0882a4ffdd7cdd896bf7bb663ea83f37f59ca0e17a7a4aa96c25fee50d2b0d93de5f6719d91700e19e97d186d7077c2985f856ef8035ab7c66bdbadfee2a664e77bf66ac0788bac1748eacb45936196004a2b0e955b6a8798166e4";
        string hex5 = "8a68717e085ed8eae515651438a07fc9f448feb49358b19f812385249386b6f56f73461b8ce216dc0dc1e24ecfa361b74d0ebeeb7efe0921bb508a38024921118d7b757d44af1d31bed270995d3e24288d4c5a30c8738b9bb23ef25d9caa27e4c908abfc550b678b2796d4891ab512a79d772c5f2f5d3f872802cb895a93f7abd51993e5ee9376dbd072f0f27b35e43f2ffb85b7e4773242bb337caee40067079f934477149c520bfa9c81cf97d01c6125c6f352f88833af7466babc98e3247f4b70ae7cee40c9b0cc2780bba25e325e694bacbfef59a5b27d8631";
        string hex6 = "9a6972380c5a91e5f80537193ca133c7e75faea9924bb191953e8f22d7c5adf067264b1d96f853c41892ad4480bd73f54902b1af35ef1860ac02972d05013543d93d306603fb4932be8b3d8f4825613183571320c170d9cde638f41e80e173e3dc5caefb574d6fce688cc49113f515a6cf7f2c066e4c3385230885884ddcf3f898029fe1e8dd3fcc9f76f3a77d35fa2d75b281b7e56b7f45bf3225e3ff003501d78d146e018e484ee18383d187ca0d6025d5f348ed9b61ae7f33acbfddf36b774d60a86ca016d1f4c83b8dbdaf59795e624dbdbbf310a5b271813fa31400835f4eec250ddd43de10a25e790c9f28e7ebd0c74fa11181fcf79cf68d5bd75b662bbacf38d31b39cbcdc71d213d611812188ebe8855dcf857337ac75e2b36cceb0c4a729e1b7c72e78e0962c112351e62aa0f41456ebd34667929cdb06c2ffd627d7b11da0b6dd57900d0cafd9651a32e8d4247a7ab3cce24d08150ceee321b38dae50481acf00896ce1f8c7b7499dcf79008c9b5aee24b8de4ff1737116c";
        string hex7 = "876f377f04559df9ea1d695c2db971c8fc45feb69855e393972f963598c1b0fc7a3b5c5491f800d81c8cfe089aa071f54906afaf38ef1f2cab4d9f3e130636118369716107fc4938a8d269904c7623249f514073c6798bcdae29bb5f9bef68f9c65ca7f81d4d5a866fdedc8a05ac53b9cf792d49625129852e17858f53d4f1aa9c1993e9bac770cb9162a3b46622a82e2ef09fbbeb2e7942a36066fce91f330b978c557208805207f1cc9cd29392487064d6f95ba8862fea642eabf3c8f2227f5e25bc74e35386a6d6748cafe75c320c7c04a7bfef57b4fa799b6baf1d06834901";
        string hex8 = "9c647079135f94eef80265133bec67ccf006b3bc8944a69d84228f2296cae2e962364a069ba111c91188e34ccfb27af5400bbaa467f20469b50ed33c1e436601897869240be30e36a99b6990442561249e5d1327c170d8dce638f35f83a866f9ca08b8f05f0123856491c68b56b91dad9d6b2c4a6315238b2316c88b51c7fbbcd50f9ee7fbc66ccad06febb77070e92c3eb292befb613250bf2c69a3e40a3410959a14630e9d5219e780828c81ca1d766cc0f811";
        string hex9 = "9d64746a044fd8e0ee08651f2fb563d0fa41acbc8d44bad08833922998c2b1bd6f3e55188df853cd5992e44688bf71f54a02a4eb73f40221ba4d8720564328009e726d7003e00779ba9c79d84d3322379548473ac67185";
        string hex10 = "8f2175740e5893abe818351438be33cde606adb2d04fa29c8933826195c3a1fc7f20405496e9168c0a82e54d82b634b04f04afb265ef0321b74c9668144a2900872b72624aeb082dbad27c8c0937613185555673dc6cc2d7a16cef5692a874eac24deffe56142e8164ded48415b053abd1732a4d21";
        string targetHex = "866e786a0042d4abf21e305c35ad65c1b542bbbe8f55b3848032c6359fc3e2e96b21421196a107c90195a30896bc61f54906abae35fd196fb1519b2d1206320b892b7c7719e60e37b697738c0776292a9c5d132ac66a8bd1a728bb5882e629";
        hexList.Add(hex1);
        hexList.Add(hex2);
        hexList.Add(hex3);
        hexList.Add(hex4);
        hexList.Add(hex5);
        hexList.Add(hex6);
        hexList.Add(hex7);
        hexList.Add(hex8);
        hexList.Add(hex9);
        hexList.Add(hex10);
        hexList.Add(targetHex);

        List<string> commonWords = new List<string>();
        commonWords.Add(textToHex("the"));
        commonWords.Add(textToHex("of"));
        commonWords.Add(textToHex("and"));
        commonWords.Add(textToHex("a"));
        commonWords.Add(textToHex("to"));
        commonWords.Add(textToHex("in"));
        commonWords.Add(textToHex("is"));
        commonWords.Add(textToHex("be"));
        commonWords.Add(textToHex("that"));
        commonWords.Add(textToHex("was"));
        commonWords.Add(textToHex("he"));
        commonWords.Add(textToHex("for"));
        commonWords.Add(textToHex("it"));
        commonWords.Add(textToHex("with"));
        commonWords.Add(textToHex("as"));
        commonWords.Add(textToHex("his"));
        commonWords.Add(textToHex("i"));
        commonWords.Add(textToHex("on"));
        commonWords.Add(textToHex("have"));
        commonWords.Add(textToHex("at"));
        commonWords.Add(textToHex("by"));
        commonWords.Add(textToHex("not"));
        commonWords.Add(textToHex("they"));
        commonWords.Add(textToHex("this"));
        commonWords.Add(textToHex("had"));
        commonWords.Add(textToHex("are"));
        commonWords.Add(textToHex("but"));
        commonWords.Add(textToHex("from"));
        commonWords.Add(textToHex("or"));
        commonWords.Add(textToHex("she"));

        //Proof of results from conversion functions
        //Console.WriteLine(hexToText(textToHex("Hello world123!")));
        //Console.WriteLine(hexToText("48656c6c6f20576f726c6431323321")); //Hello world123!

        //Inital crib of common words at start of each hex xor permutations
        for (int j = 0; j < hexList.Count - 1; j++)
        {
            for (int h = 0; h < hexList.Count - 1; h++)
            {
                for (int i = 0; i < commonWords.Count; i++)
                {
                    if (h != j && h > j)
                    {
                        Console.WriteLine("Xor word \"{0,-4}\" with hex{1,-2} xor hex{2,-2} --> Result:{3}", hexToText(commonWords[i]), j + 1, h + 1, hexToText(xorString((commonWords[i]), (xorString(hexList[j], hexList[h])))));
                    }
                }
                if (h > j && h != hexList.Count - 1)
                {
                    Console.Write("\n");
                }
            }
        }

        for (int i = 0; i < hexList.Count; i++)
        {
            Console.WriteLine("{0,-2}-->{1}", i + 1, hexList[i].Length);
        }
        Console.Write("\n");

        /* 
         * Hex 3 and Hex 7 are the two largest excluding Hex 6 and will make cracking the others easier 
         * From the intial crib drag 
         * in --> an
         * is --> as
         * for --> nor
         * it --> at
         * as --> is
         * i --> a
         * at --> it
        */

        List<string> cribResults = new List<string>();
        cribResults.Add(textToHex("an"));
        cribResults.Add(textToHex("as"));
        cribResults.Add(textToHex("nor"));
        cribResults.Add(textToHex("at"));
        cribResults.Add(textToHex("is"));
        cribResults.Add(textToHex("a"));
        cribResults.Add(textToHex("it"));

        string xorResult = xorString(hex3, hex7);
        for (int j = 0; j < cribResults.Count; j++)
        {
            Console.WriteLine("Using word {0}", hexToText(cribResults[j]));
            for (int i = 0; i < xorResult.Length - cribResults[j].Length + 1; i += 2)
            {
                Console.WriteLine(hexToText(xorString(cribResults[j], xorResult.Substring(i, cribResults[j].Length))));
            }
            Console.Write("\n");
        }

        //Looking at the xor of 3 and 7 you get `an` from `in` looking at the xor of 4 and 7 you get `th`
        //Thus:
        //The start of hex7 is `in`
        //The start of hex4 is `th`
        //The start of hex3 is `an`
        Console.WriteLine(xorString((textToHex("in")), (hex7.Substring(0, 4))));
        //The start of the key is `ee01`
        Console.WriteLine(hexToText(xorString("ee01", (hex1.Substring(0, 4)))));
        //The start of hex1 is 'so'
        Console.WriteLine(hexToText(xorString("ee01", (hex2.Substring(0, 4)))));
        //The start of hex2 is 'gi'
        Console.WriteLine(hexToText(xorString("ee01", (hex5.Substring(0, 4)))));
        //The start of hex5 is 'di'
        Console.WriteLine(hexToText(xorString("ee01", (hex6.Substring(0, 4)))));
        //The start of hex6 is 'th'
        Console.WriteLine(hexToText(xorString("ee01", (hex8.Substring(0, 4)))));
        //The start of hex8 is 're'
        Console.WriteLine(hexToText(xorString("ee01", (hex9.Substring(0, 4)))));
        //The start of hex9 is 'se'
        Console.WriteLine(hexToText(xorString("ee01", (hex10.Substring(0, 4)))));
        //The start of hex10 is 'a '
        Console.Write("\n");

        List<string> cribResults2 = new List<string>();
        cribResults2.Add(textToHex("give"));//<---
        cribResults2.Add(textToHex("gift"));

        string xorResult2 = xorString(hex2, hex7);
        for (int j = 0; j < cribResults2.Count; j++)
        {
            Console.WriteLine("Using word {0}", hexToText(cribResults2[j]));
            for (int i = 0; i < xorResult2.Length - cribResults2[j].Length + 1; i += 2)
            {
                Console.WriteLine(hexToText(xorString(cribResults2[j], xorResult2.Substring(i, cribResults2[j].Length))));
            }
            Console.Write("\n");
        }
        //The start of hex7 is `in g`
        //the start of hex2 is `give`
        Console.WriteLine(xorString((textToHex("in g")), (hex7.Substring(0, 8))));
        //The start of the key is `ee011718`
        Console.WriteLine(hexToText(xorString("ee011718", (hex1.Substring(0, 8)))));
        //The start of hex1 is 'some'
        Console.WriteLine(hexToText(xorString("ee011718", (hex3.Substring(0, 8)))));
        //The start of hex3 is 'an a'
        Console.WriteLine(hexToText(xorString("ee011718", (hex4.Substring(0, 8)))));
        //The start of hex4 is 'this'
        Console.WriteLine(hexToText(xorString("ee011718", (hex5.Substring(0, 8)))));
        //The start of hex5 is 'diff'
        Console.WriteLine(hexToText(xorString("ee011718", (hex6.Substring(0, 8)))));
        //The start of hex6 is 'the '
        Console.WriteLine(hexToText(xorString("ee011718", (hex8.Substring(0, 8)))));
        //The start of hex8 is 'rega'
        Console.WriteLine(hexToText(xorString("ee011718", (hex9.Substring(0, 8)))));
        //The start of hex9 is 'secr'
        Console.WriteLine(hexToText(xorString("ee011718", (hex10.Substring(0, 8)))));
        //The start of hex10 is 'a bl'
        Console.Write("\n");

        List<string> cribResults3 = new List<string>();
        cribResults3.Add(textToHex("someway"));
        cribResults3.Add(textToHex("someone"));
        cribResults3.Add(textToHex("someday"));
        cribResults3.Add(textToHex("somehow"));
        cribResults3.Add(textToHex("sometime"));//<---
        cribResults3.Add(textToHex("somewhat"));
        cribResults3.Add(textToHex("somebody"));

        string xorResult3 = xorString(hex1, hex7);
        for (int j = 0; j < cribResults3.Count; j++)
        {
            Console.WriteLine("Using word {0}", hexToText(cribResults3[j]));
            for (int i = 0; i < xorResult3.Length - cribResults3[j].Length + 1; i += 2)
            {
                Console.WriteLine(hexToText(xorString(cribResults3[j], xorResult3.Substring(i, cribResults3[j].Length))));
            }
            Console.Write("\n");
        }
        //The start of hex7 is `in gener'
        Console.WriteLine(xorString((textToHex("in gener")), (hex7.Substring(0, 16))));
        //The start of the key is `ee011718613bf88b`
        Console.WriteLine(hexToText(xorString("ee011718613bf88b", (hex1.Substring(0, 16)))));
        //The start of hex1 is 'sometime'
        Console.WriteLine(hexToText(xorString("ee011718613bf88b", (hex2.Substring(0, 16)))));
        //The start of hex2 is 'given on'
        Console.WriteLine(hexToText(xorString("ee011718613bf88b", (hex3.Substring(0, 16)))));
        //The start of hex3 is 'an attac'
        Console.WriteLine(hexToText(xorString("ee011718613bf88b", (hex4.Substring(0, 16)))));
        //The start of hex4 is 'this cou'
        Console.WriteLine(hexToText(xorString("ee011718613bf88b", (hex5.Substring(0, 16)))));
        //The start of hex5 is 'diffie a'
        Console.WriteLine(hexToText(xorString("ee011718613bf88b", (hex6.Substring(0, 16)))));
        //The start of hex6 is 'the main'
        Console.WriteLine(hexToText(xorString("ee011718613bf88b", (hex8.Substring(0, 16)))));
        //The start of hex8 is 'regardle'
        Console.WriteLine(hexToText(xorString("ee011718613bf88b", (hex9.Substring(0, 16)))));
        //The start of hex9 is 'secret k'
        Console.WriteLine(hexToText(xorString("ee011718613bf88b", (hex10.Substring(0, 16)))));
        //The start of hex10 is 'a block '
        Console.Write("\n");

        Console.WriteLine(hexToText(xorString(textToHex("diffie and hellman"), xorString(hex5, hex7).Substring(0, 36))));
        Console.WriteLine(xorString((textToHex("in general, public")), (hex7.Substring(0, 72))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526", (hex1.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526", (hex2.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526", (hex3.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526", (hex4.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526", (hex5.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526", (hex6.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526", (hex7.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526", (hex8.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526", (hex9.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526", (hex10.Substring(0, 72)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is be`
         * hex2 = `given one msg and`
         * hex3 = `an attacker interc`
         * hex4 = `this course introd`
         * hex5 = `diffie and hellman`
         * hex6 = `the mainstream cry`
         * hex7 = `in general, public`
         * hex8 = `regardless of the `
         * hex9 = `secret key cryptog`
         * hex10= `a block cipher is `
         */

        Console.WriteLine(hexToText(xorString(textToHex("secret key cryptography"), xorString(hex9, hex7).Substring(0, 46))));
        Console.WriteLine(xorString((textToHex("in general, public key ")), (hex7.Substring(0, 46))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3", (hex1.Substring(0, 46)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3", (hex2.Substring(0, 46)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3", (hex3.Substring(0, 46)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3", (hex4.Substring(0, 46)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3", (hex5.Substring(0, 46)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3", (hex6.Substring(0, 46)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3", (hex7.Substring(0, 46)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3", (hex8.Substring(0, 46)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3", (hex9.Substring(0, 46)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3", (hex10.Substring(0, 46)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is better `
         * hex2 = `given one msg and ciphe`
         * hex3 = `an attacker intercepts `
         * hex4 = `this course introduces `
         * hex5 = `diffie and hellman intr`
         * hex6 = `the mainstream cryptogr`
         * hex7 = `in general, public key `
         * hex8 = `regardless of the mathe`
         * hex9 = `secret key cryptography`
         * hex10= `a block cipher is so-ca`
         */

        Console.WriteLine(hexToText(xorString(textToHex("a block cipher is so-called"), xorString(hex10, hex7).Substring(0, 54))));
        Console.WriteLine(xorString((textToHex("in general, public key cryp")), (hex7.Substring(0, 54))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e6", (hex1.Substring(0, 54)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e6", (hex2.Substring(0, 54)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e6", (hex3.Substring(0, 54)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e6", (hex4.Substring(0, 54)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e6", (hex5.Substring(0, 54)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e6", (hex6.Substring(0, 54)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e6", (hex7.Substring(0, 54)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e6", (hex8.Substring(0, 54)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e6", (hex9.Substring(0, 54)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e6", (hex10.Substring(0, 54)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is better to j`
         * hex2 = `given one msg and ciphertex`
         * hex3 = `an attacker intercepts a pa`
         * hex4 = `this course introduces cryp`
         * hex5 = `diffie and hellman introduc`
         * hex6 = `the mainstream cryptographi`
         * hex7 = `in general, public key cryp`
         * hex8 = `regardless of the mathemati`
         * hex9 = `secret key cryptography met`
         * hex10= `a block cipher is so-called`
         */

        Console.WriteLine(hexToText(xorString(textToHex("in general, public key cryptography"), xorString(hex10, hex7).Substring(0, 70))));
        Console.WriteLine(xorString((textToHex("a block cipher is so-called because ")), (hex10.Substring(0, 72))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574", (hex1.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574", (hex2.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574", (hex3.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574", (hex4.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574", (hex5.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574", (hex6.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574", (hex7.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574", (hex8.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574", (hex9.Substring(0, 72)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574", (hex10.Substring(0, 72)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is better to just walk `
         * hex2 = `given one msg and ciphertext, there `
         * hex3 = `an attacker intercepts a particular `
         * hex4 = `this course introduces cryptographic`
         * hex5 = `diffie and hellman introduced the co`
         * hex6 = `the mainstream cryptographic communi`
         * hex7 = `in general, public key cryptography `
         * hex8 = `regardless of the mathematical theor`
         * hex9 = `secret key cryptography methods empl`
         * hex10= `a block cipher is so-called because `
         */

        Console.WriteLine(hexToText(xorString(textToHex("the mainstream cryptographic community "), xorString(hex6, hex7).Substring(0, 78))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography sys")), (hex7.Substring(0, 78))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173", (hex1.Substring(0, 78)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173", (hex2.Substring(0, 78)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173", (hex3.Substring(0, 78)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173", (hex4.Substring(0, 78)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173", (hex5.Substring(0, 78)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173", (hex6.Substring(0, 78)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173", (hex7.Substring(0, 78)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173", (hex8.Substring(0, 78)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173", (hex9.Substring(0, 78)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173", (hex10.Substring(0, 78)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is better to just walk awa`
         * hex2 = `given one msg and ciphertext, there is `
         * hex3 = `an attacker intercepts a particular cip`
         * hex4 = `this course introduces cryptographic pr`
         * hex5 = `diffie and hellman introduced the conce`
         * hex6 = `the mainstream cryptographic community `
         * hex7 = `in general, public key cryptography sys`
         * hex8 = `regardless of the mathematical theory b`
         * hex9 = `secret key cryptography methods employ `
         * hex10= `a block cipher is so-called because the`
         */

        Console.WriteLine(hexToText(xorString(textToHex("diffie and hellman introduced the concept of public key cryptography"), xorString(hex5, hex7).Substring(0, 136))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve proble")), (hex7.Substring(0, 136))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d04", (hex1.Substring(0, 136)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d04", (hex2.Substring(0, 136)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d04", (hex3.Substring(0, 136)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d04", (hex4.Substring(0, 136)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d04", (hex5.Substring(0, 136)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d04", (hex6.Substring(0, 136)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d04", (hex7.Substring(0, 136)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d04", (hex8.Substring(0, 136)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d04", (hex9.Substring(0, 136)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d04", (hex10.Substring(0, 136)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is better to just walk away from things and go back to `
         * hex2 = `given one msg and ciphertext, there is already one key that maps the`
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if `
         * hex4 = `this course introduces cryptographic primitives and how they are imp`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-b`
         * hex7 = `in general, public key cryptography systems use hard-to-solve proble`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best `
         * hex9 = `secret key cryptography methods employ a single key for both encrypt`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of`
         */

        Console.WriteLine(hexToText(xorString(textToHex("secret key cryptography methods employ a single key for both encryption and decryption"), xorString(hex9, hex7).Substring(0, 172))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of")), (hex7.Substring(0, 172))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91f", (hex1.Substring(0, 172)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91f", (hex2.Substring(0, 172)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91f", (hex3.Substring(0, 172)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91f", (hex4.Substring(0, 172)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91f", (hex5.Substring(0, 172)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91f", (hex6.Substring(0, 172)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91f", (hex7.Substring(0, 172)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91f", (hex8.Substring(0, 172)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91f", (hex9.Substring(0, 172)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91f", (hex10.Substring(0, 172)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when yo`
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphe`
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows tha`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applic`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too sho`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are tho`
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time us`
         */

        Console.WriteLine(hexToText(xorString(textToHex("given one msg and ciphertext, there is already one key that maps the msg to that ciphertext"), xorString(hex2, hex7).Substring(0, 180))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the ")), (hex7.Substring(0, 182))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b", (hex1.Substring(0, 182)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b", (hex2.Substring(0, 182)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b", (hex3.Substring(0, 182)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b", (hex4.Substring(0, 182)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b", (hex5.Substring(0, 182)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b", (hex6.Substring(0, 182)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b", (hex7.Substring(0, 182)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b", (hex8.Substring(0, 182)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b", (hex9.Substring(0, 174)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b", (hex10.Substring(0, 182)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are`
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext`
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in application`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "tri`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the `
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those th`
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using t`
         */

        Console.WriteLine(hexToText(xorString(textToHex("regardless of the mathematical theory behind an algorithm, the best algorithms are those that"), xorString(hex8, hex7).Substring(0, 186))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the al")), (hex7.Substring(0, 186))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef7", (hex1.Substring(0, 186)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef7", (hex2.Substring(0, 184)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef7", (hex3.Substring(0, 186)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef7", (hex4.Substring(0, 186)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef7", (hex5.Substring(0, 186)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef7", (hex6.Substring(0, 186)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef7", (hex7.Substring(0, 186)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef7", (hex8.Substring(0, 186)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef7", (hex10.Substring(0, 186)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are i`
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.`
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the i`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications.`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to w`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the al`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that`
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the`
         */

        Console.WriteLine(hexToText(xorString(textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm"), xorString(hex8, hex7).Substring(0, 200))));
        Console.WriteLine(xorString((textToHex("regardless of the mathematical theory behind an algorithm, the best algorithms are those that are we")), (hex8.Substring(0, 200))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95", (hex1.Substring(0, 200)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95", (hex3.Substring(0, 200)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95", (hex4.Substring(0, 200)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95", (hex5.Substring(0, 200)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95", (hex6.Substring(0, 200)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95", (hex7.Substring(0, 200)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95", (hex8.Substring(0, 200)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95", (hex10.Substring(0, 200)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a bet`
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial `
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of di`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstan`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are we`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same k`
         * 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include"), xorString(hex4, hex7).Substring(0, 232))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predo")), (hex7.Substring(0, 232))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c4926", (hex1.Substring(0, 232)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c4926", (hex3.Substring(0, 232)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c4926", (hex4.Substring(0, 232)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c4926", (hex5.Substring(0, 232)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c4926", (hex6.Substring(0, 232)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c4926", (hex7.Substring(0, 232)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c4926", (hex8.Substring(0, 232)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c4926", (hex10.Substring(0, 232)))));
        Console.Write("\n");

        /*
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of min`
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happ`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force `
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predo`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and wel`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block`
         * 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack"), xorString(hex6, hex7).Substring(0, 244))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant")), (hex7.Substring(0, 244))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063", (hex1.Substring(0, 236)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063", (hex3.Substring(0, 244)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063", (hex4.Substring(0, 244)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063", (hex5.Substring(0, 244)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063", (hex6.Substring(0, 244)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063", (hex7.Substring(0, 244)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063", (hex8.Substring(0, 244)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063", (hex10.Substring(0, 234)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symm`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key excha`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-docu`
         *
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption"), xorString(hex4, hex7).Substring(0, 284))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for")), (hex7.Substring(0, 284))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950", (hex3.Substring(0, 284)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950", (hex4.Substring(0, 284)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950", (hex5.Substring(0, 284)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950", (hex6.Substring(0, 284)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950", (hex7.Substring(0, 284)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950", (hex8.Substring(0, 284)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is re`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern compute`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they `
         *
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers"), xorString(hex6, hex7).Substring(0, 288))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for p")), (hex7.Substring(0, 288))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e", (hex3.Substring(0, 288)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e", (hex4.Substring(0, 288)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e", (hex5.Substring(0, 288)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e", (hex6.Substring(0, 288)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e", (hex7.Substring(0, 288)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e", (hex8.Substring(0, 288)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by p`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption a`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is rela`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for p`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they ar`
         *
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are"), xorString(hex8, hex7).Substring(0, 290))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography")), (hex7.Substring(0, 332))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9", (hex3.Substring(0, 332)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9", (hex4.Substring(0, 332)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9", (hex5.Substring(0, 332)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9", (hex6.Substring(0, 332)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9", (hex7.Substring(0, 332)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9", (hex8.Substring(0, 332)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attack`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key `
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and`
         *
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker "), xorString(hex3, hex7).Substring(0, 338))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is")), (hex7.Substring(0, 338))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82", (hex3.Substring(0, 338)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82", (hex4.Substring(0, 338)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82", (hex5.Substring(0, 338)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82", (hex6.Substring(0, 338)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82", (hex7.Substring(0, 338)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82", (hex8.Substring(0, 338)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker `
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key enc`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute ex`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: c`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and we`
         *
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption"), xorString(hex4, hex7).Substring(0, 352))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, b")), (hex7.Substring(0, 352))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be6812", (hex3.Substring(0, 352)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be6812", (hex4.Substring(0, 352)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be6812", (hex5.Substring(0, 352)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be6812", (hex6.Substring(0, 352)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be6812", (hex7.Substring(0, 352)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be6812", (hex8.Substring(0, 352)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will kn`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, b`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-stud`
         *
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied."), xorString(hex8, hex7).Substring(0, 360))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based")), (hex7.Substring(0, 360))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f", (hex3.Substring(0, 360)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f", (hex4.Substring(0, 360)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f", (hex5.Substring(0, 360)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f", (hex6.Substring(0, 360)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f", (hex7.Substring(0, 360)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f", (hex8.Substring(0, 360)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know t`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, di`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents com`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer pow`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based`
         * 
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("diffie and hellman introduced the concept of public key cryptography. the mathematical \"trick\" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared"), xorString(hex5, hex7).Substring(0, 370))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on t")), (hex7.Substring(0, 370))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca10", (hex3.Substring(0, 370)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca10", (hex4.Substring(0, 370)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca10", (hex5.Substring(0, 370)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca10", (hex6.Substring(0, 370)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca10", (hex7.Substring(0, 370)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the pr`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power do`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on t`
         * 
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles"), xorString(hex6, hex7).Substring(0, 380))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the p")), (hex7.Substring(0, 380))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8", (hex3.Substring(0, 380)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8", (hex4.Substring(0, 380)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8", (hex5.Substring(0, 380)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8", (hex6.Substring(0, 380)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8", (hex7.Substring(0, 380)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital sig`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared to `
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power double`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the p`
         * 
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signature"), xorString(hex4, hex7).Substring(0, 392))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factor")), (hex7.Substring(0, 402))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4", (hex3.Substring(0, 402)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4", (hex4.Substring(0, 402)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4", (hex5.Substring(0, 402)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4", (hex6.Substring(0, 402)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4", (hex7.Substring(0, 402)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pse`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, an`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared to computing d`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 `
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factor`
         * 
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random"), xorString(hex3, hex7).Substring(0, 422))));
        Console.WriteLine(xorString((textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factors of very ")), (hex7.Substring(0, 422))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524", (hex3.Substring(0, 422)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524", (hex4.Substring(0, 422)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524", (hex5.Substring(0, 422)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524", (hex6.Substring(0, 422)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524", (hex7.Substring(0, 422)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, and message `
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared to computing discrete lo`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. gi`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factors of very `
         * 
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random random"), xorString(hex3, hex6).Substring(0, 438))));
        Console.WriteLine(xorString((textToHex("the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that")), (hex6.Substring(0, 440))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f5", (hex3.Substring(0, 440)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f5", (hex4.Substring(0, 440)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f5", (hex5.Substring(0, 438)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f5", (hex6.Substring(0, 440)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f5", (hex7.Substring(0, 440)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random random `
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, and message integrit`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared to computing discrete logarithms`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factors of very large in`
         * 
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random random "), xorString(hex3, hex6).Substring(0, 436))));
        Console.WriteLine(xorString((textToHex("the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that")), (hex6.Substring(0, 436))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f5", (hex3.Substring(0, 436)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f5", (hex4.Substring(0, 436)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f5", (hex5.Substring(0, 436)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f5", (hex6.Substring(0, 436)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f5", (hex7.Substring(0, 436)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random random `
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factors of very large in`
         * 
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, and message integrit`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared to computing discrete logarithms`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */


        Console.WriteLine(hexToText(xorString(textToHex("this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, and message integrity."), xorString(hex4, hex6).Substring(0, 440))));
        Console.WriteLine(xorString((textToHex("the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that i")), (hex6.Substring(0, 440))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca", (hex3.Substring(0, 440)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca", (hex4.Substring(0, 440)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca", (hex5.Substring(0, 438)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca", (hex6.Substring(0, 440)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca", (hex7.Substring(0, 440)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random random `
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factors of very large in`
         * 
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, and message integrity.`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared to computing discrete logarithms.`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */


        Console.WriteLine(hexToText(xorString(textToHex("this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, and message integrity."), xorString(hex4, hex6).Substring(0, 440))));
        Console.WriteLine(xorString((textToHex("the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that i")), (hex6.Substring(0, 440))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca", (hex3.Substring(0, 440)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca", (hex6.Substring(0, 440)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca", (hex7.Substring(0, 440)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random random `
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factors of very large in`
         * 
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, and message integrity.`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared to computing discrete logarithms.`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factors of very large integers."), xorString(hex7, hex6).Substring(0, 450))));
        Console.WriteLine(xorString((textToHex("the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that increa")), (hex6.Substring(0, 450))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca7a63f13a2f", (hex3.Substring(0, 450)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca7a63f13a2f", (hex6.Substring(0, 450)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca7a63f13a2f", (hex7.Substring(0, 450)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random random sequenc`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that increa`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factors of very large integers.`
         * 
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, and message integrity.`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared to computing discrete logarithms.`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        Console.WriteLine(hexToText(xorString(textToHex("an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random random sequence."), xorString(hex3, hex6).Substring(0, 454))));
        Console.WriteLine(xorString((textToHex("the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that increase")), (hex6.Substring(0, 454))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca7a63f13a2f9f40", (hex3.Substring(0, 454)))));
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca7a63f13a2f9f40", (hex6.Substring(0, 454)))));
        Console.Write("\n");

        /*
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random random sequence.`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that increase`
         * 
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, and message integrity.`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared to computing discrete logarithms.`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factors of very large integers.`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         */

        /*******************************
        * Conclusion and final results *
        *******************************/

        //First since the hex6 is the longest I had to get creative in finding a possible phrase to try against it, with solving the first half a quick google search using ""s around the parts I had quickly led me to a published paper an overview on cryptography by Gary C Kessler.
        Console.WriteLine(xorString((textToHex("the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that increase in power, a key that could withstand a brute-force guessing attack in 1975 could hardly be expected to withstand the same attack a quarter century later.")), (hex6.Substring(0, 762))));
        //Plugging in the right length of phrase in this case 381 characters 762/2 I can get a key that is the length of hex6. xoring it back into hex6 allows me to confirm my answer. 
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca7a63f13a2f9f402db42dfe60cd291c7eb30886cbbba2368165e99d83bc95e22ebb3f465cd3bb50a06f58a5a9e77c015f136d667da3d8e727bf9d77540fa22d585fa28c2c2b06ea7a1f19c7e76742f02b022b42c96034290a9d5c070b4da1c94c4d9842180361bf6819b01d20a4a5dde138d746fe3626c9cf1cba4cb5a123af83573b59ae9165e2c7d069b6bf6aed0900fcaed7f36da7c1db9032ad889e63526342", (hex6.Substring(0, 762)))));
        Console.Write("\n");
        //Then I simply xor the key with our target hex to find the target message though this could have been done anytime the key was the same size as the target message since 762 characters is overkill for 190 characters. 
        Console.WriteLine(hexToText(xorString("ee011718613bf88b8b71457c5dcc13a49526deddfd2cc3f0e556e641f7a6c29d0a532574e28173ac79e18d28efd314d52167ddcb159b7001d822f34876264663ec0b1d046a8f6959dbf21df829564145ec383353a91fabb9c64c9b3ef788078baf28cf95336d0eee0afeb1e576d873c9bd1c49260f3847e44063a5ee3fb39ed8f56dfb849ab31faff01b83d20950885e5b92f3d2880e1227da40058e906f4764f0fe340260f9726e82eceea1f2be681205a59c3f88e941ca1046ced3b8804b123b05da158027e9d4a554e3c9c72a577e0524cbde9d30d1da10f51fca7a63f13a2f9f402db42dfe60cd291c7eb30886cbbba2368165e99d83bc95e22ebb3f465cd3bb50a06f58a5a9e77c015f136d667da3d8e727bf9d77540fa22d585fa28c2c2b06ea7a1f19c7e76742f02b022b42c96034290a9d5c070b4da1c94c4d9842180361bf6819b01d20a4a5dde138d746fe3626c9cf1cba4cb5a123af83573b59ae9165e2c7d069b6bf6aed0900fcaed7f36da7c1db9032ad889e63526342", (targetHex.Substring(0, 190)))));


        /*
         * hex1 = `sometimes it is better to just walk away from things and go back to them later when you are in a better frame of mind.` 
         * hex2 = `given one msg and ciphertext, there is already one key that maps the msg to that ciphertext.` 
         * hex3 = `an attacker intercepts a particular ciphertext, let's call it c, if attacker knows that the initial part of msg happens to be a known value by prior knowledge, attacker will know the prefix of the pseudo random random sequence.`
         * hex4 = `this course introduces cryptographic primitives and how they are implemented in applications. Topics covered include: symmetric-key encryption algorithms, public key encryption, digital signatures, and message integrity.`
         * hex5 = `diffie and hellman introduced the concept of public key cryptography. the mathematical "trick" of diffie-hellman key exchange is that it is relatively easy to compute exponents compared to computing discrete logarithms.`
         * hex6 = `the mainstream cryptographic community has long held that des's 56-bit key was too short to withstand a brute-force attack from modern computers. remember moore's law: computer power doubles every 18 months. given that increase`
         * hex7 = `in general, public key cryptography systems use hard-to-solve problems as the basis of the algorithm. The most predominant algorithm today for public key cryptography is rsa, based on the prime factors of very large integers.`
         * hex8 = `regardless of the mathematical theory behind an algorithm, the best algorithms are those that are well-known and well-documented because they are also well-tested and well-studied.`
         * hex9 = `secret key cryptography methods employ a single key for both encryption and decryption.`
         * hex10= `a block cipher is so-called because the scheme encrypts one block of data at a time using the same key on each block.`
         * TargetHex = `hooray, you have decrypted the target text. you have finished the assignment. hope you had fun.`
         */
    }
}
