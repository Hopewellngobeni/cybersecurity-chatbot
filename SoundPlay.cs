namespace SoundPlayer
{
    using System.Media;
    using System;
    using System.IO;

    public class SoundPlay
    {

        //constructer
        public SoundPlay()
        {
            //project location
            string project_Location = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(project_Location);

            // replacing the bin\debug so it gets audio
             string updated_path = project_Location.Replace("bin\\Debug\\", "");

            //combinig the wav name as voice 001.wav with updated path
            string full_path = Path.Combine(updated_path, "Voice 001.wav");

           // passing it to the method play wav
           Play_wav(full_path);
          


        }//end of constructer




        //method to play the sound 

        private void Play_wav(string full_path)
        {
            //try and catch method in order for the code to not crash whenever there was an error

            try
            {
                // play sound 
                using (SoundPlayer play = new SoundPlayer(full_path))
                {
                    // play sound till end
                    play.PlaySync();
                    


                }//end of using
                    
            

            }catch(Exception error)

            {
                      // show error messsage
                  Console.WriteLine(error.Message);

            }//end of try and catch
        }

    }//end of the class soundplay

}//end of namespace