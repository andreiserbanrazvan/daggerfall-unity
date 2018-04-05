﻿// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2018 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using UnityEngine;
using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace DaggerfallWorkshop.Game.MagicAndEffects
{
    /// <summary>
    /// Enumerates available magic effects and coordinates their instantiation.
    /// Also coordinates "magic rounds" at 5-second intervals for all entity EntityEffectManager components active in scene.
    /// </summary>
    public class EntityEffectBroker : MonoBehaviour
    {
        const float roundInterval = 5.0f;

        int magicRoundsSinceStartup = 0;
        float roundTimer = 0f;

        /// <summary>
        /// Gets the number of 5-second "magic rounds" since startup.
        /// </summary>
        public int MagicRoundsSinceStartup
        {
            get { return magicRoundsSinceStartup; }
        }

        void Start()
        {
            // Test
            IEnumerable<IEntityEffect> magicEffects = ReflectiveEnumerator.GetEnumerableOfType<IEntityEffect>();
        }

        void Update()
        {
            // Increment magic round timer when not paused
            if (!GameManager.IsGamePaused)
            {
                roundTimer += Time.deltaTime;
                if (roundTimer > roundInterval)
                {
                    RaiseOnNewMagicRoundEvent();
                    magicRoundsSinceStartup++;
                    roundTimer = 0;
                    //Debug.Log("New magic round starting.");
                }
            }
        }

        #region Events

        // OnNewMagicRound
        public delegate void OnNewMagicRoundEventHandler();
        public static event OnNewMagicRoundEventHandler OnNewMagicRound;
        protected virtual void RaiseOnNewMagicRoundEvent()
        {
            if (OnNewMagicRound != null)
                OnNewMagicRound();
        }

        #endregion
    }

    /// <summary>
    /// Find all subclasses of type and create instance.
    /// </summary>
    public static class ReflectiveEnumerator
    {
        static ReflectiveEnumerator() { }

        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
        {
            List<T> objects = new List<T>();
            foreach (Type type in
                Assembly.GetAssembly(typeof(T)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            return objects;
        }
    }
}
