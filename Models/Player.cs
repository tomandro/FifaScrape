using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using FifaScrape.DataHolders;

namespace FifaScrape.Models
{
    class Player : IComparable<Player>
    {

        String commonName;
        League league;
        Nation nation;
        Club club;
        String position;
        int composure;
        String playStyle;
        int height;
        int weight;
        String birthdate;
        int age;

        int acceleration;
        int aggression;
        int agility;
        int balance;
        int ballcontrol;
        String foot;
        int skillMoves;
        int crossing;
        int dribbling;
        int finishing;
        int freekickaccuracy;
        int gkdiving;
        int gkposition;
        int gkreflexes;
        int headingaccuracy;
        int interceptions;
        int jumping;
        int longpassing;
        int longshots;
        int marking;
        int penalties;
        int positioning;
        int potential;
        int reactions;
        int shortpassing;
        int shotpower;
        int slidingtackle;
        int sprintspeed;
        int standingtackle;
        int stamina;
        int strength;
        int vision;
        int volleys;
        int weakFoot;

        int rarityID;
        String quality;
        int id;
        int baseId;
        int rating;
        JObject jsonRep;

        public string CommonName
        {
            get
            {
                return commonName;
            }

            set
            {
                commonName = value;
            }
        }

        internal League League
        {
            get
            {
                return league;
            }

            set
            {
                league = value;
            }
        }

        internal Nation Nation
        {
            get
            {
                return nation;
            }

            set
            {
                nation = value;
            }
        }

