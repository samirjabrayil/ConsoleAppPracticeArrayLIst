﻿using ConsoleAppPracticeArrayLIst.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPracticeArrayLIst.Utils
{
    internal class FIndHelper
    {
        public static int FindSessionIndex(int id)
        {
            for (int i = 0; i < DataContext.Sessions.Count; i++)
            {
                if (DataContext.Sessions[i].Id == id)
                    return i;
            }

            return -1;
        }

        public static int FindHallIndex(int id)
        {
            for (int i = 0; i < DataContext.Halls.Count; i++)
            {
                if (DataContext.Halls[i].Id == id)
                    return i;
            }

            return -1;
        }

        public static int FindCinemaIndex(int id)
        {
            for (int i = 0; i < DataContext.Cinemas.Count; i++)
            {
                if (DataContext.Cinemas[i].Id == id)
                    return i;
            }

            return -1;
        }

        public static int FindFilmIndex(int id)
        {
            for (int i = 0; i < DataContext.Films.Count; i++)
            {
                if (DataContext.Films[i].Id == id)
                    return i;
            }

            return -1;
        }
    }
}
