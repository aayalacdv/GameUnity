using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;         //Allows us to use Lists.
using Random = UnityEngine.Random;         //Tells Random to use the Unity Engine random number generator.
using System.Text;

namespace Completed
{
    public class BoardManager : MonoBehaviour
    {
        private Transform mainBoard;
        private Transform bridgeBoard;
        private Transform restaurantBoard;

        GameObject toInstantiate;
        GameObject toInstantiate2;
        GameObject toInstantiate3;
        GameObject toInstantiate4;
        GameObject toInstantiate5;

        GameObject map;
        GameObject healthy1;
        GameObject healthy2;
        GameObject healthy3;
        GameObject healthy4;
        GameObject player;

        public bool restaurant = false;
        public bool bridge = false;
        public bool main = false;

        public bool h1 = true;
        public bool h2 = true;
        public bool h3 = true;
        public bool h4 = true;


        public GameObject getPlayer()
        {
            return this.player;
        }



        private void Awake()
        {

        }
        public void SetupScene(int level, int scene)
        {

            if (scene == 0 && !main)
            {
                Destroy(map);
                Destroy(healthy1);
                Destroy(healthy2);
                Destroy(healthy3);
                Destroy(healthy4);


                mainBoard = new GameObject("Board" + level.ToString()).transform;
                toInstantiate = Resources.Load("Prefabs/Level" + level.ToString() + "/MainBoard") as GameObject;
                map = Instantiate(toInstantiate, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                map.transform.SetParent(mainBoard);
                player = GameObject.Find("Player(Clone)");
                if (player == null)
                {
                    player = Resources.Load("Player") as GameObject;
                    Instantiate(player, new Vector2(-7, 6), Quaternion.identity);
                }

                if (h1)
                {
                    toInstantiate2 = Resources.Load("Prefabs/Level" + level.ToString() + "/Healthy1") as GameObject;
                    Instantiate(toInstantiate2, new Vector3(0, 0, 0), Quaternion.identity);
                if (h2)
                    {
                        toInstantiate3 = Resources.Load("Prefabs/Level" + level.ToString() + "/Healthy2") as GameObject;
                         Instantiate(toInstantiate3, new Vector3(0, 0, 0), Quaternion.identity);
                                           }
                    if (h3)
                    {
                        toInstantiate4 = Resources.Load("Prefabs/Level" + level.ToString() + "/Healthy3") as GameObject;
                       Instantiate(toInstantiate4, new Vector3(0, 0, 0), Quaternion.identity);
                                         }
                    if (h4)
                    {
                        toInstantiate5 = Resources.Load("Prefabs/Level" + level.ToString() + "/Healthy4") as GameObject;
                       Instantiate(toInstantiate5, new Vector3(0, 0, 0), Quaternion.identity) ;
                                            }

                    restaurant = false;
                    bridge = false;
                    main = true;
                }

                else if (scene == 1 && !restaurant)
                {
                    Destroy(map);
                    Destroy(healthy1);
                    Destroy(healthy2);
                    Destroy(healthy3);
                    Destroy(healthy4);

                    restaurantBoard = new GameObject("Restaurant" + level.ToString()).transform;
                    toInstantiate = Resources.Load("Prefabs/Level" + level.ToString() + "/Restaurant") as GameObject;
                    map = Instantiate(toInstantiate, new Vector3(-3, -4, 0), Quaternion.identity) as GameObject;
                    map.transform.SetParent(restaurantBoard);

                    restaurant = true;
                    bridge = false;
                    main = false;
                }

                else if (scene == 3 && !bridge)
                {
                    Destroy(map);
                    Destroy(healthy1);
                    Destroy(healthy2);
                    Destroy(healthy3);
                    Destroy(healthy4);

                    bridgeBoard = new GameObject("Bridge" + level.ToString()).transform;
                    toInstantiate = Resources.Load("Prefabs/Level" + level.ToString() + "/MainBoardBridge") as GameObject;
                    map = Instantiate(toInstantiate, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                    map.transform.SetParent(bridgeBoard);

                    if (h1)
                    {
                        toInstantiate2 = Resources.Load("Prefabs/Level" + level.ToString() + "/Healthy1") as GameObject;
                        healthy1 = Instantiate(toInstantiate2, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                        healthy1.transform.SetParent(bridgeBoard);
                    }
                    if (h2)
                    {
                        toInstantiate3 = Resources.Load("Prefabs/Level" + level.ToString() + "/Healthy2") as GameObject;
                        healthy2 = Instantiate(toInstantiate3, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                        healthy2.transform.SetParent(bridgeBoard);
                    }
                    if (h3)
                    {
                        toInstantiate4 = Resources.Load("Prefabs/Level" + level.ToString() + "/Healthy3") as GameObject;
                        healthy3 = Instantiate(toInstantiate4, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                        healthy3.transform.SetParent(bridgeBoard);
                    }
                    if (h4)
                    {
                        toInstantiate5 = Resources.Load("Prefabs/Level" + level.ToString() + "/Healthy4") as GameObject;
                        healthy4 = Instantiate(toInstantiate5, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                        healthy4.transform.SetParent(bridgeBoard);
                    }

                    restaurant = false;
                    bridge = true;
                    main = false;
                }
            }
        }
    }
}