        internal Club Club
        {
            get
            {
                return club;
            }

            set
            {
                club = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public int Composure
        {
            get
            {
                return composure;
            }

            set
            {
                composure = value;
            }
        }

        public string PlayStyle
        {
            get
            {
                return playStyle;
            }

            set
            {
                playStyle = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public string Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                birthdate = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public int Acceleration
        {
            get
            {
                return acceleration;
            }

            set
            {
                acceleration = value;
            }
        }

        public int Aggression
        {
            get
            {
                return aggression;
            }

            set
            {
                aggression = value;
            }
        }

        public int Agility
        {
            get
            {
                return agility;
            }

            set
            {
                agility = value;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public int Ballcontrol
        {
            get
            {
                return ballcontrol;
            }

            set
            {
                ballcontrol = value;
            }
        }

        public string Foot
        {
            get
            {
                return foot;
            }

            set
            {
                foot = value;
            }
        }

        public int SkillMoves
        {
            get
            {
                return skillMoves;
            }

            set
            {
                skillMoves = value;
            }
        }

        public int Crossing
        {
            get
            {
                return crossing;
            }

            set
            {
                crossing = value;
            }
        }

        public int Dribbling
        {
            get
            {
                return dribbling;
            }

            set
            {
                dribbling = value;
            }
        }

        public int Finishing
        {
            get
            {
                return finishing;
            }

            set
            {
                finishing = value;
            }
        }

        public int Freekickaccuracy
        {
            get
            {
                return freekickaccuracy;
            }

            set
            {
                freekickaccuracy = value;
            }
        }

        public int Gkdiving
        {
            get
            {
                return gkdiving;
            }

            set
            {
                gkdiving = value;
            }
        }

        public int Gkposition
        {
            get
            {
                return gkposition;
            }

            set
            {
                gkposition = value;
            }
        }

        public int Gkreflexes
        {
            get
            {
                return gkreflexes;
            }

            set
            {
                gkreflexes = value;
            }
        }

        public int Headingaccuracy
        {
            get
            {
                return headingaccuracy;
            }

            set
            {
                headingaccuracy = value;
            }
        }

        public int Interceptions
        {
            get
            {
                return interceptions;
            }

            set
            {
                interceptions = value;
            }
        }

        public int Jumping
        {
            get
            {
                return jumping;
            }

            set
            {
                jumping = value;
            }
        }

        public int Longpassing
        {
            get
            {
                return longpassing;
            }

            set
            {
                longpassing = value;
            }
        }

        public int Longshots
        {
            get
            {
                return longshots;
            }

            set
            {
                longshots = value;
            }
        }

        public int Marking
        {
            get
            {
                return marking;
            }

            set
            {
                marking = value;
            }
        }

        public int Penalties
        {
            get
            {
                return penalties;
            }

            set
            {
                penalties = value;
            }
        }

        public int Positioning
        {
            get
            {
                return positioning;
            }

            set
            {
                positioning = value;
            }
        }

        public int Potential
        {
            get
            {
                return potential;
            }

            set
            {
                potential = value;
            }
        }

        public int Reactions
        {
            get
            {
                return reactions;
            }

            set
            {
                reactions = value;
            }
        }

        public int Shortpassing
        {
            get
            {
                return shortpassing;
            }

            set
            {
                shortpassing = value;
            }
        }

        public int Shotpower
        {
            get
            {
                return shotpower;
            }

            set
            {
                shotpower = value;
            }
        }

        public int Slidingtackle
        {
            get
            {
                return slidingtackle;
            }

            set
            {
                slidingtackle = value;
            }
        }

        public int Sprintspeed
        {
            get
            {
                return sprintspeed;
            }

            set
            {
                sprintspeed = value;
            }
        }

        public int Standingtackle
        {
            get
            {
                return standingtackle;
            }

            set
            {
                standingtackle = value;
            }
        }

        public int Stamina
        {
            get
            {
                return stamina;
            }

            set
            {
                stamina = value;
            }
        }

        public int Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }

        public int Vision
        {
            get
            {
                return vision;
            }

            set
            {
                vision = value;
            }
        }

        public int Volleys
        {
            get
            {
                return volleys;
            }

            set
            {
                volleys = value;
            }
        }

        public int WeakFoot
        {
            get
            {
                return weakFoot;
            }

            set
            {
                weakFoot = value;
            }
        }

        public int RarityID
        {
            get
            {
                return rarityID;
            }

            set
            {
                rarityID = value;
            }
        }

        public string Quality
        {
            get
            {
                return quality;
            }

            set
            {
                quality = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int BaseId
        {
            get
            {
                return baseId;
            }

            set
            {
                baseId = value;
            }
        }

        public int Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public static Player FromJson(JObject json)
        {
            Player p = new Player();
            p.acceleration = json["acceleration"].Value<int>();
            p.age = json["age"].Value<int>();
            p.aggression = json["aggression"].Value<int>();
            p.agility = json["agility"].Value<int>();
            p.balance = json["balance"].Value<int>();
            p.ballcontrol = json["ballcontrol"].Value<int>();
            p.baseId = json["baseId"].Value<int>();
            p.birthdate = json["birthdate"].Value<String>();
            p.commonName = json["commonName"].Value<String>();
            if(p.commonName.Equals(""))
            {
                p.commonName = json["firstName"].Value<String>() + " " + json["lastName"].Value<String>();
            }
            p.composure = json["composure"].Value<int>();
            p.crossing = json ["crossing"].Value<int>();
            p.dribbling = json["dribbling"].Value<int>();
            p.finishing = json["finishing"].Value<int>();
            p.foot = json["foot"].Value<String>();
            p.freekickaccuracy = json["freekickaccuracy"].Value<int>();
            p.gkdiving = json["gkdiving"].Value<int>();
            p.gkposition = json["gkpositioning"].Value<int>();
            p.gkreflexes = json["gkreflexes"].Value<int>();
            p.headingaccuracy = json["headingaccuracy"].Value<int>();
            p.height = json["height"].Value<int>();
            p.id = json["id"].Value<int>();
            p.interceptions = json["interceptions"].Value<int>();
            p.jumping = json["jumping"].Value<int>();
            p.longpassing = json["longpassing"].Value<int>();
            p.longshots = json["longshots"].Value<int>();
            p.marking = json["marking"].Value<int>();
            p.penalties = json["penalties"].Value<int>();
            p.playStyle = json["playStyle"].Value<String>();
            p.position = json["position"].Value<String>();
            p.potential = json["potential"].Value<int>();
            p.quality = json["quality"].ToString();
            p.rarityID = json["rarityId"].Value<int>();
            p.rating = json["rating"].Value<int>();
            p.reactions = json["reactions"].Value<int>();
            p.shortpassing = json["shortpassing"].Value<int>();
            p.shotpower = json["shotpower"].Value<int>();
            p.skillMoves = json["skillMoves"].Value<int>();
            p.slidingtackle = json["slidingtackle"].Value<int>();
            p.sprintspeed = json["sprintspeed"].Value<int>();
            p.standingtackle = json["standingtackle"].Value<int>();
            p.stamina = json["stamina"].Value<int>();
            p.strength = json["strength"].Value<int>();
            p.vision = json["vision"].Value<int>();
            p.volleys = json["volleys"].Value<int>();
            p.weakFoot = json["weakFoot"].Value<int>();
            p.weight = json["weight"].Value<int>();

            JObject leagueJSON = json["league"].Value<JObject>();
            League l = League.FromJson(leagueJSON);
            p.league = l;
            ItemLists.AddLeague(l);

            JObject clubJSON = json["club"].Value<JObject>();
            Club c = Models.Club.FromJson(clubJSON);
            p.club = c;
            ItemLists.AddClub(c);

            JObject nationJson = json["nation"].Value<JObject>();
            Nation n = Models.Nation.FromJson(nationJson);
            p.nation = n;
            ItemLists.AddNation(n);
            p.jsonRep = json;
            return p;
        }

        public JObject ToJson()
        {
            
                JObject jobj = new JObject();
                jobj["commonName"] = this.commonName;
                jobj["age"] = this.age;
                jobj["rating"] = this.rating;
                jobj["height"] = this.height;
                jobj["weight"] = this.weight;
                jobj["nation"] = this.nation.name;
                jobj["team"] = this.club.name;
                return jobj;
        }

        public int CompareTo(Player other)
        {
            return this.id.CompareTo(other.id);
        }
    }
}
