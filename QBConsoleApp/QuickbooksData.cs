using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QBConsoleApp
{
    class QuickbooksData
    {

        //private const string baseurl = "sandbox-quickbooks.api.intuit.com";
        //private const long companyid = 4620816365005934290;
        //private const int minorversion = 14;
        //private const string AccessToken = "eyJlbmMiOiJBMTI4Q0JDLUhTMjU2IiwiYWxnIjoiZGlyIn0..0Bdd_UmHs--5xb1fXErGIQ.4l43b6l_fzSAqiSRxnC_MPnRaDpdv4BlbBcdu-ic9nTdeph6iI1DL-wynVVB8VEdR8Z02dHxncPLPqUTJjsEBrOiheGeKZJdulFKZv8PQzBOFcjFX7DozW8D4WR2maiTL0gw9j-U7IR-KVQfgu9M6xiCu1gZcU8nxxMdn3nd40jndwbfh32GpATAWMAEnH-I4HfrQaJrnSvS25Sh46YUP3w46HgyObY9QsUA447BkTUXT1zak5Ac0cODnfk22f3YYd5b06Ox5mVlZnDxvcjhEebvj6HLBOtR5k2_UzuRAXSbaG8oLwv9K_C3necUw0i-H3SDdHH7IuqSqcFgqpok1sh4hGCCQ54jIZXO-veBSEHaY_r3SPs9qThFNQEIQuOAiWoLrTiNfC6Vm1VZYoXVuCdEv3zNPSyE7Fotj2ciOuiCndPCXN0SMb1b062rHVnZJ764AloaOkb3WhQ2igubZPkhArlripnOuLRfnYFVXIVcKLMLT1yl5RC5ArFs-8txLokQwBPELyhO632bLJzWdVp4Z_PxbxU-Ez_JZMBOthLz213MSuakHQ_eUdyezFi0cM02C5vbcrWU96_3T6yIM3w5QbVHEQqWL_lGBjOw4PbNM2JAq90Saok6GMQr_Q9QnTLGHo7-0yXYj5n8k0y9r9UPp1eY7z4re-Uu5J2ZiOu478mAfRlrMH2PvqUsuflxdv7P4ZRCCToFm6D9kWw0gANSh8UsDjdha3lA8BGghzotZph3GLnFPLL2GH-EhTSjULsnhVzG4VUg6dcAeI0qkl0n4porP1lUUZZium2Q0z7xcfoeU6BFNgOJHeCIY-WeAv76kHfxvNCJ7fz35ErtyH2Uj-aK9bQCou0HWPQqEj2pfwwIN7mfLz44bRTuqNwn.qmQNPpPHp2UGIj8ErvtY0g";


        public void Data()
        {
            //Console.WriteLine("This is C#");
            var client = new RestClient("https://sandbox-quickbooks.api.intuit.com/v3/company/4620816365005934290/companyinfo/4620816365005934290");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Cookie", "ac_s_v8.5_appcenter=j5soztbiaphjsdsjdaknon0q; UserLocale=en-US; s_fid=2F2CF19C91BBE824-22A98F15C841B808; s_cc=true; ius_session=6BD204C287F9496C844C2AAC0C9BFB01; ivid_b=b3fa3b96-470c-41f4-9525-567a5672d9c0; ivid=55606d9a-c131-4fdf-b864-321be927cb14; did=SHOPPER2_ffb7aedf256338d252fbbf24bf891b704e3e37fe5d25380e1e2896c9cdabb948a02a6647c56b920eb114c44a82a4c0b7; ivid_synced=true; qbn.authid=1309731865; qbn.gauthid=1309731865; qbn.agentid=1309731865; qbn.uidp=1f5cd34df6b60461fb4e61fe9fbc818de; qbn.parentid=50000003; userIdentifier=1309731865; qbn.ticket=V1-235-X0kzr04vk9zb2bvpg9at7o; qbn.tkt=V1-235-X0kzr04vk9zb2bvpg9at7o; ADRUM=s=1564755608761&r=https%3A%2F%2Faccounts.intuit.com%2Findex.html%3F1413881890; propertySegments=1564758923993%7cAC%3a5%3a%3a; AppCenter_Ticket=6_bptkzvctt_b8huc5_brx6ed_d9iq979uukm2sdgvgbrvbx6h5vb_ismv7w46hw2xfxvgs7mx4m2wp4qqs765bjrbda73j68dhneec2xb_bptjqnzbt; s_sq=%5B%5BB%5D%5D; qboeuid=16d55ec3.590fe90fbb474");
            request.AddHeader("Host", "sandbox-quickbooks.api.intuit.com");
            request.AddHeader("Postman-Token", "d2587da2-e342-4a04-80a1-930ca2f25245,eed8570c-898c-4565-8bc9-9f2a19a02e7b");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("User-Agent", "PostmanRuntime/7.15.2");
            request.AddHeader("Authorization", "Bearer eyJlbmMiOiJBMTI4Q0JDLUhTMjU2IiwiYWxnIjoiZGlyIn0..R3iuKaEHP_mH9wY4ksOcMQ.D_VhzIV_qGWRS575kHwS9qXf24DqVJDmdpnRzrQldkqsZUggJQEY7ax7z1IHzFrviybH9WrmsUCU4x6dRmNisqMqcNNq2yxEHn34o-rLZNERmUpWfmrUxERtzTwwxtKix8FI8ECR3tMZVuotyzRho6YWNY7ZS_EvvKpZAe-mETX1Gz9mqluCbpExDdZbxHIy1549yiGk2wdvN4pNmcpeFVosfehd-7-uti21DKDV7KEh9gC_6KhjcdICoazLIl-j9oY-_jax6zBq-ogR8hKQehY3D2wtKkMHxxPR4-IOmZV7jSI8GPbHn2o-tT7NitpDLadMyi1dX2dOPXkETJg_fbzvww2NzIa_fl7t0h-qWk_p58UoNZJlf51Fo4g9quR3W2pKIgEmhdLhOWSasklwsFAGPfKPdZW1rg0t_BMgTLfbHvxyl3SzxX_zWcAguqOGcREocOy2cha87KktaU-LfbaXKm9mP-LxgGR18RlRA9DNn3bgFjcq731UWiU1iOWTCpI0_XHBUmtP1o_2oC5KhXhM_zbr4anFGPPLSXOz0akNgF-mtAYAXHYL-RQHJKHtHRp3wke6tikXdN7biksGkw6CJiKrwuPOE1e3LrPaNMBrrbp97NZtYXM7biVsT3ONRIfBjD_vU4MQBr5o4pKiRW658Til1IE06W1kOt6tIC7awuVae6_SZ_p5XsQYC3zczGo3hCYtlss4o8ggJQJBwo3fU5F0F9I2_Bndi2PwBWRyE5dKVpKj4DWCjr3WDyR9Jfm7VZPvYnL3gj03WAB6Q4RzPWBXxY783vqSDkrLbRvlHgFkvfGLIqvGGMMleG12s-WEBPsaegsauH_RVqJPyu8_n-AhYwS3aZXbW3FIh0pPGKcN5GFAZEf415Td7pBs.9j0gTsqHOP1uXdBxxefI-Q");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

         
        }
       
    }
}
