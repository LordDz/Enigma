﻿using Assets.Enigma.Components.Base_Classes.Maps.Preplaced;
using Assets.Enigma.Components.Base_Classes.Player;
using Assets.Enigma.Components.Base_Classes.TeamSettings.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Enigma.Components.Network
{
    public class NetworkManagerExtension : NetworkManager
    {
<<<<<<< HEAD
        public GameObject SpectatorPrefab;
        public GameObject SpectatorSpawn;
        public override void OnServerConnect(NetworkConnection conn)
        {
            Debug.Log("OnServerConnect");

            SpawnPreplaced();
            SpawnSpectator();
        }

        private void SpawnPreplaced()
        {
            MultiplayerSpawnType[] prePlacedObjects = GameObject.FindObjectsOfType<MultiplayerSpawnType>();
            foreach (MultiplayerSpawnType spawnType in prePlacedObjects)
=======
        public GameObject PlayerPrefab;
        public List<MultiplayerSpawnType> ListPrePlaced;
        public override void OnServerConnect(NetworkConnection conn)
        {
            Debug.Log("OnServerConnect");
            var test = conn.connectionId;

            foreach (MultiplayerSpawnType spawnType in ListPrePlaced)
>>>>>>> parent of def48257... Uhh I don't remember leaving witha  ton of uncommited stuff
            {
                spawnType.SpawnObject();
            }
        }

        public void SpawnPlayer(TeamName teamName)
        {
            CreatePlayer(teamName);
            KillSpectatorPlayer();
        }

<<<<<<< HEAD
        private void SpawnSpectator()
        {
            var spectatorObj = Instantiate(SpectatorPrefab, SpectatorSpawn.transform.position, SpectatorPrefab.transform.rotation);
            NetworkServer.Spawn(spectatorObj);
        }

=======
>>>>>>> parent of def48257... Uhh I don't remember leaving witha  ton of uncommited stuff
        /// <summary>
        /// Temporary function until we only have a better spectator and player system.
        /// </summary>
        private void KillSpectatorPlayer()
        {
            var specator = NetworkManager.FindObjectsOfType<PlayerSpectator>().First();
            if (specator != null)
            {
                Destroy(specator.gameObject);
            }
            else
            {
                Debug.Log("No spectator players for KillSpectatorPlayer function");
            }
        }

        private void CreatePlayer(TeamName teamName)
        {
            var spawnPoints = NetworkManager.FindObjectsOfType<SpawnPos>();
            foreach (var spawn in spawnPoints)
            {
                var teamSpawn = spawn.GetTeam();
                if (teamSpawn.TeamName == teamName)
                {
                    var spawnObj = (GameObject)Instantiate(PlayerPrefab, spawn.transform.position, spawn.transform.rotation);
                    spawnObj.GetComponent<Team>().TeamName = teamSpawn.TeamName;
                    NetworkServer.Spawn(spawnObj);
                    break;
                }
            }
        }
    }
}
