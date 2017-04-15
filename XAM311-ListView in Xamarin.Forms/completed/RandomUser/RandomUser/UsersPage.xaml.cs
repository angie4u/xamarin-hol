using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RandomUser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsersPage : ContentPage
    {
        public UsersPage()
        {
            InitializeComponent();

            //randomuser 페이지에서 JSON형식의 데이터를 받아와서, Listview에 매핑하는 메소드 
            GetUserInfo();
        }

        async void GetUserInfo()
        {
            //파싱할 데이터를 담을 변수들 
            var people = new List<Person>();
            string phoneNumber;
            string imageUrl;
            string name;

            //JSON URL 요청 
            string url = "https://randomuser.me/api/?page=3&results=10&seed=eunk";

            //HttpClient 객체 생성
            HttpClient client = new HttpClient();

            //url로 요청 후 response에 결과값 담음
            var response = await client.GetAsync(url);

            //결과값이 성공적이면 
           
            if (response.IsSuccessStatusCode)
            {
                //결과 값을 String으로 변환한 후
                var content = await response.Content.ReadAsStringAsync();

                //NewtonSoft.Json 패키지를 이용하여 데이터 파싱 시작
                var data = JObject.Parse(content);

                for (int i = 0; i < 10; i++)
                {
                    //JSON 데이터 중 phone, thumbnail, first 만 담아서 리스트에 추가 
                    phoneNumber = (string)data["results"][i]["phone"];
                    imageUrl = (string)data["results"][i]["picture"]["thumbnail"];
                    name = (string)data["results"][i]["name"]["first"];
                    people.Add(new Person(name, imageUrl, phoneNumber));
                }

                //리스트뷰에 매핑 
                listView.ItemsSource = people;

            }

            
            

            
        }
    }
}
