﻿#region

using System;
using System.Net;

#endregion

namespace LegendaryClient.Logic.Region.Garena
{
    public sealed class MY : BaseRegion
    {
        public override string Location
        {
            get { return null; }
        }

        public override string RegionName
        {
            get { return "SEA"; }
        }

        public override bool Garena
        {
            get { return true; }
        }

        public override string InternalName
        {
            get { return "MY"; }
        }

        public override string ChatName
        {
            get { return ""; }
        }

        public override Uri NewsAddress
        {
            get { return new Uri("http://ll.leagueoflegends.com/landingpage/data/na/en_US.js"); }
            //http://lol.garena.com/landing.php?[garneaUser]
        }

        public override string Locale
        {
            get { return "en_US"; }
        }

        public override PVPNetConnect.Region PVPRegion
        {
            get { return PVPNetConnect.Region.MY; }
        }

        public override IPAddress[] PingAddresses
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override Uri SpectatorLink
        {
            get { return new Uri("http://203.116.112.222:8088/observer-mode/rest/"); }
        }

        public override string SpectatorIpAddress
        {
            get { return "203.116.112.222:8088"; }
            set { }
        }
    }
}
