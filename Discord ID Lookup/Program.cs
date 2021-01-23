namespace Discord_ID_Lookup{
    class Program{
        static async System.Threading.Tasks.Task Main(string[] Arguments){
            System.Console.Title = "Slays Discord ID Lookup";
            System.Console.WriteLine("Discord ID look up made by Slays#2786\n");
            var Token = ""; // Make sure to add a token, it can be a bot token or a user token.
            System.Net.Http.HttpClient HttpClient = new System.Net.Http.HttpClient();
            HttpClient.DefaultRequestHeaders.Add("Authorization", Token);
            Re:
            string ID = System.Console.ReadLine();
            System.Net.Http.HttpResponseMessage Check = await HttpClient.GetAsync($"https://discord.com/api/v6/users/{ID}");
            if (Check.IsSuccessStatusCode){
                string User = await HttpClient.GetStringAsync($"https://discord.com/api/v6/users/{ID}");
                dynamic data = Newtonsoft.Json.Linq.JObject.Parse(User); // Newtonsoft is chad ngl
                System.Console.WriteLine($"\n> User: {data.username}#{data.discriminator}\n");
            }else{System.Console.WriteLine($"\n> \"{ID}\" is not a valid User ID, please re-enter a valid ID.\n");}
            goto Re;
        }
    }
}
