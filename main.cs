using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
    WriteLine("Input the number of chicken nuggets your heart desires: ");
    var input = ReadLine();
    int input_int = Convert.ToInt32(input);
    calculation(input_int);
  }
  public static void calculation(int num_of_nuggets){
    int processing = 0;
    int num_of_twenties = 0;
    int num_of_nines = 0;
    int num_of_sixs = 0;
    int num_of_fours = 0;
    int remainder = 0;
    bool flag = false;
    while(flag == false){
      num_of_twenties = (num_of_nuggets/20);
      processing += (num_of_twenties * 20);
      remainder = num_of_nuggets - processing;
      num_of_nines = remainder/9;
      if (num_of_nuggets % 2 != 0){
        if (remainder != 22){
          num_of_nines = 1;
          processing += num_of_nines*9;
        }
        else if (remainder != 24){
          num_of_nines = 1;
          processing += num_of_nines*9;
        }
        else if (remainder != 48){
          num_of_nines = 1;
          processing += num_of_nines*9;
        }
      }
      remainder = num_of_nuggets - processing;
      num_of_sixs = remainder/6;
      processing += num_of_sixs*6;
      remainder = num_of_nuggets - processing;
      num_of_fours = remainder/4;
      processing += num_of_fours*4;
      if (processing == num_of_nuggets){
        flag = true;
      }
      break;
    }
    if (flag == true){
      WriteLine("yes");
      WriteLine("Number of 20's = {0}", num_of_twenties);
      WriteLine("Number of 9's = {0}", num_of_nines);
      WriteLine("Number of 6's = {0}", num_of_sixs);
      WriteLine("Number of 4's = {0}", num_of_fours);
    }
    else if (flag == false){
      WriteLine("no");
    }
  }
}