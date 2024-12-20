using Il2CppTLD.Gear;
using MelonLoader;
using UnityEngine.AddressableAssets;

namespace ExamineActionsAPI
{

    public static class PowderAndLiquidTypesLocator
    {
        public static void PreLoad ()
        {
            MelonLogger.Msg($"Preloading official powder: { GunPowderType?.name}");
            MelonLogger.Msg($"Preloading official liquid: { WaterPottableType?.name}");
            MelonLogger.Msg($"Preloading official liquid: { WaterNonPottableType?.name}");
            MelonLogger.Msg($"Preloading official liquid: { AntisepticType?.name}");
            MelonLogger.Msg($"Preloading official liquid: { KeroseneType?.name}");
            MelonLogger.Msg($"Preloading official liquid: { AccelerantType?.name}");
        }
        private static PowderType? gunPowderType;

        public static PowderType? GunPowderType
        {
            get
            {
                if (gunPowderType == null)
                {
                    gunPowderType = Addressables.LoadAsset<PowderType>("POWDER_Gunpowder").Result;
                    if (gunPowderType == null) MelonLogger.Error("Failed to retrieve POWDER_GunPowder (It's ok this happens on game start)");
                }
                return gunPowderType;
            }
        }


        private static LiquidType? waterPottableType;
        public static LiquidType? WaterPottableType
        {
            get
            {
                if (waterPottableType == null)
                {
                    waterPottableType = Addressables.LoadAsset<LiquidType>("LIQUID_WaterPotable").Result;
                    if (waterPottableType == null) MelonLogger.Error("Failed to retrieve LIQUID_WaterPotable (It's ok this happens on game start)");
                }
                return waterPottableType;
            }
        }


        private static LiquidType? waterNonPottableType;
        public static LiquidType? WaterNonPottableType
        {
            get
            {
                if (waterNonPottableType == null)
                {
                    waterNonPottableType = Addressables.LoadAsset<LiquidType>("LIQUID_WaterNonPotable").Result;
                    if (waterNonPottableType == null) MelonLogger.Error("Failed to retrieve LIQUID_WaterNonPotable (It's ok this happens on game start)");
                }
                return waterNonPottableType;
            }
        }

        private static LiquidType? keroseneType;
        public static LiquidType? KeroseneType
        {
            get
            {
                if (keroseneType == null)
                {
                    keroseneType = Addressables.LoadAsset<LiquidType>("LIQUID_Kerosene").Result;
                    if (keroseneType == null) MelonLogger.Error("Failed to retrieve LIQUID_Kerosene (It's ok this happens on game start)");
                }
                return keroseneType;
            }
        }

        private static LiquidType? antisepticType;
        public static LiquidType? AntisepticType
        {
            get
            {
                if (antisepticType == null)
                {
                    antisepticType = Addressables.LoadAsset<LiquidType>("LIQUID_Antiseptic").Result;
                    if (antisepticType == null) MelonLogger.Error("Failed to retrieve LIQUID_Antiseptic (It's ok this happens on game start)");
                }
                return antisepticType;
            }
        }

        private static LiquidType? accelerantType;
        /// <summary>
        /// NOTE: HL is not using this as in July 2023
        /// </summary>
        /// <value></value>
        public static LiquidType? AccelerantType
        {
            get
            {
                if (accelerantType == null)
                {
                    accelerantType = Addressables.LoadAsset<LiquidType>("LIQUID_Accelerant").Result;
                    if (accelerantType == null) MelonLogger.Error("Failed to retrieve LIQUID_Accelerant (It's ok this happens on game start)");
                }
                return accelerantType;
            }
        }
        // public static IReadOnlyDictionary<string, PowderType> PowderTypes
        // {
        //     get
        //     {
        //         if (powderTypes == null)
        //         {
        //             powderTypes = new();
        // 	        MelonLogger.Msg($"Populating powder types");
        //             foreach (var b in BlueprintManager.Instance.m_AllBlueprints)
        //             {
        //                 if (b.m_RequiredPowder != null)
        //                     foreach (var c in b.m_RequiredPowder)
        //                     {
        //                         if (powderTypes.ContainsKey(c.m_Powder.name)) continue;
        //                         powderTypes.Add(c.m_Powder.name, c.m_Powder);
        //                         MelonModLogger.Msg($"Found PowderType: {c.m_Powder.name}: {Addressables.LoadAsset<LiquidType>(c.m_Powder.name)?.ReferenceCount}");
        //                     }
        //             }

        //             var allLocations = new List<IResourceLocation>();
        //             var resourceLocators = Addressables.ResourceLocators.ToArray();
        //             foreach (var loc in resourceLocators)
        //             {
        // 	            MelonLogger.Msg($"---Locator: {loc.LocatorId}");
        //                 foreach (var k in loc.Keys.ToArray())
        // 	            MelonLogger.Msg($"---{k.GetType().Name} {k.ToString()}");
        //             }

        //         }
        //         return powderTypes;
        //     }
        // }
    }
}
