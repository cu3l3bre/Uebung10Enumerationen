/*
 * Aufgabe: Deklarieren Sie einen Aufzählungstyp 'Monat', der alle Monate
 *          des Jahres in aufsteigender Reihenfolge auflistet, sowie eine
 *          Enumeration 'Jahreszeit', welche die Namen der vier Jahreszeiten
 *          enthält. Implementieren Sie dazu eine IO-Schnittstelle, bei der ein
 *          Benutzer bei Eingabe eines Jahreszeitenindixes und eines 
 *          Monatsindexes bei Entsprechung die zugehörigen Namen ausgegeben 
 *          bekommt und bei Nichtentsprechung darüber informiert wird.
 */


using System;


namespace Uebung10Enumerationen
{
    class Program
    {

        enum Monat
        {
            januar = 1,     // winter
            februar,        // winter
            maerz,          // fruehling
            april,          // fruehling
            mai,            // fruehling
            juni,           // sommer
            juli,           // sommer
            august,         // sommer
            september,      // herbst
            oktober,        // herbst
            november,       // herbst
            dezember        // winter

        };

        enum Jahreszeit
        {
            fruehling = 1,  // 1,2,12
            sommer,         // 3,4,5
            herbst,         // 6,7,8
            winter          // 9,10,11
        };


        static void Main(string[] args)
        {

            String eingabe = "";
            bool eingabeOK = false;
            int jzindex = 0;
            int mindex = 0;
            Jahreszeit j = Jahreszeit.fruehling;
            Monat m = Monat.februar;

            Console.WriteLine("Bitte gib einen Jahreszeitenindex (1-4) und einen Monatsindex an (1-12):");
            

            while(!eingabeOK)
            {
                Console.Write("Zunaechst den Jahreszeitenindex: ");
                eingabe = Console.ReadLine();
                eingabeOK = int.TryParse(eingabe, out jzindex);
                j = (Jahreszeit)jzindex;
                
                if((jzindex < (int)Jahreszeit.fruehling) || (jzindex > (int)Jahreszeit.winter))
                {
                    Console.WriteLine("Index ausserhalb des Bereichs (1-4)");
                    eingabeOK = false;
                }
            }

         
            eingabeOK = false;
            while (!eingabeOK)
            {
                Console.Write("Nun den Monatsindex: ");
                eingabe = Console.ReadLine();
                eingabeOK = int.TryParse(eingabe, out mindex);
                m = (Monat)mindex;

                if ((mindex < (int)Monat.januar) || (mindex > (int)Monat.dezember))
                {
                    Console.WriteLine("Index ausserhalb des Bereichs (1-12)");
                    eingabeOK = false;
                }
            }


            switch (j)
            {
                case Jahreszeit.fruehling:
                    {
                        Console.Write(Jahreszeit.fruehling + " ist im Monat ");
                        switch(m)
                        {
                            case Monat.maerz:
                                {
                                    Console.Write(Monat.maerz +"\n");
                                    break;
                                }

                            case Monat.april:
                                {
                                    Console.Write(Monat.april + "\n");
                                    break;
                                }

                            case Monat.mai:
                                {
                                    Console.Write(Monat.mai + "\n");
                                    break;
                                }

                            default:
                                Console.Write("Nichts da\n");
                                break;
                        }

                        break;
                    }

                case Jahreszeit.sommer:
                    {
                        Console.Write(Jahreszeit.sommer + " ist im Monat ");
                        switch (m)
                        {
                            case Monat.juni:
                                {
                                    Console.Write(Monat.juni + "\n");
                                    break;
                                }

                            case Monat.juli:
                                {
                                    Console.Write(Monat.juli + "\n");
                                    break;
                                }

                            case Monat.august:
                                {
                                    Console.Write(Monat.august + "\n");
                                    break;
                                }

                            default:
                                Console.Write("Nichts da\n");
                                break;
                        }

                        break;
                    }

                case Jahreszeit.herbst:
                    {

                        Console.Write(Jahreszeit.herbst + " ist im Monat ");
                        switch (m)
                        {
                            case Monat.september:
                                {
                                    Console.Write(Monat.september + "\n");
                                    break;
                                }

                            case Monat.oktober:
                                {
                                    Console.Write(Monat.oktober + "\n");
                                    break;
                                }

                            case Monat.november:
                                {
                                    Console.Write(Monat.november + "\n");
                                    break;
                                }

                            default:
                                Console.Write("Nichts da\n");
                                break;
                        }

                        break;
                    }

                case Jahreszeit.winter:
                    {
                        Console.Write(Jahreszeit.winter + " ist im Monat ");
                        switch (m)
                        {
                            case Monat.dezember:
                                {
                                    Console.Write(Monat.dezember + "\n");
                                    break;
                                }

                            case Monat.januar:
                                {
                                    Console.Write(Monat.januar + "\n");
                                    break;
                                }

                            case Monat.februar:
                                {
                                    Console.Write(Monat.februar + "\n");
                                    break;
                                }

                            default:
                                Console.Write("Nichts da\n");
                                break;
                        }

                        break;
                    }


                default:
                    break;

            }

            Console.ReadKey();
        }
    }
}
