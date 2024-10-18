using System;
using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest;

[TestClass]
public class MostFrequentlyUsedWordsTests
{
    [TestMethod]
    public void MostFrequentlyUsedWordsTest()
    {
        ExecuteTest(@"In a village of La Mancha, the name of which I have no desire to call to
mind, there lived not long since one of those gentlemen that keep a lance
in the lance-rack, an old buckler, a lean hack, and a greyhound for
coursing. An olla of rather more beef than mutton, a salad on most
nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra
on Sundays, made away with three-quarters of his income.",["a", "of", "on"]);
        ExecuteTest("a a a  b  c c  d d d d  e e e e e", ["e", "d", "a"]);
        ExecuteTest("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e", ["e", "ddd", "aa"]);
        ExecuteTest("  //wont won't won't ", ["won't", "wont"]);
        ExecuteTest("  , e   .. ", ["e"]);
        ExecuteTest("  ...  ", []);
        ExecuteTest("  '  ", []);
        ExecuteTest("  '''  ",[]);
        ExecuteTest("WEkVLpG VICmjKlza cOZAuK'NMb Ydf!VICmjKlza iemwbV VICmjKlza x'Xf'rt QZcqnGCUu;cOZAuK'NMb x'Xf'rt QZcqnGCUu_cOZAuK'NMb VICmjKlza.Ydf Ydf x'Xf'rt-WEkVLpG,VICmjKlza WEkVLpG VICmjKlza-iemwbV QZcqnGCUu?cOZAuK'NMb WEkVLpG/cOZAuK'NMb?x'Xf'rt Ydf;x'Xf'rt x'Xf'rt Ydf;YeRpRJ,x'Xf'rt QZcqnGCUu WEkVLpG;x'Xf'rt iemwbV;cOZAuK'NMb.QZcqnGCUu iemwbV QZcqnGCUu-QZcqnGCUu VICmjKlza cOZAuK'NMb WEkVLpG:QZcqnGCUu/x'Xf'rt QZcqnGCUu_cOZAuK'NMb x'Xf'rt;QZcqnGCUu!QZcqnGCUu WEkVLpG?x'Xf'rt.QZcqnGCUu WEkVLpG WEkVLpG:cOZAuK'NMb,VICmjKlza_cOZAuK'NMb x'Xf'rt WEkVLpG!WEkVLpG VICmjKlza!cOZAuK'NMb x'Xf'rt VICmjKlza;QZcqnGCUu/Ydf cOZAuK'NMb-Ydf x'Xf'rt,cOZAuK'NMb;cOZAuK'NMb VICmjKlza QZcqnGCUu iemwbV VICmjKlza WEkVLpG cOZAuK'NMb VICmjKlza:cOZAuK'NMb-YeRpRJ!eEHQZ x'Xf'rt x'Xf'rt x'Xf'rt?WEkVLpG?WEkVLpG iemwbV WEkVLpG Ydf WEkVLpG iemwbV WEkVLpG Ydf cOZAuK'NMb VICmjKlza iemwbV Ydf Ydf cOZAuK'NMb!cOZAuK'NMb VICmjKlza?cOZAuK'NMb Ydf.x'Xf'rt_VICmjKlza,Ydf WEkVLpG/iemwbV WEkVLpG cOZAuK'NMb/iemwbV WEkVLpG?WEkVLpG WEkVLpG x'Xf'rt VICmjKlza x'Xf'rt iemwbV iemwbV VICmjKlza.cOZAuK'NMb:cOZAuK'NMb;iemwbV cOZAuK'NMb WEkVLpG,x'Xf'rt x'Xf'rt_x'Xf'rt!WEkVLpG iemwbV x'Xf'rt,QZcqnGCUu Ydf WEkVLpG-YeRpRJ,WEkVLpG,cOZAuK'NMb;VICmjKlza/QZcqnGCUu eEHQZ:VICmjKlza.WEkVLpG VICmjKlza-YeRpRJ Ydf x'Xf'rt:WEkVLpG x'Xf'rt Ydf-iemwbV ",["wekvlpg", "x'xf'rt", "cozauk'nmb"]);
        ExecuteTest("hQgDIzupt'.hQgDIzupt' hQgDIzupt' tplj tplj R'SNthaB.NTU'KHGSQ.hQgDIzupt' R'SNthaB!tplj NTU'KHGSQ bMWpITCbrz.tplj hQgDIzupt'_hQgDIzupt';NTU'KHGSQ wNkI_bMWpITCbrz bMWpITCbrz NTU'KHGSQ,wNkI/NzpZcl,tplj wNkI hQgDIzupt'!wNkI NTU'KHGSQ tplj.R'SNthaB.tplj R'SNthaB_hQgDIzupt'.NTU'KHGSQ bMWpITCbrz-R'SNthaB NTU'KHGSQ,tplj!hQgDIzupt'?NzpZcl NzpZcl NTU'KHGSQ tplj bMWpITCbrz?NTU'KHGSQ NzpZcl wNkI hQgDIzupt';hQgDIzupt' hQgDIzupt'-bMWpITCbrz_NzpZcl.R'SNthaB R'SNthaB hQgDIzupt' wNkI;tplj R'SNthaB R'SNthaB NTU'KHGSQ.NTU'KHGSQ bMWpITCbrz NzpZcl R'SNthaB tplj-NzpZcl hQgDIzupt' R'SNthaB/NTU'KHGSQ R'SNthaB_wNkI R'SNthaB-NzpZcl_wNkI tplj!R'SNthaB?NTU'KHGSQ-R'SNthaB;R'SNthaB_tplj.wNkI,NTU'KHGSQ hQgDIzupt'/R'SNthaB.hQgDIzupt',tplj-bMWpITCbrz hQgDIzupt'-tplj hQgDIzupt' NzpZcl?hQgDIzupt'_bMWpITCbrz hQgDIzupt'/tplj-NTU'KHGSQ NzpZcl!wNkI/R'SNthaB hQgDIzupt' NTU'KHGSQ NzpZcl NTU'KHGSQ hQgDIzupt' hQgDIzupt' tplj:NTU'KHGSQ,NTU'KHGSQ hQgDIzupt' bMWpITCbrz/NzpZcl?NzpZcl;NzpZcl NTU'KHGSQ wNkI NzpZcl hQgDIzupt' wNkI,bMWpITCbrz_wNkI/NTU'KHGSQ R'SNthaB tplj NTU'KHGSQ hQgDIzupt'!hQgDIzupt' NzpZcl!R'SNthaB hQgDIzupt' wNkI NTU'KHGSQ NTU'KHGSQ?NzpZcl ",["hqgdizupt'", "ntu'khgsq", "r'snthab"]);
    }

    private void ExecuteTest(string input, string[] expected)
    {
        Console.WriteLine(input);
        MostFrequentlyUsedWords.Top3(input).Should().BeEquivalentTo(expected);
    }
    
}