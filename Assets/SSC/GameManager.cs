﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SSC
{
    public class GameManager : MonoBehaviour
    {
        List<PlanetInfo> planets = new List<PlanetInfo>();
        // Use this for initialization
        void Start()
        {
            planets.Add(new PlanetInfo("Sun", 0f, 0, 0, 0, 695500f));
            planets.Add(new PlanetInfo("Mercury", 57910000f, 87.97f, 7.00f, 0.21f, 244f));
            planets.Add(new PlanetInfo("Venus", 108200000f, 224.70f, 3.39f, 0.01f, 6051f));
            planets.Add(new PlanetInfo("Earth", 149600000f, 365.26f, 0.00f, 0.02f, 6378f));
            planets.Add(new PlanetInfo("Mars", 227940000f, 686.98f, 1.85f, 0.09f, 3397f));
            planets.Add(new PlanetInfo("Jupiter", 778330000f, 4332.71f, 1.31f, 0.05f, 71492f));
            planets.Add(new PlanetInfo("Saturn", 1429400000f, 10759.50f, 2.49f, 0.06f, 60268f));
            planets.Add(new PlanetInfo("Uranus", 2870990000f, 30685.00f, 0.77f, 0.05f, 25559f));
            planets.Add(new PlanetInfo("Neptune", 4504300000f, 60190.00f, 1.77f, 0.01f, 24764f));
            planets.Add(new PlanetInfo("Pluto", 5913520000f, 90550f, 17.15f, 0.25f, 1160f));

            foreach (PlanetInfo planetInfo in planets)
            {
                GameObject planet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                float scale =  (planetInfo.radius * 2.0f) / 10000.0f;
                planet.transform.localScale = new Vector3(scale, scale, scale);
                planet.transform.position = new Vector3(0, 0, planetInfo.distance / 10000f);
                Debug.Log(scale + " " + planet.transform.position);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
