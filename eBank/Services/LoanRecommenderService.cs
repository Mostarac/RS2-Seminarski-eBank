using AutoMapper;
using eBank.Model.Requests;
using eBank.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.WebAPI.Services
{
    //Not yet implemented!
    public class LoanRecommenderService
    {
        private readonly eBankContext _context;
        private readonly IMapper _mapper;
        //Dictionary<int, List<Score>> loanRecommendations = new Dictionary<int, List<Score>>();

        public LoanRecommenderService(eBankContext context, IMapper mapper)
        { 
            _context = context;
            _mapper = mapper;
        }

        public Model.LoanRecommendation Get(LoanRecommendationRequest search)
        {

            //var list = _context.Account.Include(x => x.AccountNumber).Include(x => x.Currency).Include(x => x.AccountType).Include(x => x.User).Where(x => x.User.UserId == search.UserId).ToList();

            //return _mapper.Map<List<Model.Account>>(list);



            return new Model.LoanRecommendation();
        }

        /*public List<Proizvodi_Result> GetSlicneProizvode(int proizvodID)
        {

            LoadLoans(proizvodID);
            List<Ocjene> ocjenePosmatranogProizvoda = _context.Ocjene.Where(x => x.ProizvodID == proizvodID).OrderBy(x => x.KupacID).ToList();

            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();

            List<Proizvodi_Result> preporuceniProizvodi = new List<Proizvodi_Result>();

            foreach (var item in proizvodi)
            {
                foreach (Ocjene o in ocjenePosmatranogProizvoda)
                {
                    if (item.Value.Where(x=>x.KupacID == o.KupacID).Count()>0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KupacID == o.KupacID).First());
                    }
                }

                double slicnost = GetSimilarity(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > 0.5)
                    preporuceniProizvodi.Add(_context.Proizvod.Single(x => x.ProizvodID == item.Key).FirstOrDefault());

                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();

            }

        }

        private double GetSimilarity(List<Score> commonScores1, List<Score> commonScores2)
        {

            if(commonScores1.Count != commonScores2.Count)
                return 0;


            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < commonScores1.Count; i++)
            {
                brojnik = commonScores1[i].CalculatedScore * commonScores2[i].CalculatedScore;
                nazivnik1 = commonScores1[i].CalculatedScore * commonScores1[i].CalculatedScore;
                nazivnik2 = commonScores2[i].CalculatedScore * commonScores2[i].CalculatedScore;
            }

            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;

            return brojnik / nazivnik;

        }

        private void LoadLoans(int loanId)
        {
            List<Proizvod> aktivniProizvodi = _context.Proizvodi.Where(x => x.ProizvodID != loanId).ToList;
            List<Ocjene> ocjene;
            foreach(Proizvodi p in aktivniProizvodi)
            {
                ocjene = DbContext.Ocjene.Where(x => x.ProizvodID == p.ProizvodID).OrderBy(x => x.KupacID).ToList();
                if(ocjene.Count>0)
                {
                    aktivniProizvodi.Add(p.ProizvodID, ocjene);
                }
            }
        }

        private class Score
        {
            public int CalculatedScore { get; set; }
        }*/

    }
}
