﻿using ConsoleAppPracticeArrayLIst.Data;
using ConsoleAppPracticeArrayLIst.Models;
using ConsoleAppPracticeArrayLIst.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPracticeArrayLIst.Services
{
    internal class CinemaManager : ICrudService<Cinema>, IPrintService
    {
        public void Add(Cinema cinema)
        {
            DataContext.Cinemas.Add(cinema);
        }

        public void Delete(int id)
        {
            int index = FindHelper.FindCinemaIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Not found");

                return;
            }

            DataContext.Cinemas.RemoveAt(index);
            Console.WriteLine("Deleted");
        }

        public Cinema Get(int id)
        {
            int index = FindHelper.FindCinemaIndex(id);

            if (index == -1)
            {
                return null;
            }

            return DataContext.Cinemas[index];
        }

        public List<Cinema> GetAll()
        {
            return DataContext.Cinemas;
        }

        public void Print()
        {
            foreach (var item in DataContext.Cinemas)
            {
                Console.WriteLine(item);
                Console.WriteLine("-".PadRight(20, '-'));
            }
        }

        public void Update(int id, Cinema newCinema)
        {
            int index = FindHelper.FindCinemaIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Not found");

                return;
            }

            DataContext.Cinemas[index] = newCinema;
        }
    }
}
