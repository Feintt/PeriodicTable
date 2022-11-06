namespace Periodic_Table
{
    class PeriodicTable
    {
        static void Main()
        {
            var elements_data = new Elements();
            string elements_information = elements_data.info;

            // Creamos un arreglo del tamaño de los valores de elements_data
            string[] elements = new string[elements_data.info.Split("\n").Length];

            // Creamos un arreglo de arreglos del mismo tamaño de los valores de elements_data
            string[][] elements_arrays = new string[elements.Length][];

            // Creamos un arreglo bidimensional con la estructura de la tabla periodica
            string[,] periodic_table = new string[7, 18];

            // Creamos un arreglo bidimensional con la estructura de la tabla de los lantanidos y actinidos
            string[,] lan_act_table = new string[2, 17];
            elements = elements_data.info.Split("\n");

            // Guardamos arreglos dentro del arreglo
            for (int i = 0; i < elements_arrays.Length; i++)
            {
                string[] tmp = elements[i].Split(" ");
                elements_arrays[i] = tmp;
            }

            assign_values_to_periodic_table(ref periodic_table, elements_arrays);
            assign_values_to_lan_act_table(ref lan_act_table, elements_arrays);

            string user_input = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Type \"sss\" to leave");
                print_table(periodic_table, lan_act_table, elements_arrays);
                user_input = print_elements_info(elements_arrays);
                if (user_input == "sss")
                {
                    break;
                }
            } while (true);
        }

        static void assign_values_to_lan_act_table(ref string[,] lan_act_table, string[][] jaggedArray)
        {
            int counter = 0;

            lan_act_table[0, 1] = "*   ";
            lan_act_table[1, 1] = "*   ";


            for (int i = 56; i < 71; i++)
            {
                lan_act_table[0, counter + 2] = jaggedArray[i][2];
                if (jaggedArray[i][2].Length == 1)
                {
                    lan_act_table[0, counter + 2] += "   ";
                }
                else
                {
                    lan_act_table[0, counter + 2] += "  ";
                }
                counter++;
            }

            counter = 0;
            for (int i = 88; i < 103; i++)
            {
                lan_act_table[1, counter + 2] = jaggedArray[i][2];
                if (jaggedArray[i][2].Length == 1)
                {
                    lan_act_table[1, counter + 2] += "   ";
                }
                else
                {
                    lan_act_table[1, counter + 2] += "  ";
                }
                counter++;
            }
        }
        static void assign_values_to_periodic_table(ref string[,] two_dimensional_array, string[][] jaggedArray)
        {
            int counter = 0;
            int y_coord = 0;
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 18; y++)
                {
                    for (int element_num = 0; element_num < 118; element_num++)
                    {
                        if (18 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 17 && x == 2 || 17 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 16 && x == 2 || 16 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 15 && x == 2 || 15 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 14 && x == 2 || 14 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 13 && x == 2 || 13 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 12 && x == 2 || 12 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 1 && x == 2 || 11 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 0 && x == 2 || 10 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 17 && x == 1 || 9 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 16 && x == 1 || 8 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 15 && x == 1 || 7 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 14 && x == 1 || 6 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 13 && x == 1 || 5 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 12 && x == 1 || 4 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 1 && x == 1 || 1 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 0 && x == 0 || 2 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 17 && x == 0 || 3 == Convert.ToInt32(jaggedArray[element_num][3]) && y == 0 && x == 1)
                        {
                            two_dimensional_array[x, y] = jaggedArray[element_num][2];
                            if (jaggedArray[element_num][2].Length == 1)
                            {
                                two_dimensional_array[x, y] += "   ";
                            }
                            else
                            {
                                two_dimensional_array[x, y] += "  ";
                            }
                            break;
                        }
                    }
                    if (x == 3 && y == 17 || x == 4 && y == 17)
                    {
                        counter = 18; y_coord = 0; int fina = 0; int counterb = 0;
                        if (x == 4 && y == 17) { counter = 36; fina = 54; counterb = counter; }
                        else { counter = 18; fina = 36; counterb = counter; }
                        do
                        {
                            two_dimensional_array[x, y_coord] = jaggedArray[counter][2];
                            if (jaggedArray[counter][2].Length == 1)
                            {
                                two_dimensional_array[x, y_coord] += "   ";
                            }
                            else
                            {
                                two_dimensional_array[x, y_coord] += "  ";
                            }
                            counter++;
                            y_coord++;
                        } while (counter > counterb && counter < fina);

                    }
                    if (x == 5 && y == 17 || x == 6 && y == 17)
                    {
                        counter = 0; int counterb = 0; int fin = 0;
                        y_coord = 0;
                        if (x == 6 && y == 17) { counterb = 86; fin = 104; counter = 86; }
                        else { counterb = 54; fin = 72; counter = 54; }
                        do
                        {
                            if (counter == counterb + 2)
                            {
                                two_dimensional_array[x, y_coord] = "*";
                                two_dimensional_array[x, y_coord] += "   ";

                            }
                            else if (counter > counterb + 2)
                            {
                                two_dimensional_array[x, y_coord] = jaggedArray[counter + 14][2];

                                if (jaggedArray[counter + 14][2].Length == 1)
                                {
                                    two_dimensional_array[x, y_coord] += "   ";
                                }
                                else
                                {
                                    two_dimensional_array[x, y_coord] += "  ";
                                }
                            }
                            else
                            {
                                two_dimensional_array[x, y_coord] = jaggedArray[counter][2];
                                if (jaggedArray[counter][2].Length == 1)
                                {
                                    two_dimensional_array[x, y_coord] += "   ";
                                }
                                else
                                {
                                    two_dimensional_array[x, y_coord] += "  ";
                                }
                            }

                            counter++;
                            y_coord++;
                        } while (counter > counterb && counter < fin);
                    }
                }
            }
        }
        static void print_table(string[,] table, string[,] lan_act, string[][] data)
        {
            Console.Write(" "); for (int i = 0; i < 9; i++) { Console.Write($"   {i + 1}"); }
            Console.Write(" "); for (int i = 9; i < 18; i++) { Console.Write($"  {i + 1}"); }
            Console.WriteLine("\n");

            int counter = 0;
            for (int x = 0; x < 7; x++)
            {
                Console.Write($"{x + 1}   ");
                for (int y = 0; y < 18; y++)
                {
                    if (table[x, y] == null)
                    {
                        Console.Write("    ");
                    }
                    else
                    {
                        if (data[counter][4] == "blue")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (data[counter][4] == "magenta")
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (data[counter][4] == "red")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (data[counter][4] == "green")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (data[counter][4] == "yellow")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (data[counter][4] == "orange")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (data[counter][4] == "cyan")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else if (data[counter][4] == "dark_green")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        Console.Write(table[x, y]);
                        Console.ForegroundColor = ConsoleColor.White;
                        counter++;

                        if (counter == 56)
                        {
                            counter = 70;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        }
                        if (counter == 88)
                        {
                            counter = 102;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            counter = 56;
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 17; y++)
                {
                    if (lan_act[x, y] == null)
                    {
                        Console.Write("    ");
                    }
                    else
                    {
                        if (data[counter][4] == "other")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        }
                        else if (data[counter][4] == "other1")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                        Console.Write(lan_act[x, y]);
                        counter++;
                    }
                }
                Console.WriteLine();
                counter += 16;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        static string print_elements_info(string[][] data)
        {
            string element;
            int position = 0;
            Console.Write("\n\nType the element symbol: ");
            element = Console.ReadLine()!.ToLower();
            if (element.ToLower() == "sss")
            {
                return element;
            }
            for (int x = 0; x < 118; x++)
            {
                if (element == data[x][2].ToLower())
                {
                    position = x;
                }
            }
            Console.WriteLine($"\nElement name: {data[position][1]}");
            Console.WriteLine($"Atomic number: {data[position][3]}");
            Console.WriteLine($"Atomic mass: {data[position][0]}");
            Console.ReadLine();
            return element;
        }
    }
}
