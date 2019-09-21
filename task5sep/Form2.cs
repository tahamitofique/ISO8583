using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISO8583MsgParserGenerator
{
    public partial class Form2 : Form
    {
        static String hG, mtiG, pmG, smG;
        public String panG,pcG,atG,asG,acbG,tdtG,acbfG,crsG,crcbG,stanG,tltG,dltG,dexpG,dsetG,dconG,dcapG,mtG,aiccG,panccG,ficcG,psemG,csnG,niiG,posccG,pospccG,airl1G,atfG,asfG,atpfG,aspfG,aiicG,fiicG,paneG,t2dG,t3dG,rrnG,airG,rcG,srcG,catiG,caicG,canlG,ardG,t1dG,adISOG,adNATIONALG,adPVTG,cctG,ccsG,cccbG,PINdG,srciG,aaG,ICCsrdG,rsvISOG,rsvNATIONAL1G, rsvNATIONAL2G, rsvNATIONAL3G,arcG,POSdG,INFdG,ndG,MACG,bmextG,scG,epcG,riccG;
        public String siccG, nmicG, mnG, mnlG, dateaG, crdtnoG, crdtrnoG, debtnoG, debtrnoG, tnoG, trnoG, inoG, anoG, cpfaG, ctfaG, dpfaG, dtfaG, crdtaG, crdtraG, debtaG, debtraG, odeG, fucG, fscG, riG, siG, raG, mscG, ansG, pG, siicG, riicG, fnG, ai1G, ai2G, tdG, rsviso1G, rsviso2G, rsviso3G, rsviso4G, rsviso5G, rsviso6G, rsviso7G, adddataNatG, rsvN1G, rsvN2G, rsvN3G, rsvN4G, rsvN5G, rsvN6G, rsvN7G, rdG, aaicG, rsvfutr1G, rsvfutr2G, rsvfutr3G, rsvfutr4G, rsvpvtG, pvtdataG, MAC2G;
        public String finalMsg, ff;
        private void submitbtn2_Click_1(object sender, EventArgs e)
        {
            hG = msgheadertxt.Text;
            mtiG = MTItxt.Text; ;
            //pmG = BMpritxt.Text;
            smG = BMsectxt.Text;
            panG = PANBox.Text;
            pcG = PCtxt.Text;
            atG = amtTrantxt.Text;
            asG = amtSettxt.Text;
            acbG = amtbilltxt.Text;
            tdtG = tranDTtxt.Text;
            acbfG = amtbillfeetxt.Text;
            crsG = convrtsettxt.Text;
            crcbG = convrtCbilltxt.Text;
            stanG = sysTaudnotxt.Text;
            tltG = timeLtrantxt.Text;
            dltG = dateLtrantxt.Text;
            dexpG = dateExptxt.Text;
            dsetG = dateSettxt.Text;
            dconG = dateConvtxt.Text;
            dcapG = dateCaptxt.Text;
            mtG = mTypetxt.Text;
            aiccG = AICCtxt.Text;
            panccG = PANcctxt.Text;
            ficcG = fwdIcctxt.Text;
            psemG = pntsvcEMtxt.Text;
            csnG = cardSnotxt.Text;
            niiG = NIItxt.Text;
            posccG = POSccISOtxt.Text;
            pospccG = POSpcctxt.Text;
            airl1G = authIdenResLntxt.Text;
            atfG = amtTranFeetxt.Text;
            asfG = amtSetFeetxt.Text; ;
            atpfG = amtTranPrcsFeetxt.Text;
            aspfG = amtSetPrcsFeetxt.Text;
            aiicG = acqIidenCodetxt.Text;
            fiicG = fwdIidenCodetxt.Text;
            paneG = PANexttxt.Text;
            t2dG = T2Datatxt.Text;
            t3dG = T3Datatxt.Text;
            rrnG = retRefNotxt.Text;
            airG = authIrestxt.Text;
            rcG = rspnsCodetxt.Text;
            srcG = SRcodetxt.Text;
            catiG = cdAcptTerIdentxt.Text;
            caicG = cdAcptIdenCdtxt.Text;
            canlG = cdAcptNameLoctxt.Text;
            ardG = addResDatatxt.Text;
            t1dG = T1datatxt.Text;
            adISOG = addDataISOtxt.Text;
            adNATIONALG = addDataNttxt.Text;
            adPVTG = addDatapvttxt.Text;
            cctG = currCodeTrantxt.Text;
            ccsG = currCodeSettxt.Text;
            cccbG = currCodeCdHldrBilltxt.Text;
            PINdG = PINdatatxt.Text;
            srciG = SecRlConInfotxt.Text;
            aaG = addAmttxt.Text;
            ICCsrdG = ICCsysRelDatatxt.Text;
            rsvISOG = resISOusetxt.Text;
            rsvNATIONAL1G = resNational1txt.Text;
            rsvNATIONAL2G = resNational2txt.Text;
            rsvNATIONAL3G = resNational3txt.Text;
            arcG = advRsnCodetxt.Text;
            POSdG = POSdatatxt.Text;
            INFdG = INFdatatxt.Text;
            ndG = ntwkDatatxt.Text;
            MACG = MACtxt.Text;
            bmextG = BMextdtxt.Text;
            scG = setCodetxt.Text;
            epcG = extdPayCodetxt.Text;
            riccG = rcvInsCntryCodetxt.Text;
            siccG = setInsCntryCodetxt.Text;
            nmicG = NMIcodetxt.Text;
            mnG = msgNotxt.Text;
            mnlG = msgNoLasttxt.Text;
            dateaG = dateActtxt.Text;
            crdtnoG = crdtNotxt.Text;
            crdtraG = crdtRevNotxt.Text;
            debtnoG = debtNotxt.Text;
            debtrnoG = debtRevAmttxt.Text;
            tnoG = transNotxt.Text;
            trnoG = transRevNotxt.Text;
            inoG = inqNotxt.Text;
            anoG = authNotxt.Text;
            cpfaG = crdtPrcsFeeAmttxt.Text;
            ctfaG = crdtTransFeeAmttxt.Text;
            dpfaG = debtPrcsFeeAmttxt.Text;
            dtfaG = debtTransFeeAmttxt.Text;
            crdtaG = crdtAmttxt.Text;
            crdtraG = crdtRevAmttxt.Text;
            debtaG = debtAmttxt.Text;
            debtraG = debtRevAmttxt.Text;
            odeG = orgnlDataElmnttxt.Text;
            fucG = fileUpdtCodetxt.Text;
            fscG = fileSecCodetxt.Text;
            riG = rspIndtxt.Text;
            siG = svcIndctxt.Text;
            raG = rplcAmttxt.Text;
            mscG = msgSecCodetxt.Text;
            ansG = amtNtSettxt.Text;
            pG = payee.Text;
            siicG = setInstIdenCodetxt.Text;
            riicG = rcvInstIdenCodetxt.Text;
            fnG = fileNametxt.Text;
            ai1G = accIden1txt.Text;
            ai2G = accIden2txt.Text;
            tdG = transDesctxt.Text;
            rsviso1G = rsvISOuse1txt.Text;
            rsviso2G = rsvISOuse2txt.Text;
            rsviso3G = rsvISOuse3txt.Text;
            rsviso4G = rsvISOuse4txt.Text;
            rsviso5G = rsvISOuse5txt.Text;
            rsviso6G = rsvISOuse6txt.Text;
            rsviso7G = rsvISOuse7txt.Text;
            adddataNatG = addDataNusetxt.Text;
            rsvN1G = rsvNuse1txt.Text;
            rsvN2G = rsvNuse2txt.Text;
            rsvN3G = rsvNuse3txt.Text;
            rsvN4G = rsvNuse4txt.Text;
            rsvN5G = rsvNuse5txt.Text;
            rsvN6G = rsvNuse6txt.Text;
            rsvN7G = rsvNuse7txt.Text;
            rdG = rcdDatatxt.Text;
            aaicG = authAgntIdenCodetxt.Text;
            rsvfutr1G = addRcdDatatxt.Text;
            rsvfutr2G = rsvFutrDefMstr1txt.Text;
            rsvfutr3G = rsvFutrDefMstr2txt.Text;
            rsvfutr4G = rsvFutrDefMstr3txt.Text;
            rsvpvtG = pvtData1txt.Text;
            pvtdataG = pvtData2txt.Text;
            MAC2G = MAC2txt.Text;
            createmsg();
        }

        private void createmsg()
        {
            String pbm=null,sbm=null;
            string[] hello1 = { smG, panG, pcG, atG, asG, acbG, tdtG, acbfG, crsG, crcbG, stanG, tltG, dltG, dexpG, dsetG, dconG, dcapG, mtG, aiccG, panccG, ficcG, psemG, csnG, niiG, posccG, pospccG, airl1G, atfG, asfG, atpfG, aspfG, aiicG, fiicG, paneG, t2dG, t3dG, rrnG, airG, rcG, srcG, catiG, caicG, canlG, ardG, t1dG, adISOG, adNATIONALG, adPVTG, cctG, ccsG, cccbG, PINdG, srciG, aaG, ICCsrdG, rsvISOG, rsvNATIONAL1G, rsvNATIONAL2G, rsvNATIONAL3G, arcG, POSdG, INFdG, ndG, MACG };
            string[] hello2 = { bmextG, scG, epcG, riccG, siccG, nmicG, mnG, mnlG, dateaG, crdtnoG, crdtrnoG, debtnoG, debtrnoG, tnoG, trnoG, inoG, anoG, cpfaG, ctfaG, dpfaG, dtfaG, crdtaG, crdtraG, debtaG, debtraG, odeG, fucG, fscG, riG, siG, raG, mscG, ansG, pG, siicG, riicG, fnG, ai1G, ai2G, tdG, rsviso1G, rsviso2G, rsviso3G, rsviso4G, rsviso5G, rsviso6G, rsviso7G, adddataNatG, rsvN1G, rsvN2G, rsvN3G, rsvN4G, rsvN5G, rsvN6G, rsvN7G, rdG, aaicG, rsvfutr1G, rsvfutr2G, rsvfutr3G, rsvfutr4G, rsvpvtG, pvtdataG, MAC2G };
            pbm = bmcreate(hello1);
            pmG=bincon(pbm);
            finalMsg += hG;
            finalMsg += mtiG;
            finalMsg += pmG;
            if (pbm[0] == '1')
            {
                sbm = bmcreate(hello2);
                smG = bincon(sbm);
                finalMsg += smG;
            }
            finalMsg+=panG.Length;
            msggcreate(hello1.Skip(1).Take(30).ToArray());
            msggcreatellvar(hello1.Skip(31).Take(4).ToArray());
            msggcreatelllvar(hello1.Skip(35).Take(1).ToArray());
            msggcreate(hello1.Skip(36).Take(7).ToArray());
            msggcreatellvar(hello1.Skip(43).Take(2).ToArray());
            msggcreatelllvar(hello1.Skip(45).Take(3).ToArray());
            msggcreate(hello1.Skip(48).Take(5).ToArray());
            msggcreatelllvar(hello1.Skip(53).Take(10).ToArray());
            msggcreate(hello2.Skip(0).Take(35).ToArray());     //63
            msggcreatellvar(hello2.Skip(35).Take(5).ToArray());//29
            msggcreatelllvar(hello2.Skip(40).Take(8).ToArray());
            msggcreatellvar(hello2.Skip(48).Take(1).ToArray());
            msggcreatelllvar(hello2.Skip(49).Take(15).ToArray());
            msggcreate(hello2.Skip(64).Take(1).ToArray());
            finalMsg += ff;

            MessageBox.Show(finalMsg);

        }
        private void msggcreate(string[] bm)
        {
            foreach (String a in bm)
            {
                if (a != "")
                {
                    ff += a;
                }
            }
        }
        private void msggcreatellvar(string[] bm)
        {
            foreach (String b in bm)
            {
                if (b != "")
                {
                    int k = b.Length;
                    String ll = string.Format(String.Format("{0:D2}", k));
                    ff += ll;
                    ff += b;
                }
            }
        }
        private void msggcreatelllvar(string[] bm)
        {
            foreach (String b in bm)
            {
                if (b != "")
                {
                    int k = b.Length;
                    String lll = string.Format(String.Format("{0:D3}", k));
                    ff += lll;
                    ff += b;
                }
            }
        }
        private string bmcreate(string[] bm)
        {
            String bmn = null;
            foreach (String a in bm)
            {
                if (a != "")
                {
                    bmn += "1";
                    //ff += a;
                }
                else
                {
                    bmn += "0";
                }

            }
            return (bmn);
        }

        
        public Form2()
        {
            InitializeComponent();
        }

        private void submitbtn2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            msgheadertxt.Text = hG;
            MTItxt.Text = mtiG;
            BMpritxt.Text = pmG;
            BMsectxt.Text = smG;
            PANBox.Text = panG;
            PCtxt.Text = pcG;
            //PCtxt.Text += "          Length:" + pcG.Length;
            amtTrantxt.Text = atG;
            amtSettxt.Text = asG;
            amtbilltxt.Text = acbG;
            tranDTtxt.Text = tdtG;
            amtbillfeetxt.Text = acbfG;
            convrtsettxt.Text = crsG;
            convrtCbilltxt.Text = crcbG;
            sysTaudnotxt.Text = stanG;
            timeLtrantxt.Text = tltG;
            dateLtrantxt.Text = dltG;
            dateExptxt.Text = dexpG;
            dateSettxt.Text = dsetG;
            dateConvtxt.Text = dconG;
            dateCaptxt.Text = dcapG;
            mTypetxt.Text = mtG;
            AICCtxt.Text = aiccG;
            PANcctxt.Text = panccG;
            fwdIcctxt.Text = ficcG;
            pntsvcEMtxt.Text = psemG;
            cardSnotxt.Text = csnG;
            NIItxt.Text = niiG;
            POSccISOtxt.Text = posccG;
            POSpcctxt.Text = pospccG;
            authIdenResLntxt.Text = airl1G;
            amtTranFeetxt.Text = atfG;
            amtSetFeetxt.Text = asfG;
            amtTranPrcsFeetxt.Text = atpfG;
            amtSetPrcsFeetxt.Text = aspfG;
            acqIidenCodetxt.Text = aiicG;
            fwdIidenCodetxt.Text = fiicG;
            PANexttxt.Text = paneG;
            T2Datatxt.Text = t2dG;
            T3Datatxt.Text = t3dG;
            retRefNotxt.Text = rrnG;
            authIrestxt.Text = airG;
            rspnsCodetxt.Text = rcG;
            SRcodetxt.Text = srcG;
            cdAcptTerIdentxt.Text = catiG;
            cdAcptIdenCdtxt.Text = caicG;
            cdAcptNameLoctxt.Text = canlG;
            addResDatatxt.Text = ardG;
            T1datatxt.Text = t1dG;
            addDataISOtxt.Text = adISOG;
            addDataNttxt.Text = adNATIONALG;
            addDatapvttxt.Text = adPVTG;
            currCodeTrantxt.Text = cctG;
            currCodeSettxt.Text = ccsG;
            currCodeCdHldrBilltxt.Text = cccbG;
            PINdatatxt.Text = PINdG;
            SecRlConInfotxt.Text = srciG;
            addAmttxt.Text = aaG;
            ICCsysRelDatatxt.Text = ICCsrdG;
            resISOusetxt.Text = rsvISOG;
            resNational1txt.Text = rsvNATIONAL1G;
            resNational2txt.Text = rsvNATIONAL2G;
            resNational3txt.Text = rsvNATIONAL3G;
            advRsnCodetxt.Text = arcG;
            POSdatatxt.Text = POSdG;
            INFdatatxt.Text = INFdG;
            ntwkDatatxt.Text = ndG;
            MACtxt.Text = MACG;
            BMextdtxt.Text = bmextG;
            setCodetxt.Text = scG;
            extdPayCodetxt.Text = epcG;
            rcvInsCntryCodetxt.Text = riccG;
            setInsCntryCodetxt.Text = siccG;
            NMIcodetxt.Text = nmicG;
            msgNotxt.Text = mnG;
            msgNoLasttxt.Text = mnlG;
            dateActtxt.Text = dateaG;
            crdtNotxt.Text = crdtnoG;
            crdtRevNotxt.Text = crdtraG;
            debtNotxt.Text = debtnoG;
            debtRevAmttxt.Text = debtrnoG;
            transNotxt.Text = tnoG;
            transRevNotxt.Text = trnoG;
            inqNotxt.Text = inoG;
            authNotxt.Text = anoG;
            crdtPrcsFeeAmttxt.Text = cpfaG;
            crdtTransFeeAmttxt.Text = ctfaG;
            debtPrcsFeeAmttxt.Text = dpfaG;
            debtTransFeeAmttxt.Text = dtfaG;
            crdtAmttxt.Text = crdtaG;
            crdtRevAmttxt.Text = crdtraG;
            debtAmttxt.Text = debtaG;
            debtRevAmttxt.Text = debtraG;
            orgnlDataElmnttxt.Text = odeG;
            fileUpdtCodetxt.Text = fucG;
            fileSecCodetxt.Text = fscG;
            rspIndtxt.Text = riG;
            svcIndctxt.Text = siG;
            rplcAmttxt.Text = raG;
            msgSecCodetxt.Text = mscG;
            amtNtSettxt.Text = ansG;
            payee.Text = pG;
            setInstIdenCodetxt.Text = siicG;
            rcvInstIdenCodetxt.Text = riicG;
            fileNametxt.Text = fnG;
            accIden1txt.Text = ai1G;
            accIden2txt.Text = ai2G;
            transDesctxt.Text = tdG;
            rsvISOuse1txt.Text = rsviso1G;
            rsvISOuse2txt.Text = rsviso2G;
            rsvISOuse3txt.Text = rsviso3G;
            rsvISOuse4txt.Text = rsviso4G;
            rsvISOuse5txt.Text = rsviso5G;
            rsvISOuse6txt.Text = rsviso6G;
            rsvISOuse7txt.Text = rsviso7G;
            addDataNusetxt.Text = adddataNatG;
            rsvNuse1txt.Text = rsvN1G;
            rsvNuse2txt.Text = rsvN2G;
            rsvNuse3txt.Text = rsvN3G;
            rsvNuse4txt.Text = rsvN4G;
            rsvNuse5txt.Text = rsvN5G;
            rsvNuse6txt.Text = rsvN6G;
            rsvNuse7txt.Text = rsvN7G;
            rcdDatatxt.Text = rdG;
            authAgntIdenCodetxt.Text = aaicG;
            addRcdDatatxt.Text = rsvfutr1G;
            rsvFutrDefMstr1txt.Text = rsvfutr2G;
            rsvFutrDefMstr2txt.Text = rsvfutr3G;
            rsvFutrDefMstr3txt.Text = rsvfutr4G;
            pvtData1txt.Text = rsvpvtG;
            pvtData2txt.Text = pvtdataG;
            MAC2txt.Text = MAC2G;
 }
        static string bincon(string s)
        {
            string res1 = "";
            for (int k=0;k<64;k+=4)
            {
                String ch = s.Substring(k, 4);
                switch (ch)
                {
                    case "0000":
                        res1 += "0";
                        break;
                    case "0001":
                        res1 += "1";
                        break;
                    case "0010":
                        res1 += "2";
                        break;
                    case "0011":
                        res1 += "3";
                        break;
                    case "0100":
                        res1 += "4";
                        break;
                    case "0101":
                        res1 += "5";
                        break;
                    case "0110":
                        res1 += "6";
                        break;
                    case "0111":
                        res1 += "7";
                        break;
                    case "1000":
                        res1 += "8";
                        break;
                    case "1001":
                        res1 += "9";
                        break;
                    case "1010":
                        res1 += "A";
                        break;
                    case "1011":
                        res1 += "B";
                        break;
                    case "1100":
                        res1 += "C";
                        break;
                    case "1101":
                        res1 += "D";
                        break;
                    case "1110":
                        res1 += "E";
                        break;
                    case "1111":
                        res1 += "F";
                        break;
                }

            }
            return (res1);

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeLtran_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void accIden2_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        public void pantxt1(object sender, EventArgs e)
        {

        }

        private void PC_TextChanged(object sender, EventArgs e)
        {

        }

        private void amtTran_Click(object sender, EventArgs e)
        {

        }

        static public void Initial(string header, string mti, string primary_bmap, string secondary_bmap=null)
        {
            hG = header;
            mtiG = mti;
            pmG = primary_bmap;
            smG = secondary_bmap;
        }
    }
}
