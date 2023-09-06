using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4_Monteagudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1]: Reading Zodiac Signs Daily!");
            Console.WriteLine("[2]: The Wave Quiz!");
            Console.WriteLine();

            Console.Write("What would you like to do?: ");
            int choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("  Welcome to Reading Zodiac Signs Daily!");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine();

                Console.WriteLine("[1]: Aries - March 21 to April 20.");
                Console.WriteLine("[2]: Taurus - April 21 to May 20.");
                Console.WriteLine("[3]: Gemini - May 21 to June 20.");
                Console.WriteLine("[4]: Cancer - June 21 to July 22.");
                Console.WriteLine("[5] Leo - July 23 to August 22.");
                Console.WriteLine("[6]: Virgo - August 23 to  September 22.");
                Console.WriteLine("[7]: Libra - September 23 to October 22.");
                Console.WriteLine("[8]: Scorpio - October 23 to November 22.");
                Console.WriteLine("[9]: Sagittarius - November 23 to December 21.");
                Console.WriteLine("[10]: Capricorn - December 22 to January 19.");
                Console.WriteLine("[11]: Aquarius - January 20 to February 19.");
                Console.WriteLine("[12: Pisces - February 20 to March 20.");

                Console.WriteLine();

                Console.Write("Enter your Zodiac Sign according to the given sequence: ");
                int zSign = Int32.Parse(Console.ReadLine());

                Console.WriteLine();

                if (zSign == 1)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("  YOU ARE AN ARIES!!");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Aries' Sign Fact/s:");
                    Console.WriteLine("   Problem Solver, Leader, Strong-minded, Focused, Sarcastic, Savage,");
                    Console.WriteLine("   Romantic, Loyal, Truthful, Observer, Kind-hearted, and Dangerous when provoked.");
                    Console.WriteLine("   MAHAL NA MAHAL KO TO SOBRANG GREENFLAG :(( LABYU ISAY PAKISS AKO MAMAYA.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   Financially you are good and no medical issue will trouble you!");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Red.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   6, 8, and 9.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Sagittarius - Good");
                    Console.WriteLine("   Leo - Good");
                    Console.WriteLine();
                }

                else if (zSign == 2)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("  YOU ARE A TAURUS!!");
                    Console.WriteLine("----------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Taurus' Sign Fact/s:");
                    Console.WriteLine("   Like their celestial spirit animal, Taureans enjoy relaxing in serene,");
                    Console.WriteLine("   bucolic environments, surrounded by soft sounds, soothing aromas, and");
                    Console.WriteLine("   succulent flavors.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   Resolve every issue in the love life to be happy!");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Green.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   1 and 9.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Taurus - Good");
                    Console.WriteLine("   Virgo - Good");
                    Console.WriteLine("   Capricorn - Good");
                    Console.WriteLine("   Cancer - Neutral");
                    Console.WriteLine("   Scorpio - Neutral");
                    Console.WriteLine();
                }

                else if (zSign == 3)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("  YOU ARE A GEMINI!!");
                    Console.WriteLine("----------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Gemini's Sign Fact/s:");
                    Console.WriteLine("   Geminis are known to be one of the most intriguing sun signs.");
                    Console.WriteLine("   They are funny, quirky, kind, genuine, smart and very interesting personalities");
                    Console.WriteLine("   that you'll come across. Tas medyo redflag yuck.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   New love will enter your life today!");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Yellow.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   3 and 5.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Leo - Good");
                    Console.WriteLine("   Aquarius - Good");
                    Console.WriteLine("   Libra - Neutral");
                    Console.WriteLine();
                }

                else if (zSign == 4)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("  YOU ARE A CANCER!!");
                    Console.WriteLine("----------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Cancers's Sign Fact/s:");
                    Console.WriteLine("   Generous, loyal, and empathetic.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   Be content in the love relationship!");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   White, Cream, Red, and Yellow.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   2, 7, and 9.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Pisces - Good");
                    Console.WriteLine("   Scorpio - Good");
                    Console.WriteLine();
                }

                else if (zSign == 5)
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("  YOU ARE A LEO!!");
                    Console.WriteLine("-------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Leo's Sign Fact/s:");
                    Console.WriteLine("   Vivacious, theatrical, and passionate.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   Expect minor health issues today.");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Gold Red, and all colors of the Sun.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   1, 4, and 9.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Pisces - Good");
                    Console.WriteLine("   Scorpio - Good");
                    Console.WriteLine();
                }

                else if (zSign == 6)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("  YOU ARE A VIRGO!!");
                    Console.WriteLine("---------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Virgo's Sign Fact/s:");
                    Console.WriteLine("   Kind, honest, analytical, smart, hardworking, determined, stubborn");
                    Console.WriteLine("   crazy, cool, calm, collected, visionary, intellectually enquiring,");
                    Console.WriteLine("   methodical and logical, studious.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   Troubleshoot every romantic issue to stay happy today.");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Green.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   3, 6, and 7.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Taurus - Good");
                    Console.WriteLine("   Capricorn - Good");
                    Console.WriteLine("   Virgo - Good");
                    Console.WriteLine();
                }

                else if (zSign == 7)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("  YOU ARE A LIBRA!!");
                    Console.WriteLine("---------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Libra's Sign Fact/s:");
                    Console.WriteLine("   Libra is obsessed with symmetry and strives to create equilibrium in all areas of life.");
                    Console.WriteLine("   Tas medyo redflag din.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   The love life will be fabulous today!");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Blue, and All Shades of Gray and Light Olive.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   6, 8, and 10.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Gemini - Good");
                    Console.WriteLine("   Aquarius - Good");
                    Console.WriteLine("   Leo - Good");
                    Console.WriteLine();
                }

                else if (zSign == 8)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("  YOU ARE A SCORPIO!!");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Scorpio's Sign Fact/s:");
                    Console.WriteLine("   Clever, rebellious, stubborn, witty, sarcasm, independence, spontaneous, visionary, intellect, adventurous.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   Resolve issues within the love life with care!");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Deep red, Black, and Dark Shades of Purple.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   1, 2, 4, 9, 7, 18, and 27.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Cancer - Good");
                    Console.WriteLine("   Pisces - Good");
                    Console.WriteLine("   Scorpio - Neutral");
                    Console.WriteLine();
                }

                else if (zSign == 9)
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("  YOU ARE A SAGITTARIUS!!");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Sagittarius' Sign Fact/s:");
                    Console.WriteLine("   Emotional Intelligence.");
                    Console.WriteLine("   SOBRANG GREENFLAG LEGIT.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   Explore the different aspects of love today!");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Purple, Royal Blue, and Vibrant Shades of Yellow.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   1, 2, 9, 11, and 27.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Aries - Good");
                    Console.WriteLine("   Leo - Good");
                    Console.WriteLine();
                }

                else if (zSign == 10)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("  YOU ARE A CAPRICORN!!");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Capricorn's Sign Fact/s:");
                    Console.WriteLine("   Extremely hardworking Visionaries, Leaders, and Trailblazers.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   Your health will also be good today!");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Black, Green, and Blue.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   6, 8, and 9");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Capricorn - Good");
                    Console.WriteLine("   Virgo - Good");
                    Console.WriteLine("   Tauris - Neutral");
                    Console.WriteLine();
                }

                else if (zSign == 11)
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("  YOU ARE A AQUARIUS!!");
                    Console.WriteLine("------------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Aquarius' Sign Fact/s:");
                    Console.WriteLine("   Highly Intellectual and Creative.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   Today, the romantic life will be fabulous!");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Blue and Silver.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   2, 3, and 9.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Aquarius - Good");
                    Console.WriteLine("   Libra - Good");
                    Console.WriteLine("   Gemini - Neutral");
                    Console.WriteLine();
                }

                else if (zSign == 12)
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("  YOU ARE A PISCES!!");
                    Console.WriteLine("------------------------");
                    Console.WriteLine();

                    Console.WriteLine("1. Pisces' Sign Fact/s:");
                    Console.WriteLine("   Supportive, imaginative and mysterious.");
                    Console.WriteLine();

                    Console.WriteLine("2. Horoscope For The Day:");
                    Console.WriteLine("   Be gentle in your office and personal life.");
                    Console.WriteLine();

                    Console.WriteLine("3. Lucky Color/s:");
                    Console.WriteLine("   Lavender and Green.");
                    Console.WriteLine();

                    Console.WriteLine("4. Lucky Number/s:");
                    Console.WriteLine("   7 and 21.");
                    Console.WriteLine();

                    Console.WriteLine("5. Zodiac Sign/s That You Are MOST Compatible With:");
                    Console.WriteLine("   Pisces - Good");
                    Console.WriteLine("   Cancer - Good");
                    Console.WriteLine("   Scorpio - Neutral");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("Invalid Zodiac Sign Input");
                }

            }

            else if (choice == 2)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("  Welcome to The Wave Quiz!!");
                Console.WriteLine("------------------------------");

                Console.WriteLine();

                Console.Write("Enter your name: ");
                string uName = string.Copy(Console.ReadLine());
                Console.WriteLine();

                // Quiz About The Teacher
                int score = 0;

                Console.WriteLine("First Question: What is my full name?");
                Console.WriteLine();

                Console.WriteLine("[1]: Kim Anthony Torres Monteagudo");
                Console.WriteLine("[2]: Kym Anthony Torres Monteagudo");
                Console.WriteLine("[3]: Kei Anthony Torres Monteagudo");
                Console.WriteLine("[4]: Kimpoy Anthony Torres Monteagudo");
                Console.Write("Your Answer: ");
                int fQ = Int32.Parse(Console.ReadLine());

                if (fQ == 1)
                {
                    score++;
                }

                else
                {

                }

                Console.WriteLine();

                Console.WriteLine("Second Question: What is my age?");
                Console.WriteLine();

                Console.WriteLine("[1]: 16");
                Console.WriteLine("[2]: 17");
                Console.WriteLine("[3]: 18");
                Console.WriteLine("[4]: 19");
                Console.Write("Your Answer: ");
                int sQ = Int32.Parse(Console.ReadLine());

                if (sQ == 2)
                {
                    score++;
                }

                else
                {

                }

                Console.WriteLine();

                Console.WriteLine("Third Question: What is my zodiac sign?");
                Console.WriteLine();

                Console.WriteLine("[1]: Libra");
                Console.WriteLine("[2]: Capricorn");
                Console.WriteLine("[3]: Sagittarius");
                Console.WriteLine("[4]: Cancer");
                Console.Write("Your Answer: ");
                int tQ = Int32.Parse(Console.ReadLine());

                if (tQ == 3)
                {
                    score++;
                }

                else
                {

                }

                Console.WriteLine();

                Console.WriteLine("Fourth Question: What is my religion?");
                Console.WriteLine();

                Console.WriteLine("[1]: Tau Gamma");
                Console.WriteLine("[2]: Paro-paro G");
                Console.WriteLine("[3]: Shinto");
                Console.WriteLine("[4]: Roman Catholic");
                Console.Write("Your Answer: ");
                int frQ = Int32.Parse(Console.ReadLine());

                if (frQ == 4)
                {
                    score++;
                }

                else
                {

                }

                Console.WriteLine();


                Console.WriteLine("Fifth Question: Which university do I go to?");
                Console.WriteLine();

                Console.WriteLine("[1]: Adamson University");
                Console.WriteLine("[2]: University of The Philippines");
                Console.WriteLine("[3]: Far Eastern University");
                Console.WriteLine("[4]: Pamangtasan ng Lungsod ng Maynila");
                Console.Write("Your Answer: ");
                int ftQ = Int32.Parse(Console.ReadLine());

                if (ftQ == 1)
                {
                    score++;
                }

                else
                {

                }

                Console.WriteLine();

                Console.Write("Do you want to see your score? [1]: Yes or [2]: No: ");
                int fScore = Int32.Parse(Console.ReadLine());
                Console.WriteLine(  );

                if (fScore == 1)
                {
                    Console.WriteLine("Congratulations " + uName + "! Your score is: " + score + "/5.");
                }

                else if (fScore == 2)
                {
                    Console.WriteLine("Thank you!");
                }

                else
                {

                }
            }

            Console.ReadKey();
        }
    }
}
