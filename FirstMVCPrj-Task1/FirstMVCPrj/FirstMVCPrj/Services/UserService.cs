using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCPrj.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<Users> GetAll();
        //User GetByName(string Username);
    }
    public class UserService : IUserService
    {
        private List<Users> _users = new List<Users>
        {
            new Users { Username = "Arun", Password = "password" },
            new Users {  Username= "Srihaan", Password = "password" },
            new Users { Username = "Kumar", Password = "password" },
            new Users { Username = "Ezhil", Password = "password" }
       };



        private readonly AppSettings _appSettings;



        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }



        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);



            // return null if user not found
            if (user == null) return null;



            // authentication successful so generate jwt token
            var token = generateJwtToken(user);



            return new AuthenticateResponse(user, token);
        }



        public IEnumerable<Users> GetAll()
        {
            return _users;
        }



        private string generateJwtToken(Users user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("This is my first Security key and hope this is enough to create jwt token");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("name", user.Username.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }