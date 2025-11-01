# 7DTD XUi Cheat‑Sheet
_Generated: 2025-10-27T16:58:20.138010_
- Root: `C:\Program Files (x86)\Steam\steamapps\common\7 Days To Die\Data\Config`
- Files scanned: **52**

## Common Enums (Observed)
### `anchor`
| Value | Count |
| --- | --- |
| `CenterCenter` | 63 |
| `RightTop` | 16 |
| `CenterTop` | 15 |
| `CenterBottom` | 8 |
| `LeftTop` | 8 |
| `LeftBottom` | 4 |
| `RightCenter` | 3 |
| `RightBottom` | 2 |

### `pivot`
| Value | Count |
| --- | --- |
| `center` | 469 |
| `topleft` | 243 |
| `left` | 226 |
| `right` | 67 |
| `Left` | 59 |
| `topLeft` | 23 |
| `topright` | 18 |
| `${pivot}` | 8 |
| `bottom` | 8 |
| `bottomleft` | 8 |
| `TopLeft` | 7 |
| `Right` | 5 |
| `BottomLeft` | 2 |
| `top` | 2 |
| `bottomright` | 1 |

### `visible`
| Value | Count |
| --- | --- |
| `hasentry` | 39 |
| `false` | 26 |
| `${visible|true}` | 21 |
| `${visible}` | 19 |
| `hasdurability` | 18 |
| `true` | 16 |
| `discord_is_ready` | 11 |
| `onlyconnected` | 9 |
| `statvisible` | 8 |
| `has_loaded_prefab` | 7 |
| `hasitemtypeicon` | 7 |
| `showfuel` | 7 |
| `# !isprefilteredsearch` | 6 |
| `isnormal` | 6 |
| `showempty` | 6 |
| `isfavorite` | 5 |
| `# !(is_prefab_editor or is_playtesting) ` | 4 |
| `# !is_modal` | 4 |
| `# attach_saves_enabled` | 4 |
| `# commsallowed and voiceavailable` | 4 |
| `# in_game` | 4 |
| `assigned` | 4 |
| `connecting_console` | 4 |
| `is_prefab_editor` | 4 |
| `selected` | 4 |
| `showPaging` | 4 |
| `showaction` | 4 |
| `showleaderboard` | 4 |
| `supports_full_accounts` | 4 |
| `triggers_enabled` | 4 |

### `visible` — Literal values
| Literal | Count |
| --- | --- |
| `false` | 25 |
| `${visible|true}` | 21 |
| `${visible}` | 19 |
| `true` | 16 |

### `visible` — Binding keys
| Binding | Count |
| --- | --- |
| `{hasentry}` | 39 |
| `{hasdurability}` | 18 |
| `{discord_is_ready}` | 11 |
| `{onlyconnected}` | 9 |
| `{statvisible}` | 8 |
| `{has_loaded_prefab}` | 7 |
| `{hasitemtypeicon}` | 7 |
| `{showfuel}` | 7 |
| `{# !isprefilteredsearch}` | 6 |
| `{isnormal}` | 6 |
| `{showempty}` | 6 |
| `{isfavorite}` | 5 |
| `{# !(is_prefab_editor or is_playtesting) }` | 4 |
| `{# !is_modal}` | 4 |
| `{# attach_saves_enabled}` | 4 |
| `{# commsallowed and voiceavailable}` | 4 |
| `{# in_game}` | 4 |
| `{assigned}` | 4 |
| `{connecting_console}` | 4 |
| `{is_prefab_editor}` | 4 |
| `{selected}` | 4 |
| `{showPaging}` | 4 |
| `{showaction}` | 4 |
| `{showleaderboard}` | 4 |
| `{supports_full_accounts}` | 4 |
| `{triggers_enabled}` | 4 |
| `{# !is_self }` | 3 |
| `{# !viewmode}` | 3 |
| `{# ishovered and islocked}` | 3 |
| `{buttons_visible}` | 3 |


## Elements (Top and their common attributes)
### `property` — 99.6k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `Extends` | 97.6k |
| `value` | `true` | 97.6k |
| `class` | `Action0` | 2.0k |
| `param1` | `CustomIcon` | 1.9k |
| `data` | `type=blade+target=leftforearmroll+atp=true+detach=true+mask=true` | 354 |
| `type` | `float` | 212 |

### `block` — 8.7k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `air` | 8.7k |
| `prob` | `1` | 2.2k |
| `biome` | `desert` | 192 |
| `randomrotation` | `true` | 166 |
| `param1` | `CustomIcon,CustomIconTint,TintColor` | 11 |
| `shapes` | `All` | 9 |
| `questtag` | `infested` | 8 |
| `hide_helper_in_creative` | `true` | 1 |

### `AudioClip` — 7.5k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `ClipName` | `@:Sounds/Twitch/Silly/melee_light_hit_silly1.wav` | 7.5k |
| `Subtitle` | `trader_jen_announce_closed_01` | 1.9k |
| `AltSound` | `true` | 302 |
| `profanity` | `true` | 182 |
| `Loop` | `true` | 77 |
| `AudioSourceName` | `@:Sounds/Prefabs/AudioSource_Impact_XSmall.prefab` | 5 |

### `item` — 6.7k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `casinoCoin` | 4.8k |
| `group` | `booksAllScaled` | 1.9k |
| `count` | `1` | 1.8k |
| `loot_prob_template` | `low` | 1.4k |
| `force_prob` | `true` | 169 |
| `quality` | `1,5` | 123 |
| `random_durability` | `false` | 112 |
| `loot_stage_count_mod` | `0.01` | 84 |

### `triggered_effect` — 5.6k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `action` | `ModifyCVar` | 5.6k |
| `trigger` | `onSelfPrimaryActionEnd` | 5.6k |
| `cvar` | `$foodAmountAdd` | 2.5k |
| `value` | `1` | 2.2k |
| `operation` | `set` | 2.2k |
| `buff` | `buffProcessConsumables` | 1.3k |
| `level` | `-1` | 495 |
| `progression_name` | `perkArtOfMiningComplete` | 495 |

### `passive_effect` — 5.4k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `CraftingIngredientCount` | 5.4k |
| `operation` | `base_set` | 5.4k |
| `value` | `1` | 5.4k |
| `tags` | `perkArchery` | 3.6k |
| `level` | `1,5` | 1.2k |
| `tier` | `1,6` | 587 |
| `duration` | `0,3` | 237 |
| `invert_tag_check` | `true` | 2 |

### `requirement` — 4.3k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `ProgressionLevel` | 4.1k |
| `value` | `0` | 2.9k |
| `operation` | `GTE` | 2.8k |
| `progression_name` | `perkPhysician` | 985 |
| `cvar` | `infectionCounter` | 910 |
| `buff` | `buffFarmerSetBonus` | 690 |
| `tags` | `trader` | 496 |
| `desc_key` | `reqGenericPoints01` | 301 |

### `drop` — 3.8k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `count` | `0` | 3.8k |
| `event` | `Harvest` | 3.8k |
| `name` | `resourceScrapIron` | 3.2k |
| `tag` | `allHarvest,perkJunkMiner` | 1.8k |
| `prob` | `0.75` | 782 |
| `tool_category` | `Disassemble` | 515 |
| `stick_chance` | `1` | 459 |

### `variable` — 3.1k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `alertsound` | 3.1k |
| `value` | `zombiemalealert` | 3.1k |

### `effect_group` — 2.9k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `tiered` | `false` | 824 |
| `name` | `Base Effects` | 762 |

### `spawn` — 2.5k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `group` | `feralHordeStageGS10` | 2.4k |
| `maxAlive` | `256` | 2.1k |
| `num` | `500` | 2.1k |
| `duration` | `1` | 2.1k |
| `interval` | `17` | 660 |
| `entitygroup` | `ZombiesAll` | 54 |
| `id` | `dz01` | 54 |
| `maxcount` | `1` | 54 |

### `MaxRepeatRate` — 2.4k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `value` | `0.01` | 2.4k |

### `MaxVoices` — 2.4k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `value` | `10` | 2.4k |

### `SoundDataNode` — 2.4k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `44magnum_fire` | 2.4k |

### `AudioSource` — 2.4k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `@:Sounds/Prefabs/AudioSource_UI_Item.prefab` | 2.4k |

### `CrouchNoiseScale` — 2.4k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `value` | `0.5` | 2.4k |

### `LocalCrouchVolumeScale` — 2.4k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `value` | `1.0` | 2.4k |

### `NoiseScale` — 2.4k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `value` | `1` | 2.4k |

### `shape` — 2.2k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `3mGyroConnector` | 2.2k |
| `tag` | `Bulletproof` | 63 |

### `entitygroup` — 1.9k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `BearGroup` | 1.9k |

### `ingredient` — 1.8k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `count` | `1` | 1.8k |
| `name` | `resourceForgedSteel` | 1.8k |

### `gamestage` — 1.8k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `stage` | `1` | 1.8k |

### `sprite` — 1.5k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `depth` | `2` | 1.4k |
| `color` | `[black]` | 1.2k |
| `name` | `backgroundMain` | 1.2k |
| `sprite` | `menu_empty3px` | 1.1k |
| `type` | `sliced` | 1.0k |
| `pos` | `0,0` | 914 |
| `height` | `24` | 762 |
| `width` | `24` | 713 |

### `loot` — 1.4k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `prob` | `1` | 1.4k |
| `quality` | `4` | 1.1k |
| `level` | `1,999999` | 302 |

### `Subtitle` — 1.3k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `contentLocId` | `trader_bob_announce_closed_01` | 1.3k |
| `name` | `trader_bob_announce_closed_01` | 1.3k |
| `speakerColor` | `traders` | 1.3k |
| `speakerLocId` | `subtitleSpeaker_Trader_Hugh` | 1.3k |

### `Noise` — 1.2k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `ID` | `2` | 1.2k |
| `time` | `3` | 1.2k |
| `noise` | `7` | 1.2k |
| `muffled_when_crouched` | `0.5` | 1.1k |
| `heat_map_strength` | `0.05` | 330 |
| `heat_map_time` | `60` | 330 |
| `volume` | `7` | 1 |

### `action` — 1.2k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `class` | `PlaySound` | 798 |
| `name` | `MoveToEnemy` | 368 |
| `extends` | `twitch_spawnWeapon1` | 212 |
| `type` | `Trader` | 27 |
| `weight` | `2` | 15 |
| `id` | `restock` | 11 |
| `distance` | `6` | 1 |

### `label` — 1.1k occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `width` | `250` | 787 |
| `pos` | `0,0` | 773 |
| `depth` | `4` | 758 |
| `justify` | `right` | 697 |
| `font_size` | `28` | 623 |
| `text` | `` | 618 |
| `height` | `30` | 599 |
| `text_key` | `xuiPrefabGroupsAddLabel` | 497 |

### `lootgroup` — 990 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `4x4Parts` | 990 |
| `count` | `all` | 466 |
| `loot_quality_template` | `QLTemplateT0` | 61 |

### `rect` — 977 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `height` | `32` | 611 |
| `pos` | `0,-46` | 533 |
| `width` | `560` | 412 |
| `name` | `content` | 401 |
| `depth` | `1` | 350 |
| `controller` | `TabSelectorTab` | 239 |
| `visible` | `${visible}` | 183 |
| `style` | `press, hover, scroll` | 62 |

### `action_sequence` — 888 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `spawn_mama_rad` | 888 |
| `template` | `spawn_crate_template` | 675 |

### `reward` — 716 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `type` | `LootItem` | 716 |
| `value` | `1` | 674 |
| `id` | `groupQuestMedical,groupQuestAmmo,groupQuestSchematics` | 627 |
| `ischosen` | `true` | 574 |
| `isfixed` | `true` | 122 |

### `decoration` — 691 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `prob` | `.001` | 691 |
| `type` | `block` | 691 |
| `blockname` | `resourceRock02` | 588 |
| `rotatemax` | `7` | 457 |
| `name` | `rock_form01` | 103 |
| `checkresource` | `-7` | 20 |
| `onslopes` | `true` | 20 |

### `display_entry` — 620 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `EntityDamage` | 534 |
| `title_key` | `statDuration` | 534 |
| `display_type` | `Percent` | 289 |
| `tags` | `perkGunslinger,perkBoomstick,perkDeadEye,perkMachineGunner,perkBookAutoWeapons,perkTurrets,perkArchery,admin` | 148 |
| `display_leading_plus` | `true` | 115 |
| `unlock_level` | `1,2,4,6,8,10` | 86 |
| `negative_preferred` | `true` | 51 |
| `item` | `gunBotT1JunkSledge` | 47 |

### `HighestPitch` — 608 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `1.0` | 608 |

### `LowestPitch` — 608 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `0.9` | 608 |

### `recipe` — 577 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `count` | `1` | 577 |
| `name` | `resourceCloth` | 577 |
| `tags` | `learnable,workbenchCrafting` | 568 |
| `craft_area` | `workbench` | 391 |
| `craft_time` | `1` | 103 |
| `craft_tool` | `toolCookingPot` | 43 |
| `always_unlocked` | `true` | 38 |
| `is_trackable` | `false` | 32 |

### `display_value` — 572 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `value` | `duration` | 572 |
| `name` | `dStaminaChangeOT` | 351 |
| `tier` | `1,2,3,4,5,6` | 59 |
| `level` | `1,2,3,4,5,6` | 1 |
| `operation` | `base_add` | 1 |
| `tags` | `` | 1 |

### `buff` — 438 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `buffAbrasionCatch` | 438 |
| `icon` | `ui_game_symbol_armor_iron` | 350 |
| `name_key` | `trigger` | 331 |
| `description_key` | `TwitchBuff_NoVehicleDesc` | 274 |
| `icon_color` | `255,175,175` | 271 |
| `hidden` | `true` | 113 |
| `tooltip_key` | `buffIsOnFireTooltip` | 84 |
| `remove_on_death` | `false` | 66 |

### `placeholder` — 436 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `abandonedPickupTruck01DoorRandomHelper` | 436 |

### `window` — 415 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `windowNonPagingHeader` | 415 |
| `height` | `100` | 171 |
| `width` | `228` | 171 |
| `controller` | `LevelToolsGenericWindow` | 164 |
| `cursor_area` | `true` | 141 |
| `anchor` | `CenterCenter` | 118 |
| `pos` | `0,0` | 111 |
| `panel` | `Left` | 63 |

### `panel` — 404 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `height` | `43` | 345 |
| `depth` | `1` | 313 |
| `name` | `header` | 297 |
| `pos` | `0,0` | 269 |
| `disableautobackground` | `true` | 200 |
| `width` | `98` | 195 |
| `borderthickness` | `3` | 129 |
| `bordercolor` | `[black]` | 124 |

### `cooldown_addition` — 381 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `twitch_buffHeadshotOnly` | 381 |
| `time` | `60` | 381 |
| `is_action` | `false` | 17 |

### `duration` — 377 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `value` | `0` | 377 |

### `stack_type` — 377 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `value` | `replace` | 377 |

### `vote_entry` — 339 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `Action_AntiLeech` | 339 |
| `extends` | `Burn_PartyGirl` | 326 |

### `lootcontainer` — 335 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `loot_quality_template` | `qualBaseTemplate` | 335 |
| `name` | `PObox` | 335 |
| `size` | `6,2` | 335 |
| `sound_close` | `SupplyDrops/close_supply_crate` | 335 |
| `sound_open` | `SupplyDrops/open_supply_crate` | 335 |
| `count` | `1` | 298 |
| `destroy_on_close` | `true` | 233 |
| `open_time` | `0.25` | 187 |

### `effect_description` — 328 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `desc_key` | `attAgilityRank01Desc` | 328 |
| `level` | `1` | 328 |
| `long_desc_key` | `attAgilityRank01LongDesc` | 328 |
| `desc_base` | `Non localized modder descriptions go here` | 1 |

### `qualitytemplate` — 322 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `default_quality` | `1` | 322 |
| `level` | `1,999999` | 322 |

### `objective` — 313 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `type` | `Harvest` | 313 |
| `count` | `50` | 186 |
| `item` | `resourceLeather` | 98 |
| `block_tag` | `challenge_farming` | 30 |
| `entity_tags` | `zombie` | 24 |
| `target_name_key` | `xuiZombies` | 24 |
| `entity_names` | `zombieMutated,zombieMutatedFeral,zombieMutatedRadiated,zombieMutatedCharged,zombieMutatedInfernal` | 22 |
| `biome` | `burnt_forest` | 20 |

### `style_entry` — 307 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `depth` | 307 |
| `value` | `true` | 307 |

### `level_requirements` — 301 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `level` | `1` | 301 |

### `entity_class` — 280 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `name` | `Backpack` | 280 |
| `extends` | `twitch_crate_template` | 248 |

### `grid` — 253 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `cell_height` | `45` | 251 |
| `cell_width` | `700` | 242 |
| `rows` | `1` | 231 |
| `pos` | `8,-40` | 229 |
| `repeat_content` | `true` | 221 |
| `cols` | `1` | 207 |
| `arrangement` | `vertical` | 192 |
| `name` | `list` | 152 |

### `layer` — 250 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `blockname` | `terrStone` | 166 |
| `depth` | `3` | 166 |
| `key` | `LongEffects` | 57 |
| `value` | `1, 2, 2, 2, 2, 2, 3` | 53 |
| `name` | `PrimarySupporting` | 27 |
| `clipAdapterType` | `ClipAdapter` | 18 |
| `contentType` | `ClipSet` | 18 |
| `num` | `12` | 18 |

### `simplebutton` — 243 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `height` | `48` | 243 |
| `name` | `btnCancel` | 242 |
| `width` | `200` | 235 |
| `depth` | `3` | 220 |
| `caption_key` | `xuiCancel` | 192 |
| `font_size` | `32` | 177 |
| `pos` | `0, 0` | 169 |
| `upper_case` | `true` | 91 |

### `quest` — 229 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `id` | `intro_buried_supplies` | 229 |
| `template` | `challengegroup_reward_homesteading` | 67 |
| `end` | `0` | 5 |

### `runningvolumescale` — 228 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `value` | `2` | 228 |

### `dropextendsoff` — 222 occurrences
### `maxVoicesPerEntity` — 222 occurrences
| Attribute | Example | Seen |
| --- | --- | --- |
| `value` | `1` | 222 |


## Attribute Dictionary (Global)
### `name` — seen 154.0k times
Top literal values:
| Value | Count |
| --- | --- |
| `Extends` | 6.7k |
| `CustomIcon` | 6.2k |
| `SortOrder2` | 6.0k |
| `Model` | 5.3k |
| `CustomIconTint` | 4.0k |
| `CreativeMode` | 3.4k |
| `TintColor` | 3.3k |
| `WaterFlow` | 2.7k |
| `ShapeCategories` | 2.2k |
| `Collide` | 1.2k |
| `FilterTags` | 1.2k |
| `SortOrder1` | 1.2k |

### `value` — seen 126.7k times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 6.8k |
| `true` | 3.6k |
| `0.5` | 2.7k |
| `0` | 2.5k |
| `10` | 1.9k |
| `permitted` | 1.9k |
| `3` | 1.8k |
| `false` | 1.7k |
| `1.0` | 1.6k |
| `2` | 1.6k |
| `Dev` | 1.4k |
| `None` | 1.1k |

Top bindings:
| Binding | Count |
| --- | --- |
| `{0}` | 10 |

### `operation` — seen 10.4k times
Top literal values:
| Value | Count |
| --- | --- |
| `base_set` | 2.2k |
| `perc_add` | 1.7k |
| `set` | 1.4k |
| `base_add` | 1.3k |
| `GTE` | 880 |
| `Equals` | 834 |
| `add` | 524 |
| `LTE` | 454 |
| `GT` | 354 |
| `LT` | 231 |
| `subtract` | 134 |
| `perc_subtract` | 108 |

### `count` — seen 9.0k times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 2.6k |
| `0` | 1.2k |
| `5` | 476 |
| `1,2` | 393 |
| `2` | 379 |
| `all` | 372 |
| `10` | 320 |
| `1,3` | 238 |
| `3,6` | 199 |
| `3` | 146 |
| `2,4` | 142 |
| `20` | 121 |

### `ClipName` — seen 7.5k times
Top literal values:
| Value | Count |
| --- | --- |
| `@:Sounds/Twitch/Silly/melee_light_hit_silly1.wav` | 43 |
| `@:Sounds/Twitch/Silly/melee_light_hit_silly2.wav` | 43 |
| `@:Sounds/Twitch/Silly/melee_light_hit_silly3.wav` | 43 |
| `@:Sounds/Step/stepbush1.wav` | 13 |
| `@:Sounds/Step/stepbush2.wav` | 13 |
| `@:Sounds/Step/stepbush3.wav` | 13 |
| `@:Sounds/Step/stepbush4.wav` | 13 |
| `@:Sounds/Step/stepfern1.wav` | 13 |
| `@:Sounds/Step/stepfern2.wav` | 13 |
| `@:Sounds/Step/stepfern3.wav` | 13 |
| `@:Sounds/Step/stepfern4.wav` | 13 |
| `@:Sounds/Step/steptallgrass1.wav` | 13 |

### `action` — seen 5.6k times
Top literal values:
| Value | Count |
| --- | --- |
| `ModifyCVar` | 2.1k |
| `AddBuff` | 669 |
| `RemoveBuff` | 576 |
| `SetProgressionLevel` | 426 |
| `PlaySound` | 364 |
| `RemoveCVar` | 364 |
| `GiveExp` | 299 |
| `ModifyStats` | 93 |
| `ModifyScreenEffect` | 89 |
| `AddProgressionLevel` | 69 |
| `AttachParticleEffectToEntity` | 63 |
| `RemoveParticleEffectFromEntity` | 47 |

### `trigger` — seen 5.6k times
Top literal values:
| Value | Count |
| --- | --- |
| `onSelfPrimaryActionEnd` | 1.7k |
| `onSelfBuffUpdate` | 1.1k |
| `onSelfBuffStart` | 857 |
| `onSelfBuffRemove` | 378 |
| `onSelfAttackedOther` | 217 |
| `onSelfEquipStart` | 180 |
| `onSelfEnteredGame` | 143 |
| `onSelfBuffFinish` | 120 |
| `onSelfSecondaryActionEnd` | 109 |
| `onSelfBuffStack` | 86 |
| `onSelfSecondaryActionRayHit` | 85 |
| `onSelfEquipStop` | 69 |

### `prob` — seen 5.4k times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1.3k |
| `0.75` | 285 |
| `0.5` | 257 |
| `0` | 169 |
| `.001` | 166 |
| `.66` | 148 |
| `.05` | 143 |
| `.33` | 130 |
| `.1` | 121 |
| `.35` | 97 |
| `.65` | 72 |
| `.005` | 71 |

### `tags` — seen 4.8k times
Top literal values:
| Value | Count |
| --- | --- |
| `perkArchery` | 209 |
| `perkMiner69r` | 186 |
| `perkGunslinger` | 139 |
| `EconomicValue` | 129 |
| `learnable,workbenchCrafting` | 129 |
| `perkBoomstick` | 123 |
| `perkDeadEye` | 122 |
| `secondary` | 117 |
| `perkMachineGunner` | 114 |
| `resourceLegendaryParts` | 106 |
| `perkTurrets` | 105 |
| `running` | 86 |

### `group` — seen 4.5k times
Top literal values:
| Value | Count |
| --- | --- |
| `booksAllScaled` | 56 |
| `skillMagazines` | 40 |
| `groupMedicalCommon` | 23 |
| `groupMedicalUncommon` | 22 |
| `groupArmorParts` | 21 |
| `groupMedicalRare` | 21 |
| `groupDrinksUncommon` | 19 |
| `groupFoodUncommon` | 19 |
| `groupAmmoLarge` | 18 |
| `groupDrinksCommon` | 18 |
| `groupFoodCommon` | 16 |
| `groupArmorScaled` | 15 |

### `event` — seen 3.8k times
Top literal values:
| Value | Count |
| --- | --- |
| `Harvest` | 1.8k |
| `Destroy` | 1.4k |
| `Fall` | 578 |
| `action_pull` | 2 |
| `action_give_gold` | 1 |
| `action_give_points` | 1 |
| `action_give_silver` | 1 |
| `buff_bonusPP_complete` | 1 |
| `buff_rez` | 1 |

### `depth` — seen 3.8k times
Top literal values:
| Value | Count |
| --- | --- |
| `3` | 842 |
| `1` | 808 |
| `2` | 628 |
| `4` | 478 |
| `8` | 263 |
| `0` | 194 |
| `5` | 122 |
| `6` | 107 |
| `10` | 95 |
| `*` | 37 |
| `12` | 27 |
| `7` | 24 |

### `pos` — seen 3.6k times
Top literal values:
| Value | Count |
| --- | --- |
| `0,0` | 399 |
| `6,-6` | 84 |
| `0,-46` | 69 |
| `3,-3` | 59 |
| `-3,3` | 58 |
| `2,0` | 53 |
| `2,-2` | 48 |
| `4,-5` | 48 |
| `255,0` | 43 |
| `0,-50` | 42 |
| `15,-3` | 42 |
| `-1,0` | 34 |

### `type` — seen 3.6k times
Top literal values:
| Value | Count |
| --- | --- |
| `sliced` | 1.0k |
| `block` | 588 |
| `LootItem` | 490 |
| `Item` | 131 |
| `float` | 106 |
| `int` | 106 |
| `attachment` | 104 |
| `prefab` | 103 |
| `Exp` | 84 |
| `filled` | 71 |
| `ComboBoxBool` | 59 |
| `ComboBoxList`1[System.String]` | 47 |

### `cvar` — seen 3.4k times
Top literal values:
| Value | Count |
| --- | --- |
| `infectionCounter` | 124 |
| `$foodAmountAdd` | 76 |
| `bleedCounter` | 76 |
| `nerdPointChance` | 69 |
| `$minerHealing` | 66 |
| `foodHealthAmount` | 66 |
| `$DesertHazardTimer` | 60 |
| `$SnowHazardTimer` | 60 |
| `$BurntHazardTimer` | 55 |
| `$WastelandHazardTimer` | 55 |
| `abrasionZombieHit` | 54 |
| `$minerCheck` | 52 |

### `height` — seen 3.3k times
Top literal values:
| Value | Count |
| --- | --- |
| `32` | 464 |
| `30` | 324 |
| `43` | 262 |
| `36` | 99 |
| `46` | 88 |
| `48` | 85 |
| `28` | 77 |
| `${height}` | 66 |
| `24` | 66 |
| `40` | 65 |
| `33` | 64 |
| `35` | 63 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{height}` | 5 |
| `{window_height}` | 3 |
| `{# 0+grid_height}` | 2 |
| `{# 6+grid_height}` | 2 |
| `{trackerheight}` | 2 |
| `{# questsautoaccept ? 598 : 368}` | 1 |
| `{# questsautoaccept ? 694 : 464}` | 1 |
| `{# questsautoaccept ? 735 : 505}` | 1 |
| `{commandsheight}` | 1 |
| `{thumb_size}` | 1 |

### `width` — seen 3.1k times
Top literal values:
| Value | Count |
| --- | --- |
| `200` | 165 |
| `300` | 117 |
| `250` | 105 |
| `350` | 77 |
| `${width}` | 65 |
| `100` | 58 |
| `24` | 56 |
| `400` | 55 |
| `150` | 54 |
| `560` | 47 |
| `${width-4}` | 42 |
| `750` | 40 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{grid_width}` | 3 |
| `{windowWidth}` | 3 |
| `{# 0+grid_width }` | 2 |
| `{# 6+grid_width }` | 2 |
| `{# ceiling( (${width} - (ceiling(dlc_count / ${per_page}) - 1) * ${spacing}) / ceiling(dlc_count / ${per_page}) ) }` | 1 |
| `{#grid_width - 60}` | 1 |
| `{objectivetextwidth}` | 1 |
| `{width_16_10}` | 1 |
| `{width_16_9}` | 1 |
| `{width_3_2}` | 1 |
| `{width_4_3}` | 1 |
| `{width_5_4}` | 1 |

### `class` — seen 3.1k times
Top literal values:
| Value | Count |
| --- | --- |
| `Action0` | 747 |
| `RepairItems` | 382 |
| `UpgradeBlock` | 283 |
| `PlaySound` | 212 |
| `Action1` | 118 |
| `SDCS` | 108 |
| `RandomRoll` | 78 |
| `AddBuff` | 65 |
| `SpawnEntity` | 61 |
| `AddPartyToGroup` | 53 |
| `Delay` | 48 |
| `RepairItemsMeshDamage` | 36 |

### `level` — seen 2.9k times
Top literal values:
| Value | Count |
| --- | --- |
| `-1` | 426 |
| `1` | 304 |
| `1,5` | 163 |
| `2,6` | 144 |
| `2` | 121 |
| `3` | 121 |
| `5` | 119 |
| `4` | 117 |
| `6` | 116 |
| `2,3,4,5,6` | 64 |
| `5,6` | 64 |
| `3,4,5,6` | 60 |

### `duration` — seen 2.4k times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1.3k |
| `2` | 614 |
| `10` | 163 |
| `0,3` | 139 |
| `9` | 50 |
| `0,6` | 17 |
| `0,4` | 13 |
| `0,5` | 9 |
| `0,8` | 9 |
| `@stunBatonDuration` | 8 |
| `0,12,16` | 7 |
| `0,8,14,18` | 7 |

### `num` — seen 2.1k times
Top literal values:
| Value | Count |
| --- | --- |
| `500` | 522 |
| `999` | 321 |
| `300` | 196 |
| `17` | 22 |
| `19` | 22 |
| `16` | 21 |
| `18` | 20 |
| `20` | 19 |
| `23` | 17 |
| `38` | 17 |
| `26` | 16 |
| `21` | 15 |

### `maxAlive` — seen 2.1k times
Top literal values:
| Value | Count |
| --- | --- |
| `256` | 1.2k |
| `30` | 57 |
| `2` | 22 |
| `6` | 13 |
| `9` | 12 |
| `3` | 11 |
| `5` | 11 |
| `11` | 9 |
| `13` | 9 |
| `20` | 9 |
| `1` | 8 |
| `119` | 8 |

### `buff` — seen 2.0k times
Top literal values:
| Value | Count |
| --- | --- |
| `buffProcessConsumables` | 78 |
| `buffFarmerSetBonus` | 54 |
| `buffIsOnFire` | 52 |
| `buffInjuryBleeding` | 47 |
| `buffFatiguedTrigger,buffArmSprainedCHTrigger,buffLegSprainedCHTrigger,buffLaceration,buffAbrasionCatch,buffInjuryStunned01CHTrigger,buffInjuryBleedingTwo` | 44 |
| `god` | 42 |
| `buffLegCast` | 36 |
| `buffLegSplinted` | 36 |
| `buffArmCast` | 34 |
| `buffArmSplinted` | 34 |
| `buffRadiatedRegen` | 32 |
| `buffArmBroken` | 27 |

### `tag` — seen 1.9k times
Top literal values:
| Value | Count |
| --- | --- |
| `allHarvest,perkJunkMiner` | 607 |
| `salvageHarvest` | 580 |
| `PercMasteryDukeHarvest` | 94 |
| `allHarvest,lumberjackHarvest,perkJunkMiner` | 86 |
| `butcherHarvest` | 86 |
| `oreWoodHarvest` | 75 |
| `Bulletproof` | 63 |
| `oreWoodHarvest,lumberjackHarvest` | 51 |
| `PercMasterySteelHarvest` | 31 |
| `bonusCropHarvest` | 31 |
| `farmerBonusHarvest` | 31 |
| `WasteTreasuresAcidHarvest` | 24 |

### `Subtitle` — seen 1.9k times
Top literal values:
| Value | Count |
| --- | --- |
| `trader_jen_announce_closed_01` | 2 |
| `trader_jen_announce_closed_02` | 2 |
| `trader_jen_announce_closed_03` | 2 |
| `trader_jen_announce_closing_01` | 2 |
| `trader_jen_announce_closing_02` | 2 |
| `trader_jen_announce_closing_03` | 2 |
| `trader_jen_announce_open_01` | 2 |
| `trader_jen_announce_open_02` | 2 |
| `trader_jen_announce_open_03` | 2 |
| `trader_jen_announce_special_01` | 2 |
| `trader_jen_announce_special_02` | 2 |
| `trader_jen_announce_special_03` | 2 |

### `param1` — seen 1.9k times
Top literal values:
| Value | Count |
| --- | --- |
| `CustomIcon` | 301 |
| `DescriptionKey` | 166 |
| `25` | 61 |
| `1` | 58 |
| `RepairItems` | 42 |
| `zombiename` | 42 |
| `21` | 41 |
| `RepairItems,CustomIcon` | 37 |
| `Class,LootList,DowngradeBlock` | 34 |
| `Path` | 33 |
| `DowngradeBlock` | 31 |
| `Class,DescriptionKey` | 29 |

### `stage` — seen 1.8k times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 198 |
| `400` | 24 |
| `50` | 24 |
| `100` | 23 |
| `200` | 23 |
| `800` | 23 |
| `419` | 6 |
| `488` | 6 |
| `524` | 6 |
| `8` | 6 |
| `13` | 5 |
| `27` | 5 |

### `color` — seen 1.7k times
Top literal values:
| Value | Count |
| --- | --- |
| `[black]` | 469 |
| `[darkGrey]` | 218 |
| `[white]` | 217 |
| `[mediumGrey]` | 98 |
| `[lightGrey]` | 45 |
| `[selectedColor]` | 45 |
| `[black_half_alpha]` | 34 |
| `0,0,0,255` | 31 |
| `0,0,0,150` | 27 |
| `[beige]` | 25 |
| `[darkestGrey]` | 24 |
| `[iconColor]` | 19 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{statuscolor}` | 12 |
| `{color_fg}` | 11 |
| `{iconcolor}` | 11 |
| `{rowstatecolor}` | 10 |
| `{durabilitycolor}` | 8 |
| `{selectionbordercolor}` | 8 |
| `{itemtypeicontint}` | 7 |
| `{itemicontint}` | 6 |
| `{backgroundcolor}` | 4 |
| `{color_bg}` | 4 |
| `{textcolor}` | 4 |
| `{votecolor}` | 4 |

### `time` — seen 1.7k times
Top literal values:
| Value | Count |
| --- | --- |
| `3` | 867 |
| `2` | 232 |
| `60` | 155 |
| `30` | 96 |
| `1` | 72 |
| `300` | 33 |
| `90` | 27 |
| `Night` | 27 |
| `4` | 25 |
| `1.5` | 22 |
| `Day` | 19 |
| `360` | 17 |

### `id` — seen 1.6k times
Top literal values:
| Value | Count |
| --- | --- |
| `groupQuestMedical,groupQuestAmmo,groupQuestSchematics` | 88 |
| `groupChallengeRewardSkillMagazinesAll` | 52 |
| `groupQuestMedical,groupQuestAmmo,groupQuestSchematics,groupQuestMods` | 52 |
| `casinoCoin` | 48 |
| `groupQuestFood,groupQuestAmmo,groupQuestSchematics` | 38 |
| `groupQuestResourcesT0` | 23 |
| `groupQuestResourcesT1,groupQuestT1SkillMagazineBundle` | 23 |
| `perkBooks` | 19 |
| `schematicsModsAndGeneralCommon` | 19 |
| `groupQuestFood,groupQuestAmmo,groupQuestSchematics,groupQuestMods` | 18 |
| `groupQuestResourcesT0,groupQuestT1SkillMagazineBundle` | 18 |
| `nevermind` | 14 |

### `progression_name` — seen 1.5k times
Top literal values:
| Value | Count |
| --- | --- |
| `perkPhysician` | 118 |
| `attAgility` | 50 |
| `attFortitude` | 50 |
| `attIntellect` | 50 |
| `attPerception` | 50 |
| `attStrength` | 50 |
| `perkIntellectMastery` | 47 |
| `perkStrengthMastery` | 46 |
| `perkPenetrator` | 36 |
| `perkDeepCuts` | 28 |
| `perkAnimalTracker` | 21 |
| `perkFiremansAlmanacMolotov` | 16 |

### `loot_prob_template` — seen 1.4k times
Top literal values:
| Value | Count |
| --- | --- |
| `low` | 339 |
| `med` | 283 |
| `high` | 189 |
| `veryLow` | 180 |
| `medLow` | 81 |
| `medHigh` | 63 |
| `ProbT0` | 43 |
| `ProbT1` | 35 |
| `ProbT2Cap` | 35 |
| `ProbT1Cap` | 30 |
| `QuestT2Prob` | 30 |
| `ProbT3` | 29 |

### `contentLocId` — seen 1.3k times
Top literal values:
| Value | Count |
| --- | --- |
| `trader_bob_announce_closed_01` | 1 |
| `trader_bob_announce_closed_02` | 1 |
| `trader_bob_announce_closed_03` | 1 |
| `trader_bob_announce_closing_01` | 1 |
| `trader_bob_announce_closing_02` | 1 |
| `trader_bob_announce_closing_03` | 1 |
| `trader_bob_announce_open_01` | 1 |
| `trader_bob_announce_open_02` | 1 |
| `trader_bob_announce_open_03` | 1 |
| `trader_bob_announce_special_01` | 1 |
| `trader_bob_announce_special_02` | 1 |
| `trader_bob_announce_special_03` | 1 |

### `speakerColor` — seen 1.3k times
Top literal values:
| Value | Count |
| --- | --- |
| `traders` | 1.3k |

### `speakerLocId` — seen 1.3k times
Top literal values:
| Value | Count |
| --- | --- |
| `subtitleSpeaker_Trader_Hugh` | 274 |
| `subtitleSpeaker_Trader_Rekt` | 271 |
| `subtitleSpeaker_Trader_Joel` | 265 |
| `subtitleSpeaker_Trader_Jen` | 264 |
| `subtitleSpeaker_Trader_Bob` | 262 |

### `sprite` — seen 1.3k times
Top literal values:
| Value | Count |
| --- | --- |
| `menu_empty3px` | 496 |
| `menu_empty` | 141 |
| `menu_empty2px` | 58 |
| `ui_game_symbol_search` | 39 |
| `ui_game_symbol_unlock` | 25 |
| `ui_game_symbol_check` | 19 |
| `ui_game_symbol_skull` | 18 |
| `ui_game_symbol_gas` | 17 |
| `ui_game_symbol_x` | 15 |
| `ui_game_symbol_players` | 14 |
| `ui_game_symbol_lock` | 12 |
| `ui_game_symbol_electric_switch` | 11 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{categoryicon|once}` | 15 |
| `{itemicon}` | 13 |
| `{groupicon}` | 6 |
| `{rowstatesprite}` | 5 |
| `{rewardicon}` | 4 |
| `{staticon|once}` | 4 |
| `{actionicon}` | 3 |
| `{bufficon|once}` | 3 |
| `{buyicon}` | 3 |
| `{iconname}` | 3 |
| `{questicon}` | 3 |
| `{stacklockicon}` | 3 |

### `quality` — seen 1.3k times
Top literal values:
| Value | Count |
| --- | --- |
| `4` | 257 |
| `2` | 235 |
| `3` | 233 |
| `5` | 224 |
| `1` | 213 |
| `1,5` | 110 |
| `0` | 29 |
| `2,5` | 7 |
| `6` | 2 |

### `noise` — seen 1.3k times
Top literal values:
| Value | Count |
| --- | --- |
| `7` | 409 |
| `11` | 353 |
| `30` | 193 |
| `60` | 88 |
| `10` | 35 |
| `6` | 22 |
| `3` | 19 |
| `15` | 18 |
| `5` | 14 |
| `8` | 13 |
| `20` | 11 |
| `4` | 11 |

### `ID` — seen 1.2k times
Top literal values:
| Value | Count |
| --- | --- |
| `2` | 428 |
| `1` | 383 |
| `3` | 188 |
| `0` | 127 |
| `4` | 89 |
| `6` | 13 |
| `5` | 8 |

### `pivot` — seen 1.1k times
Top literal values:
| Value | Count |
| --- | --- |
| `center` | 469 |
| `topleft` | 243 |
| `left` | 226 |
| `right` | 67 |
| `Left` | 59 |
| `topLeft` | 23 |
| `topright` | 18 |
| `${pivot}` | 8 |
| `bottom` | 8 |
| `bottomleft` | 8 |
| `TopLeft` | 7 |
| `Right` | 5 |

### `muffled_when_crouched` — seen 1.1k times
Top literal values:
| Value | Count |
| --- | --- |
| `0.5` | 686 |
| `0.65` | 191 |
| `0.507` | 190 |
| `0.8` | 29 |
| `0.7` | 7 |
| `.5` | 1 |
| `0.45` | 1 |

### `desc_key` — seen 903 times
Top literal values:
| Value | Count |
| --- | --- |
| `reqGenericPoints01` | 26 |
| `reqGenericPoints02` | 15 |
| `reqAgilityLevel10` | 10 |
| `reqFortitudeLevel10` | 10 |
| `reqGenericPoints03` | 10 |
| `reqIntellectLevel10` | 10 |
| `reqFortitudeLevel07` | 9 |
| `reqAgilityLevel07` | 8 |
| `reqFortitudeLevel01` | 8 |
| `reqFortitudeLevel03` | 8 |
| `reqFortitudeLevel05` | 8 |
| `reqPerceptionLevel01` | 8 |

### `extends` — seen 872 times
Top literal values:
| Value | Count |
| --- | --- |
| `twitch_crate_template` | 72 |
| `twitch_spawnWeapon1` | 48 |
| `Burn_PartyGirl` | 34 |
| `Radiation_PartyGirl` | 34 |
| `Shield_Boss_PartyGirl` | 34 |
| `Shield_Minion_PartyGirl` | 34 |
| `Shock_PartyGirl` | 34 |
| `Weapon_PartyGirl` | 34 |
| `armorLight` | 25 |
| `Minor_PartyGirls` | 24 |
| `armorMediumNew` | 24 |
| `twitch_normalZombie` | 23 |

### `blockname` — seen 829 times
Top literal values:
| Value | Count |
| --- | --- |
| `terrStone` | 44 |
| `terrGravel` | 39 |
| `terrBedrock` | 37 |
| `resourceRock02` | 34 |
| `terrDirt` | 29 |
| `resourceRock01` | 27 |
| `rock01` | 26 |
| `rock02` | 26 |
| `cntBirdnest` | 25 |
| `treeDeadPineLeaf` | 24 |
| `plantShrubDead` | 22 |
| `treeBrownGrassDiagonal` | 22 |

### `tiered` — seen 824 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 824 |

### `font_size` — seen 811 times
Top literal values:
| Value | Count |
| --- | --- |
| `28` | 206 |
| `26` | 183 |
| `32` | 159 |
| `24` | 80 |
| `30` | 67 |
| `34` | 20 |
| `20` | 18 |
| `22` | 16 |
| `36` | 14 |
| `${height-4}` | 13 |
| `40` | 11 |
| `42` | 4 |

### `icon` — seen 762 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_armor_iron` | 24 |
| `ui_game_symbol_zombie` | 17 |
| `ui_game_symbol_crops` | 16 |
| `ui_game_symbol_quest` | 16 |
| `ui_game_symbol_mining` | 15 |
| `ui_game_symbol_critical` | 13 |
| `ui_game_symbol_medical` | 13 |
| `ui_game_symbol_radiation` | 13 |
| `ui_game_symbol_stunned` | 13 |
| `ui_game_symbol_hammer` | 12 |
| `ui_game_symbol_pills` | 11 |
| `ui_game_symbol_brokenbone` | 8 |

### `style` — seen 746 times
Top literal values:
| Value | Count |
| --- | --- |
| `icon32px` | 127 |
| `header.name` | 114 |
| `hover` | 107 |
| `icon30px` | 68 |
| `icon32px, press, hover` | 56 |
| `icon30px, press` | 33 |
| `press, hover, scroll` | 31 |
| `outline` | 28 |
| `icon22px` | 16 |
| `icon30px, press, hover` | 16 |
| `press` | 16 |
| `press, hover` | 13 |

### `title_key` — seen 745 times
Top literal values:
| Value | Count |
| --- | --- |
| `statDuration` | 31 |
| `statBlockDamage` | 24 |
| `statFoodAmount` | 22 |
| `statDegradationMax` | 18 |
| `statWaterAmount` | 18 |
| `statEntityDamageRanged` | 17 |
| `statHealthAmount` | 15 |
| `statMaxDamage` | 14 |
| `statStabilityGlue` | 14 |
| `statDamageFalloffRange` | 13 |
| `statEntityDamageMelee` | 12 |
| `statAttacksPerMinute` | 11 |

### `template` — seen 742 times
Top literal values:
| Value | Count |
| --- | --- |
| `spawn_crate_template` | 120 |
| `vote_horde_buffed` | 111 |
| `spawn_single` | 71 |
| `vote_minor` | 55 |
| `vote_horde_immortal_boss` | 37 |
| `vote_horde_immortal_minion` | 37 |
| `vote_horde_weapon` | 37 |
| `challengegroup_reward_homesteading` | 34 |
| `minor_crate` | 32 |
| `buff_template` | 25 |
| `buff_template_hasbuff` | 20 |
| `vote_utility_template` | 20 |

### `target` — seen 721 times
Top literal values:
| Value | Count |
| --- | --- |
| `other` | 596 |
| `self` | 86 |
| `instigator` | 18 |
| `otherAOE` | 10 |
| `selfOtherPlayers` | 6 |
| `positionAOE` | 3 |
| `selfAOE` | 1 |
| `treeSnowyGrassDiagonal` | 1 |

### `justify` — seen 708 times
Top literal values:
| Value | Count |
| --- | --- |
| `right` | 284 |
| `left` | 217 |
| `center` | 189 |
| `Left` | 5 |
| `${justify}` | 2 |
| `Center` | 2 |
| `Right` | 2 |
| `${align_right ? 'right' : 'left'}` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{#hasdurability ? 'Center' : 'Right'}` | 4 |
| `{durabilityjustify}` | 2 |

### `text` — seen 698 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 16 |
| `dialog_trader_response_jobshave` | 8 |
| `dialog_trader_statement_currentjobs` | 7 |
| `Test` | 6 |
| `PLAYERS` | 5 |
| `dialog_trader_response_nevermind` | 5 |
| `dialog_trader_response_nexttier` | 5 |
| `dialog_trader_response_prevtier` | 5 |
| `${caption}` | 4 |
| `${textcontent}` | 4 |
| `${valuecontent}` | 4 |
| `--` | 4 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{name}` | 23 |
| `{entrydescription}` | 10 |
| `{text}` | 10 |
| `{groupname}` | 9 |
| `{itemname}` | 6 |
| `{level}` | 6 |
| `{displayname}` | 5 |
| `{groupdescription}` | 5 |
| `{savename}` | 5 |
| `{statcurrentwithmax}` | 5 |
| `{currentlevel} {skillLevel} / {maxSkillLevel}` | 4 |
| `{distance}` | 4 |

### `visible` — seen 686 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 25 |
| `${visible|true}` | 21 |
| `${visible}` | 19 |
| `true` | 16 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{hasentry}` | 39 |
| `{hasdurability}` | 18 |
| `{discord_is_ready}` | 11 |
| `{onlyconnected}` | 9 |
| `{statvisible}` | 8 |
| `{has_loaded_prefab}` | 7 |
| `{hasitemtypeicon}` | 7 |
| `{showfuel}` | 7 |
| `{# !isprefilteredsearch}` | 6 |
| `{isnormal}` | 6 |
| `{showempty}` | 6 |
| `{isfavorite}` | 5 |

### `tier` — seen 682 times
Top literal values:
| Value | Count |
| --- | --- |
| `1,6` | 281 |
| `1,2,3,4,5,6` | 243 |
| `2,6` | 122 |
| `2` | 6 |
| `3` | 6 |
| `4` | 6 |
| `5` | 6 |
| `6` | 6 |
| `1` | 5 |
| `7` | 1 |

### `interval` — seen 660 times
Top literal values:
| Value | Count |
| --- | --- |
| `17` | 41 |
| `16` | 38 |
| `20` | 38 |
| `18` | 37 |
| `10` | 35 |
| `11` | 34 |
| `13` | 32 |
| `21` | 32 |
| `19` | 30 |
| `23` | 30 |
| `22` | 29 |
| `28` | 29 |

### `fillcenter` — seen 617 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 471 |
| `true` | 146 |

### `sound` — seen 594 times
Top literal values:
| Value | Count |
| --- | --- |
| `[paging_click]` | 133 |
| `read_skillbook_final` | 133 |
| `twitch_bad_buff_ended` | 45 |
| `[recipe_click]` | 41 |
| `twitch_good_buff_ended` | 28 |
| `buff_stunned` | 24 |
| `nerd_outfit_perk` | 23 |
| `player#painsm` | 13 |
| `[craft_click]` | 12 |
| `[default_click]` | 11 |
| `flashlight_toggle` | 10 |
| `player#painlg` | 8 |

### `ischosen` — seen 574 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 574 |

### `controller` — seen 568 times
Top literal values:
| Value | Count |
| --- | --- |
| `TabSelectorTab` | 51 |
| `CategoryList` | 20 |
| `TabSelectorButton` | 16 |
| `CategoryEntry` | 15 |
| `TabSelector` | 12 |
| `HUDStatBar` | 8 |
| `ContainerStandardControls` | 5 |
| `ItemActionList` | 5 |
| `RequiredItemStack` | 5 |
| `XUiC_WorkstationWindowGroup` | 5 |
| `LevelToolsGenericWindow` | 4 |
| `MapPopupEntry` | 4 |

### `name_key` — seen 546 times
Top literal values:
| Value | Count |
| --- | --- |
| `trigger` | 11 |
| `skillCombatPerksName` | 5 |
| `TwitchBuff_NoVehicle` | 4 |
| `buffInjuryStunned01Name` | 4 |
| `demoTimerStart` | 4 |
| `buffDysentery01UntreatedName` | 3 |
| `buffRadiation03Name` | 3 |
| `TwitchBuff_Celebrate` | 2 |
| `TwitchBuff_Deafen` | 2 |
| `TwitchBuff_Energize` | 2 |
| `TwitchBuff_HomerunDerby` | 2 |
| `TwitchBuff_JumbledBackpack` | 2 |

### `long_desc_key` — seen 523 times
Top literal values:
| Value | Count |
| --- | --- |
| `perkBookGroupLongDesc` | 19 |
| `General_TestLongDesc` | 1 |
| `attAgilityRank01LongDesc` | 1 |
| `attAgilityRank02LongDesc` | 1 |
| `attAgilityRank03LongDesc` | 1 |
| `attAgilityRank04LongDesc` | 1 |
| `attAgilityRank05LongDesc` | 1 |
| `attAgilityRank06LongDesc` | 1 |
| `attAgilityRank07LongDesc` | 1 |
| `attAgilityRank08LongDesc` | 1 |
| `attAgilityRank09LongDesc` | 1 |
| `attAgilityRank10LongDesc` | 1 |

### `tool_category` — seen 515 times
Top literal values:
| Value | Count |
| --- | --- |
| `Disassemble` | 492 |
| `Butcher` | 23 |

### `text_key` — seen 499 times
Top literal values:
| Value | Count |
| --- | --- |
| `xuiPrefabGroupsAddLabel` | 5 |
| `${caption_key}` | 4 |
| `${title}` | 4 |
| `xuiSkillUnlocks` | 4 |
| `xuiCosmetics` | 3 |
| `xuiDmLastPlayed` | 3 |
| `xuiDmName` | 3 |
| `xuiLevel` | 3 |
| `xuiModifiers` | 3 |
| `xuiSteamID` | 3 |
| `xuiTools` | 3 |
| `xuiTurnOn` | 3 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{leftbuttontext}` | 2 |
| `{rightbuttontext}` | 2 |
| `{# prefab_name_exists ? localization('xuiPrefabAlreadyExists') : localization('xuiInvalidPrefabName') }` | 1 |
| `{#owned ? 'xuiDlcOwned' : 'xuiDlcViewInStore'}` | 1 |
| `{cosmeticname}` | 1 |
| `{langKeyBody}` | 1 |
| `{langKeyTitle}` | 1 |
| `{title}` | 1 |
| `{titlename}` | 1 |

### `display_type` — seen 477 times
Top literal values:
| Value | Count |
| --- | --- |
| `Percent` | 139 |
| `Decimal1` | 85 |
| `Time` | 35 |
| `Bool` | 18 |
| `Decimal2` | 12 |
| `` | 1 |
| `adminRanged` | 1 |
| `ammoArrow` | 1 |
| `ammoArrowAP` | 1 |
| `ammoArrowExploding` | 1 |
| `ammoArrowFlaming` | 1 |
| `ammoBullet` | 1 |

### `rotatemax` — seen 466 times
Top literal values:
| Value | Count |
| --- | --- |
| `7` | 272 |
| `3` | 194 |

### `description_key` — seen 461 times
Top literal values:
| Value | Count |
| --- | --- |
| `TwitchBuff_NoVehicleDesc` | 4 |
| `buffInjuryStunned01Desc` | 4 |
| `demoTimerStartDesc` | 4 |
| `buffRadiation03Desc` | 3 |
| `TwitchBuff_BlurDesc` | 2 |
| `TwitchBuff_CelebrateDesc` | 2 |
| `TwitchBuff_DeafenDesc` | 2 |
| `TwitchBuff_EnergizeDesc` | 2 |
| `TwitchBuff_HomerunDerbyDesc` | 2 |
| `TwitchBuff_JumbledBackpackDesc` | 2 |
| `TwitchBuff_ShieldDesc` | 2 |
| `TwitchBuff_SillySoundsDesc` | 2 |

### `stick_chance` — seen 459 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 386 |
| `0` | 69 |
| `0.5` | 4 |

### `loot_quality_template` — seen 396 times
Top literal values:
| Value | Count |
| --- | --- |
| `qualBaseTemplate` | 309 |
| `qualPlus1Template` | 23 |
| `QLTemplateT0` | 14 |
| `QLTemplateT1` | 12 |
| `QLTemplateT2` | 9 |
| `QLTemplateT3` | 8 |
| `questT1QualTemplate` | 4 |
| `questT2QualTemplate` | 4 |
| `qualPrimitiveItemsTemplate` | 2 |
| `qualTwitchT5Template` | 2 |
| `questT3QualTemplate` | 2 |
| `armorQualityTemplate` | 1 |

### `craft_area` — seen 391 times
Top literal values:
| Value | Count |
| --- | --- |
| `workbench` | 294 |
| `campfire` | 42 |
| `forge` | 32 |
| `chemistryStation` | 18 |
| `cementMixer` | 5 |

### `size` — seen 389 times
Top literal values:
| Value | Count |
| --- | --- |
| `6,2` | 217 |
| `6,4` | 24 |
| `6,3` | 21 |
| `6,1` | 17 |
| `7,4` | 14 |
| `8,9` | 14 |
| `35,35` | 10 |
| `8,4` | 9 |
| `24,24` | 8 |
| `40,40` | 5 |
| `28,28` | 3 |
| `38,38` | 3 |

### `tooltip_key` — seen 369 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 11 |
| `${tooltip_key == '' ? title + 'Desc' : tooltip_key}` | 10 |
| `lblToggleActive` | 10 |
| `${tooltip_key}` | 8 |
| `lblShowOnMap` | 5 |
| `xuiAttachScreenshotTooltip` | 4 |
| `lblClearInventory` | 3 |
| `lblFavorites` | 3 |
| `lblSortContainer` | 3 |
| `xuiPlayersReportPlayer` | 3 |
| `xuiStashLockModeToggle` | 3 |
| `${tooltip_key == '' ? 'xuiOptionsGeneral' + name + 'Tooltip' : tooltip_key}` | 2 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{crossplayTooltip}` | 3 |
| `{# discord_in_call ? '' : 'xuiOptionsAudioDiscordNotInCall' }` | 1 |
| `{#has_downgrade ? format(localization('xuiShapeMaterialDowngrade'), downgrade_material) : ''}` | 1 |
| `{#has_upgrade ? format(localization('xuiShapeMaterialUpgrade'), upgrade_material) : ''}` | 1 |
| `{comment}` | 1 |
| `{customnamewarning}` | 1 |
| `{customsizewarning}` | 1 |

### `data` — seen 354 times
Top literal values:
| Value | Count |
| --- | --- |
| `type=blade+target=leftforearmroll+atp=true+detach=true+mask=true` | 30 |
| `type=blade+target=neck+atp=true+detach=true;type=blunt+target=neck+atp=true` | 30 |
| `type=blade+target=rightforearmroll+atp=true+detach=true+mask=true` | 30 |
| `type=blade+target=leftarmroll+atp=true+detach=true+mask=true` | 28 |
| `type=blade+target=rightarmroll+atp=true+detach=true+mask=true` | 28 |
| `DismemberTag_L_LeftLowerLegGore` | 19 |
| `DismemberTag_L_RightLowerLegGore` | 19 |
| `type=blade+target=leftleg+detach=true+mask=true` | 18 |
| `type=blade+target=rightleg+detach=true+mask=true` | 18 |
| `DismemberTag_L_LeftUpperLegGore` | 14 |
| `DismemberTag_L_RightUpperLegGore` | 14 |
| `type=blade+target=leftupleg+detach=true+mask=true` | 12 |

### `sound_close` — seen 335 times
Top literal values:
| Value | Count |
| --- | --- |
| `SupplyDrops/close_supply_crate` | 139 |
| `UseActions/close_backpack` | 16 |
| `UseActions/close_chest` | 15 |
| `silencefiller` | 14 |
| `UseActions/close_cardboard` | 11 |
| `UseActions/close_garbage` | 11 |
| `UseActions/close_vehicle` | 10 |
| `UseActions/close_fridge` | 9 |
| `UseActions/close_safe` | 9 |
| `UseActions/close_cooler` | 8 |
| `UseActions/close_drawer` | 6 |
| `UseActions/close_file_cabinet` | 6 |

### `sound_open` — seen 335 times
Top literal values:
| Value | Count |
| --- | --- |
| `SupplyDrops/open_supply_crate` | 139 |
| `UseActions/open_garbage` | 26 |
| `UseActions/open_backpack` | 16 |
| `UseActions/open_chest` | 14 |
| `UseActions/open_cardboard` | 11 |
| `UseActions/open_vehicle` | 10 |
| `UseActions/open_cooler` | 9 |
| `UseActions/open_fridge` | 9 |
| `UseActions/open_safe` | 9 |
| `UseActions/open_drawer` | 6 |
| `UseActions/open_file_cabinet` | 6 |
| `UseActions/open_shopping_basket` | 6 |

### `heat_map_strength` — seen 330 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.05` | 182 |
| `0.2` | 85 |
| `0.5` | 9 |
| `0.65` | 8 |
| `1.0` | 7 |
| `5` | 7 |
| `0.6` | 6 |
| `0.75` | 6 |
| `0.9` | 6 |
| `2.1` | 3 |
| `0.25` | 2 |
| `0.4` | 2 |

### `heat_map_time` — seen 330 times
Top literal values:
| Value | Count |
| --- | --- |
| `60` | 194 |
| `90` | 95 |
| `180` | 32 |
| `300` | 7 |
| `120` | 1 |
| `45` | 1 |

### `default_quality` — seen 322 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 309 |
| `2` | 4 |
| `3` | 3 |
| `4` | 3 |
| `5` | 2 |
| `6` | 1 |

### `AltSound` — seen 302 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 302 |

### `exp` — seen 299 times
Top literal values:
| Value | Count |
| --- | --- |
| `50` | 224 |
| `600` | 17 |
| `1800` | 12 |
| `300` | 8 |
| `60` | 6 |
| `100` | 5 |
| `10` | 4 |
| `200` | 4 |
| `900` | 4 |
| `20` | 2 |
| `30` | 2 |
| `10000` | 1 |

### `play_in_head` — seen 283 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 270 |
| `false` | 13 |

### `icon_color` — seen 273 times
Top literal values:
| Value | Count |
| --- | --- |
| `255,175,175` | 68 |
| `255,128,0` | 51 |
| `255,0,0` | 36 |
| `175,175,255` | 32 |
| `0,255,0` | 31 |
| `255,255,255` | 17 |
| `132,0,155` | 9 |
| `255,255,0` | 8 |
| `0,255,255` | 7 |
| `120,180,255` | 4 |
| `200,200,0` | 3 |
| `100,255,100` | 2 |

### `value_wrap` — seen 270 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 246 |
| `true` | 10 |
| `${value_wrap}` | 7 |
| `@DEF` | 7 |

### `parent` — seen 267 times
Top literal values:
| Value | Count |
| --- | --- |
| `attCrafting` | 23 |
| `attBooks` | 19 |
| `skillArchery` | 8 |
| `skillArtOfMining` | 8 |
| `skillAutoWeapons` | 8 |
| `skillBarBrawling` | 8 |
| `skillBatterUp` | 8 |
| `skillEnforcer` | 8 |
| `skillFiremansAlmanac` | 8 |
| `skillGreatHeist` | 8 |
| `skillHuntingJournal` | 8 |
| `skillLuckyLooter` | 8 |

### `skill_name` — seen 266 times
Top literal values:
| Value | Count |
| --- | --- |
| `skillArchery` | 14 |
| `skillArtOfMining` | 14 |
| `skillAutoWeapons` | 14 |
| `skillBarBrawling` | 14 |
| `skillBatterUp` | 14 |
| `skillEnforcer` | 14 |
| `skillFiremansAlmanac` | 14 |
| `skillGreatHeist` | 14 |
| `skillHuntingJournal` | 14 |
| `skillLuckyLooter` | 14 |
| `skillNightStalker` | 14 |
| `skillPistolPete` | 14 |

### `cell_height` — seen 251 times
Top literal values:
| Value | Count |
| --- | --- |
| `45` | 41 |
| `34` | 27 |
| `43` | 22 |
| `75` | 19 |
| `30` | 18 |
| `36` | 17 |
| `46` | 15 |
| `60` | 13 |
| `40` | 12 |
| `28` | 10 |
| `32` | 9 |
| `42` | 5 |

### `caption_key` — seen 247 times
Top literal values:
| Value | Count |
| --- | --- |
| `xuiBack` | 21 |
| `xuiCancel` | 20 |
| `xuiOk` | 10 |
| `xuiApply` | 8 |
| `xuiDefaults` | 8 |
| `` | 4 |
| `xuiDefault` | 4 |
| `xuiSubmit` | 4 |
| `btnConfirm` | 3 |
| `btnDelete` | 3 |
| `xuiNewGame` | 3 |
| `xuiSteamPlayOffline` | 3 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{# is_playtesting ? 'xuiDebugMenuPlaytestReset' : 'xuiDebugMenuPlaytest' }` | 1 |
| `{# isprefilteredsearch ? 'xuiNewSearch' : 'xuiBack' }` | 1 |
| `{applyTextKey}` | 1 |
| `{decreasepricetext}` | 1 |
| `{increasepricetext}` | 1 |
| `{langKeyCancel}` | 1 |
| `{langKeyConfirm}` | 1 |
| `{langKeyDiscard}` | 1 |
| `{langKeyManage}` | 1 |

### `cell_width` — seen 243 times
Top literal values:
| Value | Count |
| --- | --- |
| `700` | 21 |
| `75` | 19 |
| `43` | 18 |
| `525` | 16 |
| `390` | 11 |
| `278` | 10 |
| `200` | 9 |
| `300` | 8 |
| `147` | 6 |
| `374` | 6 |
| `141` | 5 |
| `150` | 5 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{grid_width}` | 1 |

### `rows` — seen 234 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 56 |
| `13` | 21 |
| `14` | 21 |
| `2` | 21 |
| `12` | 16 |
| `29` | 15 |
| `5` | 15 |
| `8` | 13 |
| `16` | 9 |
| `6` | 9 |
| `4` | 8 |
| `10` | 7 |

### `destroy_on_close` — seen 233 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 142 |
| `empty` | 91 |

### `max` — seen 233 times
Top literal values:
| Value | Count |
| --- | --- |
| `999999` | 51 |
| `5` | 14 |
| `70` | 14 |
| `25` | 13 |
| `50` | 13 |
| `0` | 11 |
| `100` | 10 |
| `127` | 10 |
| `20` | 9 |
| `60` | 9 |
| `90` | 9 |
| `75` | 8 |

### `biome` — seen 226 times
Top literal values:
| Value | Count |
| --- | --- |
| `desert` | 46 |
| `pine_forest` | 35 |
| `wasteland` | 35 |
| `burnt_forest` | 34 |
| `snow` | 34 |
| `water` | 26 |
| `8` | 4 |
| `9` | 4 |
| `1` | 3 |
| `5` | 3 |
| `underwater` | 2 |

### `repeat_content` — seen 225 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 132 |
| `false` | 93 |

### `globalopacity` — seen 223 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 113 |
| `false` | 110 |

### `item` — seen 223 times
Top literal values:
| Value | Count |
| --- | --- |
| `resourceLeather` | 5 |
| `resourceScrapPolymers` | 5 |
| `resourceArmorCraftingKit` | 4 |
| `resourceCloth` | 4 |
| `armorPrimitiveOutfit` | 3 |
| `resourceCoal` | 3 |
| `resourceRockSmall` | 3 |
| `resourceWood` | 3 |
| `carBattery` | 2 |
| `foodAtomicSmoothie` | 2 |
| `foodBurntSmoothie` | 2 |
| `foodCharredMeat` | 2 |

### `min` — seen 223 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 23 |
| `50` | 20 |
| `35` | 15 |
| `2` | 14 |
| `30` | 13 |
| `0` | 12 |
| `55` | 12 |
| `15` | 11 |
| `18` | 11 |
| `90` | 11 |
| `10` | 10 |
| `25` | 8 |

### `min_max` — seen 216 times
Top literal values:
| Value | Count |
| --- | --- |
| `0,100` | 207 |
| `1,100` | 5 |
| `0,-100` | 2 |
| `0,1` | 1 |
| `0,800` | 1 |

### `seed_type` — seen 216 times
Top literal values:
| Value | Count |
| --- | --- |
| `Random` | 216 |

### `cols` — seen 210 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 108 |
| `2` | 34 |
| `3` | 19 |
| `4` | 14 |
| `5` | 8 |
| `9` | 7 |
| `10` | 5 |
| `7` | 4 |
| `8` | 4 |
| `11` | 2 |
| `12` | 2 |
| `15` | 2 |

### `disableautobackground` — seen 210 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 210 |

### `backgroundcolor` — seen 200 times
Top literal values:
| Value | Count |
| --- | --- |
| `[darkGrey]` | 120 |
| `[darkestGrey]` | 55 |
| `[black]` | 7 |
| `[mediumGrey]` | 7 |
| `[transparent]` | 4 |
| `${backgroundcolor}` | 3 |
| `0,0,0,0` | 1 |
| `96,96,96,160` | 1 |
| `96,96,96,180` | 1 |
| `[black_threequarters_alpha]` | 1 |

### `spawner` — seen 195 times
Top literal values:
| Value | Count |
| --- | --- |
| `zombieFatCopRadiated` | 2 |
| `AbandonedHouseHorde` | 1 |
| `HospitalHorde` | 1 |
| `LabWorkerHorde` | 1 |
| `PrisonHorde` | 1 |
| `SleeperGSList` | 1 |
| `SleeperTestChamberGSList` | 1 |
| `ZombieAllChargedHorde` | 1 |
| `ZombieAllFeralHorde` | 1 |
| `ZombieAllFeralRadiatedHorde` | 1 |
| `ZombieAllInfernalHorde` | 1 |
| `ZombieBadassGSHorde` | 1 |

### `open_time` — seen 193 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.25` | 138 |
| `1` | 24 |
| `4` | 10 |
| `0` | 7 |
| `1.5` | 6 |
| `4:05` | 6 |
| `.2` | 2 |

### `arrangement` — seen 192 times
Top literal values:
| Value | Count |
| --- | --- |
| `vertical` | 131 |
| `horizontal` | 61 |

### `max_level` — seen 188 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 153 |
| `100` | 11 |
| `75` | 10 |
| `0` | 3 |
| `3` | 3 |
| `4` | 3 |
| `10` | 1 |
| `20` | 1 |
| `300` | 1 |
| `5` | 1 |
| `50` | 1 |

### `show_message` — seen 183 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 183 |

### `profanity` — seen 182 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 182 |

### `display_group` — seen 181 times
Top literal values:
| Value | Count |
| --- | --- |
| `groupAttire` | 80 |
| `groupConsumables` | 43 |
| `groupAmmo` | 18 |
| `groupBlocks` | 15 |
| `groupMelee` | 10 |
| `groupRanged` | 9 |
| `modAttire` | 4 |
| `workstationTools` | 2 |

### `foregroundlayer` — seen 180 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 160 |
| `false` | 16 |
| `${foregroundlayer}` | 4 |

### `ignore_loot_abundance` — seen 180 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 180 |

### `prefab` — seen 180 times
Top literal values:
| Value | Count |
| --- | --- |
| `@:Other/Items/Crafting/Metal/IronBucketEmptyPrefab.prefab` | 44 |
| `@:Entities/Lighting/miningHelmetLightSource.prefab` | 6 |
| `@:Entities/Player/{sex}/Gear/Assassin/gear{sex}AssassinPrefab.prefab` | 6 |
| `@:Entities/Player/{sex}/Gear/Biker/gear{sex}BikerPrefab.prefab` | 6 |
| `@:Entities/Player/{sex}/Gear/Commando/gear{sex}CommandoPrefab.prefab` | 6 |
| `@:Entities/Player/{sex}/Gear/Enforcer/gear{sex}Enforcer.prefab` | 6 |
| `@:Entities/Player/{sex}/Gear/Farmer/gear{sex}FarmerPrefab.prefab` | 6 |
| `@:Entities/Player/{sex}/Gear/Fiber/gear{sex}FiberPrefab.prefab` | 6 |
| `@:Entities/Player/{sex}/Gear/Fitness/gear{sex}FitnessPrefab.prefab` | 6 |
| `@:Entities/Player/{sex}/Gear/LumberJack/gear{sex}LumberJackPrefab.prefab` | 6 |
| `@:Entities/Player/{sex}/Gear/Miner/gear{sex}MinerPrefab.prefab` | 6 |
| `@:Entities/Player/{sex}/Gear/Nerd/gear{sex}NerdPrefab.prefab` | 6 |

### `values` — seen 179 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 60 |
| `${values}` | 9 |
| `@DEF` | 7 |
| `25, 33, 50, 67, 75, 100, 125, 150, 175, 200, 300` | 6 |
| `25, 50, 75, 100, 125, 150, 175, 200, 300` | 6 |
| `0, 1, 2, 4, 8, 16, 32, 64, 128, 256` | 4 |
| `1,2,3,4,5,6` | 3 |
| `-1, 1, 2, 3, 4, 5, 6, 7, 8` | 2 |
| `-1, 10, 20, 30, 40, 50, 75, 100` | 2 |
| `-1, 5, 7, 10, 15, 20, 30, 40, 50` | 2 |
| `-1, 8, 18` | 2 |
| `0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 20, 30` | 2 |

### `short_description_key` — seen 175 times
Top literal values:
| Value | Count |
| --- | --- |
| `challengeHuntAnimalsShort` | 2 |
| `challengeBloodMoonSurvive10Short` | 1 |
| `challengeBloodMoonSurvive1Short` | 1 |
| `challengeBloodMoonSurvive5Short` | 1 |
| `challengeBurntCraftReducerShort` | 1 |
| `challengeBurntGatherGearShort` | 1 |
| `challengeBurntHarvestCropShort` | 1 |
| `challengeBurntHarvestOreShort` | 1 |
| `challengeBurntKillZombieShort` | 1 |
| `challengeBurntShelterShort` | 1 |
| `challengeBurntUseReducerShort` | 1 |
| `challengeCraftArrowsShort` | 1 |

### `force_prob` — seen 169 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 169 |

### `title` — seen 169 times
Top literal values:
| Value | Count |
| --- | --- |
| `goBuildCreate` | 7 |
| `goMaxPlayers` | 4 |
| `goAirDropFrequency` | 3 |
| `goBedrollExpiryTime` | 3 |
| `goBiomeProgression` | 3 |
| `goBlockDamageAI` | 3 |
| `goBlockDamageAIBM` | 3 |
| `goBlockDamagePlayer` | 3 |
| `goBloodMoonEnemyCount` | 3 |
| `goBloodMoonFrequency` | 3 |
| `goBloodMoonRange` | 3 |
| `goBloodMoonWarning` | 3 |

### `randomrotation` — seen 166 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 154 |
| `false` | 12 |

### `key` — seen 163 times
Top literal values:
| Value | Count |
| --- | --- |
| `charge` | 59 |
| `LongEffects` | 17 |
| `Secondary` | 14 |
| `PrimarySupporting` | 9 |
| `Primary` | 8 |
| `PrimaryPairable1` | 8 |
| `sledge2ndHit` | 7 |
| `0` | 1 |
| `1` | 1 |
| `2` | 1 |
| `3` | 1 |
| `4` | 1 |

### `location` — seen 162 times
Top literal values:
| Value | Count |
| --- | --- |
| `000aExpLfx.wav` | 1 |
| `000aExpPri.wav` | 1 |
| `000aExpPsp.wav` | 1 |
| `000aExpSec.wav` | 1 |
| `000bExpLfx.wav` | 1 |
| `000bExpPri.wav` | 1 |
| `000bExpPsp.wav` | 1 |
| `000bExpSec.wav` | 1 |
| `000cExpLfx.wav` | 1 |
| `000cExpPri.wav` | 1 |
| `000cExpPsp.wav` | 1 |
| `000cExpSec.wav` | 1 |

### `base_skill_point_cost` — seen 157 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 154 |
| `1` | 3 |

### `parse_actions` — seen 151 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 145 |
| `${parse_actions}` | 3 |
| `false` | 3 |

### `stat` — seen 149 times
Top literal values:
| Value | Count |
| --- | --- |
| `Health` | 64 |
| `Stamina` | 30 |
| `water` | 13 |
| `Food` | 11 |
| `Armor` | 8 |
| `Water` | 8 |
| `health` | 8 |
| `food` | 7 |

### `value_localization_prefix` — seen 149 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 67 |
| `goBlockDamageValue` | 12 |
| `goDay` | 10 |
| `goMinute` | 7 |
| `goLandClaimExpiryTimeValue` | 6 |
| `goPlayer` | 6 |
| `goLandClaimDeadZoneValue` | 4 |
| `${value_localization_prefix}` | 3 |
| `goDayLightLengthValue` | 3 |
| `goEnemie` | 3 |
| `goLandClaimOfflineDurabilityModifierValue` | 3 |
| `goLandClaimOnlineDurabilityModifierValue` | 3 |

### `display_names` — seen 148 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 76 |
| `goDisabled` | 13 |
| `goZMWalk,goZMJog,goZMRun,goZMSprint,goZMNightmare` | 12 |
| `goInfinite` | 6 |
| `goUnlimited` | 5 |
| `goLandClaimNoDeadzone` | 4 |
| `${display_names}` | 3 |
| `goDifficulty1,goDifficulty2,goDifficulty3,goDifficulty4,goDifficulty5,goDifficulty6` | 3 |
| `goLandClaimDecayModeSlow,goLandClaimDecayModeFast,goLandClaimDecayModeNone` | 3 |
| `goNone,goAll,goToolbelt,goBackpack` | 3 |
| `goNone,goAll,goToolbelt,goBackpack,goDeleteAll` | 3 |
| `goNone,goXPOnly,goInjured,goPermaDeath` | 3 |

### `group_name` — seen 148 times
Top literal values:
| Value | Count |
| --- | --- |
| `groupEnforcer` | 26 |
| `groupFarmer` | 14 |
| `groupPreacher` | 12 |
| `groupAssassin` | 8 |
| `groupAthletic` | 8 |
| `groupBiker` | 8 |
| `groupCommando` | 8 |
| `groupLumberjack` | 8 |
| `groupMiner` | 8 |
| `groupNerd` | 8 |
| `groupNomad` | 8 |
| `groupRaider` | 8 |

### `range` — seen 148 times
Top literal values:
| Value | Count |
| --- | --- |
| `0,0` | 20 |
| `98,100` | 10 |
| `75,85` | 7 |
| `65,70` | 6 |
| `1.3` | 5 |
| `50,50` | 5 |
| `50,90` | 5 |
| `35,35` | 4 |
| `40,50` | 4 |
| `90,90` | 4 |
| `90,95` | 4 |
| `1.1` | 3 |

### `upper_case` — seen 148 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 120 |
| `false` | 27 |
| `${upper_case}` | 1 |

### `reward_text_key` — seen 147 times
Top literal values:
| Value | Count |
| --- | --- |
| `challenge_reward_1000xp` | 46 |
| `challenge_reward_2000xp` | 18 |
| `challenge_reward_500xp` | 17 |
| `challenge_reward_5000xp` | 14 |
| `challengeKillRewardReading` | 10 |
| `challenge_reward_2500xp` | 10 |
| `challengeKillRewardMods` | 4 |
| `challenge_reward_10000xp` | 3 |
| `challengeKillRewardLegendary` | 2 |
| `challengeKillRewardRegAmmo` | 2 |
| `Coming Soon` | 1 |
| `challengeKillRewardExplosives` | 1 |

### `reward_event` — seen 144 times
Top literal values:
| Value | Count |
| --- | --- |
| `challenge_reward_1000` | 46 |
| `challenge_reward_2000` | 18 |
| `challenge_reward_500` | 17 |
| `challenge_reward_5000` | 14 |
| `challenge_reward_2500` | 10 |
| `challenge_reward_10000` | 3 |
| `challenge_group_reward_advanced_survival` | 1 |
| `challenge_group_reward_basics` | 1 |
| `challenge_group_reward_burnt` | 1 |
| `challenge_group_reward_crafting` | 1 |
| `challenge_group_reward_desert` | 1 |
| `challenge_group_reward_farmer` | 1 |

### `parent_transform` — seen 143 times
Top literal values:
| Value | Count |
| --- | --- |
| `Head` | 33 |
| `#HeldItemRoot` | 15 |
| `LeftHand` | 10 |
| `RightHand` | 10 |
| `Spine1` | 9 |
| `.body` | 7 |
| `Camera` | 6 |
| `Fuse6` | 6 |
| `Side` | 6 |
| `particle_joint` | 6 |
| `CHICKEN_ Head` | 5 |
| `RABBIT_ Head` | 5 |

### `cursor_area` — seen 142 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 139 |
| `false` | 3 |

### `bordercolor` — seen 141 times
Top literal values:
| Value | Count |
| --- | --- |
| `[black]` | 125 |
| `[transparent]` | 16 |

### `unmodified_lootstage` — seen 138 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 73 |
| `true` | 65 |

### `borderthickness` — seen 129 times
Top literal values:
| Value | Count |
| --- | --- |
| `3` | 78 |
| `0` | 51 |

### `tooltip` — seen 127 times
Top literal values:
| Value | Count |
| --- | --- |
| `ttScrapMetalBrass` | 29 |
| `Toggle Active` | 10 |
| `Stats` | 6 |
| `Show on Map` | 5 |
| `test` | 3 |
| `Description` | 2 |
| `Remove Waypoint` | 2 |
| `ttScrapMetalLead` | 2 |
| `Accept Quest` | 1 |
| `COLLECT` | 1 |
| `Cancel Quest` | 1 |
| `Center on Player` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{categorydisplayname|once}` | 15 |
| `{tooltip}` | 4 |
| `{take_all_tooltip}` | 3 |
| `{versiontooltip}` | 3 |
| `{# format(localization('xuiUiSizeLimitedForAspectRatio'), float(ui_size_limit)) }` | 2 |
| `{buytooltip}` | 2 |
| `{# format(localization ('serverBrowserResultLimitWarningTooltip'), resultlimit) }` | 1 |
| `{# output_muted ? localization('xuiDiscordOtherOutputMuted') : '' }` | 1 |
| `{# voice_muted ? localization('xuiDiscordOtherMicMuted') : '' }` | 1 |
| `{icontooltip}` | 1 |
| `{link}` | 1 |
| `{localizedname}` | 1 |

### `localization_prefix` — seen 123 times
Top literal values:
| Value | Count |
| --- | --- |
| `xuiComboYesNo` | 36 |
| `xuiOptionsVideoPresets` | 13 |
| `xuiComboOnOff` | 12 |
| `` | 10 |
| `${localization_prefix}` | 7 |
| `xuiWorldGeneration` | 6 |
| `xuiTwitchPointGeneration` | 4 |
| `xuiControlBindingsFor` | 2 |
| `xuiOptionsVideoFSRPreset` | 2 |
| `xuiOptionsVideoUpscaler` | 2 |
| `xuiSaveDataLimitOptions` | 2 |
| `xuiSprintLock` | 2 |

### `isfixed` — seen 122 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 122 |

### `anchor` — seen 119 times
Top literal values:
| Value | Count |
| --- | --- |
| `CenterCenter` | 63 |
| `RightTop` | 16 |
| `CenterTop` | 15 |
| `CenterBottom` | 8 |
| `LeftTop` | 8 |
| `LeftBottom` | 4 |
| `RightCenter` | 3 |
| `RightBottom` | 2 |

### `particle` — seen 118 times
Top literal values:
| Value | Count |
| --- | --- |
| `p_onFire` | 19 |
| `p_electric_shock` | 16 |
| `p_fire_flaming_arrow` | 10 |
| `p_sparks_fuse` | 10 |
| `p_twitch_zombie_fire_left` | 7 |
| `p_twitch_zombie_fire_right` | 7 |
| `p_bleeding` | 5 |
| `p_fire_arrow_flaming_cloth` | 5 |
| `p_twitch_zombie_radiation_left` | 5 |
| `p_twitch_zombie_radiation_right` | 5 |
| `p_twitch_zombie_shock_left` | 5 |
| `p_twitch_zombie_shock_right` | 5 |

### `display_leading_plus` — seen 115 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 114 |
| `false` | 1 |

### `hidden` — seen 115 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 112 |
| `false` | 3 |

### `partial_name` — seen 114 times
Top literal values:
| Value | Count |
| --- | --- |
| `rural_outdoor_wedding_01` | 2 |
| `crater_deco_01` | 1 |
| `crater_deco_02` | 1 |
| `crater_deco_03` | 1 |
| `gas_station` | 1 |
| `lot_rural_filler` | 1 |
| `quarry_02` | 1 |
| `rubble_burnt_filler_01` | 1 |
| `rubble_burnt_filler_02` | 1 |
| `rubble_burnt_filler_03` | 1 |
| `rubble_burnt_filler_04` | 1 |
| `rubble_burnt_filler_05` | 1 |

### `random_durability` — seen 112 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 112 |

### `biomeTags` — seen 111 times
Top literal values:
| Value | Count |
| --- | --- |
| `wasteland` | 79 |
| `burntforest` | 26 |
| `desert` | 1 |
| `forest` | 1 |
| `forest,burntforest,snow` | 1 |
| `forest,burntforest,snow, wasteland` | 1 |
| `forest,snow,burntforest` | 1 |
| `snow` | 1 |

### `overflow` — seen 111 times
Top literal values:
| Value | Count |
| --- | --- |
| `resizeheight` | 60 |
| `resizefreely` | 29 |
| `shrinkcontent` | 19 |
| `${overflow}` | 1 |
| `ResizeFreely` | 1 |
| `ShrinkContent` | 1 |

### `backgroundspritename` — seen 105 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_panel_header` | 105 |

### `craft_time` — seen 103 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 20 |
| `360` | 15 |
| `240` | 10 |
| `10` | 7 |
| `25` | 5 |
| `30` | 5 |
| `60` | 5 |
| `12` | 3 |
| `150` | 3 |
| `210` | 3 |
| `270` | 3 |
| `300` | 3 |

### `installable_tags` — seen 103 times
Top literal values:
| Value | Count |
| --- | --- |
| `armor` | 11 |
| `weapon,tool,vehicle,drone` | 10 |
| `armorHead` | 9 |
| `drone` | 7 |
| `armorChest` | 6 |
| `melee` | 5 |
| `weapon,tool` | 5 |
| `club` | 3 |
| `armorFeet` | 2 |
| `barrelAttachments,turretRanged` | 2 |
| `firingMode,turretRanged` | 2 |
| `motorTool` | 2 |

### `modifier_tags` — seen 99 times
Top literal values:
| Value | Count |
| --- | --- |
| `attributeBoost` | 6 |
| `barrelAttachment` | 6 |
| `scope` | 4 |
| `droneWeapon` | 3 |
| `magazine` | 3 |
| `resistance` | 3 |
| `shaft` | 3 |
| `stealth` | 3 |
| `thermal` | 3 |
| `trigger` | 3 |
| `accuracy` | 2 |
| `durability` | 2 |

### `excludes` — seen 96 times
Top literal values:
| Value | Count |
| --- | --- |
| `body` | 32 |
| `feet` | 30 |
| `hands` | 30 |
| `` | 4 |

### `transform_name` — seen 96 times
Top literal values:
| Value | Count |
| --- | --- |
| `body` | 32 |
| `feet` | 32 |
| `hands` | 32 |

### `effect_name` — seen 89 times
Top literal values:
| Value | Count |
| --- | --- |
| `Blur` | 14 |
| `Radiation` | 12 |
| `Drunk` | 11 |
| `Hot` | 10 |
| `Trippy` | 4 |
| `Infected` | 3 |
| `NightVision` | 3 |
| `Cold2` | 2 |
| `Cold3` | 2 |
| `Dark` | 2 |
| `Distortion` | 2 |
| `FadeToBlack` | 2 |

### `intensity` — seen 89 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 50 |
| `1` | 23 |
| `.6` | 5 |
| `0.5` | 4 |
| `0.3` | 3 |
| `.8` | 1 |
| `0.4` | 1 |
| `0.6` | 1 |
| `0.8` | 1 |

### `defaultcolor` — seen 87 times
Top literal values:
| Value | Count |
| --- | --- |
| `[mediumGrey]` | 22 |
| `[darkGrey]` | 16 |
| `[disabledLabelColor]` | 12 |
| `180,180,180` | 11 |
| `[white]` | 11 |
| `0,0,0,1` | 2 |
| `0,0,0,150` | 2 |
| `${defaultcolor}` | 1 |
| `${sprite_color_default}` | 1 |
| `0,0,0,10` | 1 |
| `0,0,0,8` | 1 |
| `0,180,0` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{buycolor}` | 2 |
| `{# output_muted ? '180,0,0,255' : '0,200,0,255'}` | 1 |
| `{# voice_muted ? '180,0,0,255' : '0,200,0,255'}` | 1 |

### `unlock_level` — seen 86 times
Top literal values:
| Value | Count |
| --- | --- |
| `1,2,4,6,8,10` | 13 |
| `11,13,16,19,22,25` | 6 |
| `11,15,20,25,30,35` | 5 |
| `36,43,51,59,67,75` | 5 |
| `26,32,39,46,53,60` | 4 |
| `61,68,76,84,92,100` | 4 |
| `11,20,40,60,80,100` | 3 |
| `26,30,35,40,45,50` | 3 |
| `45` | 3 |
| `2,4,6,8,10` | 2 |
| `25` | 2 |
| `4,8,12,16,20,25` | 2 |

### `fade` — seen 85 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 35 |
| `3` | 13 |
| `0` | 8 |
| `10` | 8 |
| `2` | 7 |
| `.7` | 4 |
| `4` | 3 |
| `.2` | 2 |
| `.4` | 2 |
| `.8` | 2 |
| `0.5` | 1 |

### `loot_stage_count_mod` — seen 84 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.01` | 84 |

### `newmodel` — seen 84 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 84 |

### `ray_cast` — seen 84 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 41 |
| `0.5` | 6 |
| `0.3` | 5 |
| `0.1` | 4 |
| `0.31` | 3 |
| `0.16` | 2 |
| `0.35` | 2 |
| `0.75` | 2 |
| `0.8` | 2 |
| `2.0` | 2 |
| `0.18` | 1 |
| `0.2` | 1 |

### `unholster` — seen 84 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.2` | 83 |
| `1.0` | 1 |

### `holster` — seen 83 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 82 |
| `1.0` | 1 |

### `blocked_tags` — seen 82 times
Top literal values:
| Value | Count |
| --- | --- |
| `noMods` | 60 |
| `noMods,lightArmor` | 3 |
| `noMods,noBlades` | 3 |
| `noMods,noScopes` | 3 |
| `noMods,heavyArmor` | 2 |
| `noMods,lightArmor,assassin` | 2 |
| `noMods,shotgun` | 2 |
| `noMods,bow` | 1 |
| `noMods,clothing` | 1 |
| `noMods,dBarrel` | 1 |
| `noMods,noSilencer` | 1 |
| `noMods,noStunEffect` | 1 |

### `value_type` — seen 82 times
Top literal values:
| Value | Count |
| --- | --- |
| `int` | 63 |
| `bool` | 16 |
| `string` | 2 |
| `${value_type}` | 1 |

### `anchor_left` — seen 80 times
Top literal values:
| Value | Count |
| --- | --- |
| `lblCaption,0,-5` | 23 |
| `queue,0,-3` | 8 |
| `#bottomleft,0,40` | 4 |
| `background,0,0` | 4 |
| `#cam,0,-10` | 3 |
| `#cam,0,-5` | 3 |
| `frame,0,0` | 3 |
| `queue,1,-300` | 3 |
| `#cam,0,0` | 2 |
| `#cam,0,20` | 2 |
| `#cam,0.5,0` | 2 |
| `#cam,1,-200` | 2 |

### `anchor_right` — seen 80 times
Top literal values:
| Value | Count |
| --- | --- |
| `lblCaption,1,5` | 23 |
| `queue,1,0` | 11 |
| `#bottomleft,0,50` | 4 |
| `#cam,1,0` | 4 |
| `background,1,0` | 4 |
| `#cam,1,10` | 3 |
| `#cam,1,5` | 3 |
| `frame,1,0` | 3 |
| `#cam,0.5,0` | 2 |
| `#cam,1,-20` | 2 |
| `queue,1,-230` | 2 |
| `#cam,0.5,-20` | 1 |

### `unique_only` — seen 79 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 79 |

### `unlock_tier` — seen 78 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 39 |
| `2` | 14 |
| `3` | 12 |
| `4` | 7 |
| `5` | 6 |

### `Loop` — seen 77 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 76 |
| `false` | 1 |

### `spritename` — seen 77 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_chair` | 4 |
| `ui_game_symbol_resource` | 4 |
| `ui_game_symbol_electric_plugin` | 3 |
| `ui_game_symbol_tree` | 3 |
| `` | 2 |
| `${spritename}` | 2 |
| `ui_game_symbol_brick` | 2 |
| `ui_game_symbol_loot_sack` | 2 |
| `ui_game_symbol_map_house` | 2 |
| `ui_game_symbol_map_trader` | 2 |
| `ui_game_symbol_quest` | 2 |
| `ui_game_symbol_shape_factory` | 2 |

### `defaultSelected` — seen 76 times
Top literal values:
| Value | Count |
| --- | --- |
| `content` | 27 |
| `bp.content` | 7 |
| `btnBack` | 3 |
| `btnCancel` | 2 |
| `btnContinue` | 2 |
| `btnRight` | 2 |
| `buttons` | 2 |
| `input` | 2 |
| `input1` | 2 |
| `queue` | 2 |
| `searchControls` | 2 |
| `txtDescription` | 2 |

### `createuipanel` — seen 75 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 75 |

### `buffs` — seen 73 times
Top literal values:
| Value | Count |
| --- | --- |
| `buffPerkBookwormSuccess` | 72 |
| `buffbuffPerkBookwormSuccess` | 1 |

### `enabled` — seen 73 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 17 |
| `false` | 10 |
| `${enabled}` | 4 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{# !defined('userlockmode') or !userlockmode}` | 2 |
| `{done}` | 2 |
| `{enablecountup}` | 2 |
| `{hasentry}` | 2 |
| `{savedeletable}` | 2 |
| `{worlddeletable}` | 2 |
| `{# !discord_ptt}` | 1 |
| `{# !discord_ptt and discord_vad_threshold_manual}` | 1 |
| `{# !prefab_name_invalid and !prefab_name_exists}` | 1 |
| `{# int(pagenumber) < int(maxpagenumber)}` | 1 |
| `{# int(pagenumber) > 1}` | 1 |
| `{canNewGame}` | 1 |

### `fill` — seen 73 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 10 |
| `0` | 7 |
| `0.5` | 4 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{durabilityfill}` | 8 |
| `{healthmodifiedmax}` | 6 |
| `{statmodifiedmax}` | 6 |
| `{fill}` | 4 |
| `{fillamount}` | 3 |
| `{votefill}` | 3 |
| `{fuelfill}` | 2 |
| `{healthfill}` | 2 |
| `{itemqualityfill}` | 2 |
| `{potentialfuelfill}` | 2 |
| `{# segment_fill_${repeat_i}}` | 1 |
| `{cooldownfill}` | 1 |

### `gamepad_selectable` — seen 73 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 67 |
| `true` | 3 |
| `${gamepad_selectable}` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{enabled}` | 1 |
| `{has_news}` | 1 |

### `value_increment` — seen 73 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.05` | 21 |
| `1` | 9 |
| `${value_increment}` | 7 |
| `@DEF` | 7 |
| `0.01` | 6 |
| `0.02` | 4 |
| `.1` | 3 |
| `0.10` | 3 |
| `0.1` | 2 |
| `0.2` | 2 |
| `2` | 2 |
| `5` | 2 |

### `displayname_key` — seen 70 times
Top literal values:
| Value | Count |
| --- | --- |
| `xuifDecor` | 3 |
| `` | 2 |
| `${displayname_key}` | 2 |
| `xuifElectrical` | 2 |
| `xuifLoot` | 2 |
| `xuifTraps` | 2 |
| `lblCategoryAmmo` | 1 |
| `lblCategoryArmor` | 1 |
| `lblCategoryBooksOnly` | 1 |
| `lblCategoryFoodCooking` | 1 |
| `lblCategoryMeleeWeapons` | 1 |
| `lblCategoryRangeWeapons` | 1 |

### `padding` — seen 67 times
Top literal values:
| Value | Count |
| --- | --- |
| `30,6,6` | 20 |
| `6` | 12 |
| `10,10` | 9 |
| `5,4` | 6 |
| `0,6` | 3 |
| `8,10` | 3 |
| `0,2` | 2 |
| `10` | 2 |
| `30,1,6` | 2 |
| `0,-1` | 1 |
| `0,1` | 1 |
| `0,9` | 1 |

### `on_press` — seen 66 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 65 |
| `false` | 1 |

### `remove_on_death` — seen 66 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 64 |
| `true` | 2 |

### `two_handed` — seen 66 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 66 |

### `anchor_bottom` — seen 65 times
Top literal values:
| Value | Count |
| --- | --- |
| `lblCaption,0,0` | 23 |
| `#bottomleft,0,80` | 4 |
| `#cam,0,180` | 4 |
| `#cam,0,0` | 3 |
| `background,0,0` | 3 |
| `text,0,-6` | 3 |
| `#cam,0,-10` | 2 |
| `#cam,0,-5` | 2 |
| `#cam,0,20` | 2 |
| `queue,0,0` | 2 |
| `#bottomleft,0,200` | 1 |
| `#cam,0,-0` | 1 |

### `anchor_top` — seen 65 times
Top literal values:
| Value | Count |
| --- | --- |
| `lblCaption,1,0` | 23 |
| `#bottomleft,0,90` | 4 |
| `#cam,0,240` | 4 |
| `#cam,1,0` | 3 |
| `#cam,1,5` | 3 |
| `background,1,0` | 3 |
| `#cam,1,10` | 2 |
| `frame,1,0` | 2 |
| `queue,1,49` | 2 |
| `#cam,0,100` | 1 |
| `#cam,0,170` | 1 |
| `#cam,0,350` | 1 |

### `format_string` — seen 65 times
Top literal values:
| Value | Count |
| --- | --- |
| `0%` | 29 |
| `0.00` | 11 |
| `` | 8 |
| `${format_string}` | 7 |
| `0.0` | 5 |
| `0` | 2 |
| `0 'dB'` | 1 |
| `0;'All';0` | 1 |
| `p0` | 1 |

### `panel` — seen 63 times
Top literal values:
| Value | Count |
| --- | --- |
| `Left` | 28 |
| `Center` | 20 |
| `Right` | 13 |
| `right` | 2 |

### `globalopacitymod` — seen 62 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.9` | 26 |
| `0.7` | 14 |
| `0.65` | 10 |
| `2` | 8 |
| `1` | 2 |
| `1.2` | 1 |
| `1.8` | 1 |

### `filtertext` — seen 61 times
Top literal values:
| Value | Count |
| --- | --- |
| `SC_decor` | 3 |
| `SC_electrical` | 2 |
| `SC_loot` | 2 |
| `SC_traps` | 2 |
| `` | 1 |
| `$other` | 1 |
| `${filtertext}` | 1 |
| `Ammo` | 1 |
| `Armor` | 1 |
| `BooksOnly` | 1 |
| `Food/Cooking` | 1 |
| `MC_building` | 1 |

### `filtertype` — seen 61 times
Top literal values:
| Value | Count |
| --- | --- |
| `blockfiltertags` | 38 |
| `itemgroups` | 14 |
| `autoshapes` | 8 |
| `${filtertype}` | 1 |

### `index` — seen 60 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 6 |
| `2` | 6 |
| `3` | 6 |
| `4` | 6 |
| `5` | 6 |
| `10` | 3 |
| `6` | 3 |
| `7` | 3 |
| `8` | 3 |
| `9` | 3 |
| `11` | 2 |
| `12` | 2 |

### `collider_scale` — seen 58 times
Top literal values:
| Value | Count |
| --- | --- |
| `1.0` | 23 |
| `1.5` | 23 |
| `1.25` | 11 |
| `1.1` | 1 |

### `on_hover` — seen 58 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 56 |
| `${on_hover}` | 1 |
| `false` | 1 |

### `rwgGenerationType` — seen 58 times
Top literal values:
| Value | Count |
| --- | --- |
| `all` | 58 |

### `texture` — seen 57 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 3 |
| `1` | 3 |
| `10` | 3 |
| `11` | 3 |
| `12` | 3 |
| `13` | 3 |
| `14` | 3 |
| `15` | 3 |
| `2` | 3 |
| `3` | 3 |
| `4` | 3 |
| `5` | 3 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{background_texture}` | 1 |
| `{texture_uri}` | 1 |

### `display_name` — seen 55 times
Top literal values:
| Value | Count |
| --- | --- |
| `lblCategoryAmmoWeapons` | 4 |
| `lblCategoryBuilding` | 4 |
| `lblCategoryDecorMisc` | 4 |
| `lblCategoryResources` | 4 |
| `lblCategoryToolsTraps` | 4 |
| `lblCategoryArmor` | 3 |
| `lblCategoryFoodCooking` | 3 |
| `lblCategoryMedicine` | 3 |
| `lblCategoryScience` | 3 |
| `lblCategoryChemicals` | 2 |
| `lblCategoryMods` | 2 |
| `GameEventCategory_POI` | 1 |

### `effect` — seen 55 times
Top literal values:
| Value | Count |
| --- | --- |
| `outline` | 44 |
| `Outline8` | 5 |
| `shadow` | 4 |
| `${effect}` | 1 |
| `none` | 1 |

### `nextstatementid` — seen 55 times
Top literal values:
| Value | Count |
| --- | --- |
| `start` | 12 |
| `background` | 10 |
| `currentjobs2` | 3 |
| `currentjobs3` | 3 |
| `currentjobs4` | 3 |
| `currentjobs5` | 3 |
| `admin` | 2 |
| `cassadores` | 2 |
| `currentjobs1` | 2 |
| `currentjobs6` | 2 |
| `navezgane` | 2 |
| `noah` | 2 |

### `AudioSource` — seen 54 times
Top literal values:
| Value | Count |
| --- | --- |
| `Sounds/AudioSource_Exploration` | 54 |

### `entitygroup` — seen 54 times
Top literal values:
| Value | Count |
| --- | --- |
| `ZombiesAll` | 8 |
| `ZombiesNight` | 8 |
| `ZombiesDowntown` | 6 |
| `WildGameForest` | 4 |
| `WildGameForestNight` | 2 |
| `WildGameStagNight` | 2 |
| `ZombiesAllWasteland` | 2 |
| `ZombiesWastelandDowntown` | 2 |
| `ZombiesWastelandNight` | 2 |
| `EnemyAnimalsBurntForestAny` | 1 |
| `EnemyAnimalsBurntForestNight` | 1 |
| `EnemyAnimalsDesert` | 1 |

### `maxcount` — seen 54 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 31 |
| `4` | 11 |
| `3` | 8 |
| `2` | 4 |

### `respawndelay` — seen 54 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.9` | 4 |
| `0.1` | 3 |
| `0.15` | 3 |
| `0.3` | 3 |
| `1.1` | 3 |
| `1.6` | 3 |
| `0.002` | 2 |
| `0.09` | 2 |
| `0.2` | 2 |
| `1.3` | 2 |
| `1.9` | 2 |
| `2.6` | 2 |

### `atlas` — seen 53 times
Top literal values:
| Value | Count |
| --- | --- |
| `ItemIconAtlas` | 17 |
| `ItemIconAtlasGreyscale` | 3 |
| `ControllerArtAtlas` | 2 |
| `UIAtlas` | 2 |
| `SymbolAtlas` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{staticonatlas|once}` | 6 |
| `{iconatlas}` | 2 |
| `{partatlas}` | 2 |
| `{itematlas}` | 1 |
| `{itemiconatlas}` | 1 |
| `{servericonatlas}` | 1 |
| `{uiatlas}` | 1 |
| `{unlock_icon_atlas1}` | 1 |
| `{unlock_icon_atlas10}` | 1 |
| `{unlock_icon_atlas11}` | 1 |
| `{unlock_icon_atlas12}` | 1 |
| `{unlock_icon_atlas13}` | 1 |

### `negative_preferred` — seen 51 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 43 |
| `false` | 8 |

### `fireOneBuff` — seen 50 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 50 |

### `weights` — seen 50 times
Top literal values:
| Value | Count |
| --- | --- |
| `.11,.07,.07,.05,.29,.36,.11` | 40 |
| `.05,.05,.05,.2,.2,.05,.4` | 4 |
| `.1,.1,.25,.40,.15` | 2 |
| `.11,.07,.05,.29,.36,.11` | 2 |
| `.3,.3,.2,.2` | 1 |
| `45,55` | 1 |

### `textcontent` — seen 49 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 8 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{historystatetitle}` | 3 |
| `{historytimestamptitle}` | 3 |
| `{actiondefaultcosttitle}` | 2 |
| `{actioncooldowntitle}` | 1 |
| `{actiondiscountcosttitle}` | 1 |
| `{actiongamestagetitle}` | 1 |
| `{actionispositivetitle}` | 1 |
| `{actionrandomgrouptitle}` | 1 |
| `{currentgood_title}` | 1 |
| `{historytargettitle}` | 1 |
| `{playercurrentlifetitle|once}` | 1 |
| `{playerdeathstitle|once}` | 1 |

### `valuecontent` — seen 49 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 8 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{historystate}` | 3 |
| `{historytimestamp}` | 3 |
| `{actionpointcost}` | 2 |
| `{actioncooldown}` | 1 |
| `{actiondiscountcost}` | 1 |
| `{actiongamestage}` | 1 |
| `{actionispositive}` | 1 |
| `{actionrandomgroup}` | 1 |
| `{historytarget}` | 1 |
| `{leaderboard_badperson}` | 1 |
| `{leaderboard_currentgood}` | 1 |
| `{leaderboard_goodperson}` | 1 |

### `face` — seen 48 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 48 |

### `hoverscale` — seen 47 times
Top literal values:
| Value | Count |
| --- | --- |
| `1.0` | 27 |
| `1.1` | 12 |
| `1` | 5 |
| `1.25` | 3 |

### `borderspritename` — seen 46 times
Top literal values:
| Value | Count |
| --- | --- |
| `menu_empty3px` | 39 |
| `menu_empty2px` | 7 |

### `compare_type` — seen 46 times
Top literal values:
| Value | Count |
| --- | --- |
| `or` | 46 |

### `event_title` — seen 45 times
Top literal values:
| Value | Count |
| --- | --- |
| `Celebrate Raid` | 3 |
| `Gift of Chickens` | 3 |
| `Gift of Coyotes` | 3 |
| `Gift of Dogs` | 3 |
| `Buffed Raid` | 2 |
| `Cop Raid` | 2 |
| `Gift of Bears` | 2 |
| `Gift of Boars` | 2 |
| `Gift of Grace` | 2 |
| `Gift of Snakes` | 2 |
| `Gift of Wolves` | 2 |
| `Hype Train Zoo` | 2 |

### `event_title_key` — seen 45 times
Top literal values:
| Value | Count |
| --- | --- |
| `TwitchEventGiftSubChickens` | 3 |
| `TwitchEventGiftSubCoyotes` | 3 |
| `TwitchEventGiftSubDogs` | 3 |
| `TwitchEventRaidCelebrate` | 3 |
| `TwitchEventGiftSubBears` | 2 |
| `TwitchEventGiftSubBoars` | 2 |
| `TwitchEventGiftSubGrace` | 2 |
| `TwitchEventGiftSubSnakes` | 2 |
| `TwitchEventGiftSubWolves` | 2 |
| `TwitchEventHypeTrainZoo` | 2 |
| `TwitchEventRaidBuffed` | 2 |
| `TwitchEventRaidCop` | 2 |

### `presets` — seen 45 times
Top literal values:
| Value | Count |
| --- | --- |
| `hardcore` | 18 |
| `standard` | 14 |
| `casual` | 7 |
| `casual,standard` | 5 |
| `casual,standard,hardcore` | 1 |

### `event_name` — seen 44 times
Top literal values:
| Value | Count |
| --- | --- |
| `event_chickens` | 4 |
| `event_coyotes` | 3 |
| `event_dogs` | 3 |
| `group_bears` | 3 |
| `vote_celebrate` | 3 |
| `event_boars` | 2 |
| `event_snakes` | 2 |
| `event_wolves` | 2 |
| `group_buffed_zombies` | 2 |
| `group_cops` | 2 |
| `group_grace` | 2 |
| `mystery_sub1` | 2 |

### `force_input_style` — seen 44 times
Top literal values:
| Value | Count |
| --- | --- |
| `keyboard` | 44 |

### `part` — seen 44 times
Top literal values:
| Value | Count |
| --- | --- |
| `HeadLight` | 13 |
| `Sparks` | 9 |
| `Flames` | 8 |
| `HeadLightCam` | 8 |
| `LeftKnuckles` | 6 |

### `safe_allowed` — seen 44 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 32 |
| `true` | 12 |

### `sound_play_on_hover` — seen 44 times
Top literal values:
| Value | Count |
| --- | --- |
| `[default_hover]` | 44 |

### `value_max` — seen 44 times
Top literal values:
| Value | Count |
| --- | --- |
| `${value_max}` | 7 |
| `@DEF` | 7 |
| `2` | 5 |
| `1` | 4 |
| `10` | 3 |
| `5` | 3 |
| `50` | 2 |
| `0` | 1 |
| `179` | 1 |
| `2.0` | 1 |
| `20` | 1 |
| `23.99` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{news_count}` | 1 |

### `vote_allowed` — seen 44 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 32 |
| `true` | 12 |

### `contents_parent` — seen 43 times
Top literal values:
| Value | Count |
| --- | --- |
| `content` | 14 |
| `saves` | 4 |
| `groups` | 2 |
| `players` | 2 |
| `tags` | 2 |
| `triggeredBy` | 2 |
| `worlds` | 2 |
| `` | 1 |
| `${contents_parent}` | 1 |
| `blockList` | 1 |
| `files` | 1 |
| `mapTrackingContent` | 1 |

### `craft_tool` — seen 43 times
Top literal values:
| Value | Count |
| --- | --- |
| `toolCookingPot` | 31 |
| `toolBeaker` | 5 |
| `toolCookingGrill` | 4 |
| `toolForgeCrucible` | 3 |

### `hovercolor` — seen 43 times
Top literal values:
| Value | Count |
| --- | --- |
| `[white]` | 31 |
| `0,0,0,220` | 2 |
| `100,100,100,100` | 2 |
| `[tan]` | 2 |
| `` | 1 |
| `${hovercolor}` | 1 |
| `${sprite_color_hover}` | 1 |
| `0,0,0,10` | 1 |
| `0,0,0,8` | 1 |
| `[hoverColor]` | 1 |

### `listindex` — seen 42 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 8 |
| `1` | 8 |
| `2` | 8 |
| `3` | 8 |
| `4` | 8 |
| `5` | 1 |
| `6` | 1 |

### `start_amount` — seen 42 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 9 |
| `0` | 8 |
| `50` | 5 |
| `10` | 4 |
| `20` | 3 |
| `5` | 3 |
| `100` | 2 |
| `15` | 2 |
| `2` | 2 |
| `30` | 2 |
| `25` | 1 |
| `6` | 1 |

### `icon_blink` — seen 41 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 38 |
| `false` | 3 |

### `requirementtype` — seen 41 times
Top literal values:
| Value | Count |
| --- | --- |
| `Hide` | 41 |

### `tab_key` — seen 41 times
Top literal values:
| Value | Count |
| --- | --- |
| `xuiGameSettingsGeneral` | 4 |
| `xuiGameSettingsAdvanced` | 3 |
| `xuiGameSettingsBasic` | 3 |
| `xuiGameSettingsMultiplayer` | 3 |
| `xuiGameSettingsServer` | 2 |
| `xuiOptionsControlsGeneric` | 2 |
| `xuiOptionsVideoDisplay` | 2 |
| `xuiOptionsVideoUI` | 2 |
| `TwitchInfo_Votes` | 1 |
| `xuiBlockedPlayers` | 1 |
| `xuiMpTabDiscord` | 1 |
| `xuiOptionsAudioDiscord` | 1 |

### `pimp_pot_add` — seen 40 times
Top literal values:
| Value | Count |
| --- | --- |
| `100` | 33 |
| `1000` | 2 |
| `250` | 2 |
| `500` | 2 |
| `10` | 1 |

### `value_min` — seen 40 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 16 |
| `${value_min}` | 7 |
| `@DEF` | 7 |
| `1` | 2 |
| `-1` | 1 |
| `-100` | 1 |
| `-20` | 1 |
| `.15` | 1 |
| `.25` | 1 |
| `0.001` | 1 |
| `0.6` | 1 |
| `5` | 1 |

### `has_quality` — seen 39 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 29 |
| `true` | 10 |

### `use_selection_box` — seen 39 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 34 |
| `true` | 5 |

### `always_unlocked` — seen 38 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 38 |

### `character_limit` — seen 38 times
Top literal values:
| Value | Count |
| --- | --- |
| `3` | 12 |
| `30` | 5 |
| `16` | 3 |
| `${character_limit}` | 2 |
| `0` | 2 |
| `20` | 2 |
| `2048` | 2 |
| `4` | 2 |
| `50` | 2 |
| `9` | 2 |
| `10` | 1 |
| `300` | 1 |

### `disabled_font_color` — seen 38 times
Top literal values:
| Value | Count |
| --- | --- |
| `[disabledLabelColor]` | 29 |
| `148,148,148,255` | 5 |
| `${disabled_font_color}` | 3 |
| `[white]` | 1 |

### `target_tags` — seen 38 times
Top literal values:
| Value | Count |
| --- | --- |
| `zombie,animal` | 22 |
| `walker` | 10 |
| `ally,party` | 6 |

### `caption` — seen 36 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 5 |
| `Account` | 1 |
| `Complete ([action:gui:GUI D-Pad Up])` | 1 |
| `Delete Player` | 1 |
| `Disconnect` | 1 |
| `Provisional` | 1 |
| `Track ([action:gui:GUI D-Pad Left])` | 1 |
| `{name}{# length(comment) > 0 ? '*' : '' } ({position})` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{tab_name_localized}` | 16 |
| `{archivelabel}` | 1 |
| `{blockedplayers}` | 1 |
| `{canceltext}` | 1 |
| `{confirmtext}` | 1 |
| `{refundtext}` | 1 |
| `{retrytext}` | 1 |
| `{show_devicecode}` | 1 |
| `{twitchbuttontext}` | 1 |

### `local_offset` — seen 36 times
Top literal values:
| Value | Count |
| --- | --- |
| `0,0,0` | 14 |
| `0,.1,0` | 8 |
| `0,-.2,0` | 4 |
| `0,.1,0.2` | 4 |
| `-.06,.2,0.1` | 2 |
| `-0.15,0,0.035` | 2 |
| `0,.3,0` | 2 |

### `platform` — seen 35 times
Top literal values:
| Value | Count |
| --- | --- |
| `!CONSOLE` | 6 |
| `CONSOLE` | 4 |
| `PS5` | 4 |
| `STANDALONE` | 4 |
| `!PS5` | 3 |
| `!SUBMISSION` | 3 |
| `XBOX` | 3 |
| `!PS5,!XBOX` | 2 |
| `!PS5,!XBOX_S,!XBOX_X` | 1 |
| `!XBOX` | 1 |
| `PS5,XBOX_X` | 1 |
| `STANDALONE,PS5` | 1 |

### `allow_custom` — seen 34 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 24 |
| `true` | 9 |
| `${allow_custom}` | 1 |

### `eye_color` — seen 34 times
Top literal values:
| Value | Count |
| --- | --- |
| `Blue05` | 3 |
| `Brown02` | 3 |
| `Brown07` | 3 |
| `Brown01` | 2 |
| `Gray02` | 2 |
| `Green01` | 2 |
| `Green05` | 2 |
| `Hazel01` | 2 |
| `Hazel02` | 2 |
| `Hazel03` | 2 |
| `Blue02` | 1 |
| `Blue03` | 1 |

### `male` — seen 34 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 17 |
| `true` | 17 |

### `max_line_count` — seen 34 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 31 |
| `0` | 2 |
| `${max_line_count}` | 1 |

### `race` — seen 34 times
Top literal values:
| Value | Count |
| --- | --- |
| `White` | 10 |
| `Asian` | 8 |
| `Black` | 8 |
| `Native` | 8 |

### `variant` — seen 34 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 10 |
| `2` | 8 |
| `3` | 8 |
| `4` | 8 |

### `add` — seen 32 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 30 |
| `false` | 2 |

### `hair_color` — seen 32 times
Top literal values:
| Value | Count |
| --- | --- |
| `06 Black` | 12 |
| `05 DarkBrown` | 8 |
| `03 LightBrown` | 3 |
| `07 Gray` | 3 |
| `04 Brown` | 2 |
| `10 Red 1` | 2 |
| `02 Dark Blond` | 1 |
| `08 White` | 1 |

### `is_trackable` — seen 32 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 32 |

### `material_based` — seen 32 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 32 |

### `nav_object` — seen 32 times
Top literal values:
| Value | Count |
| --- | --- |
| `twitch_vote_boss_shield` | 3 |
| `twitch_vote_minion_shield` | 3 |
| `twitch_explode_v2` | 2 |
| `twitch_vote_boss` | 2 |
| `twitch_vote_boss_bows` | 2 |
| `twitch_vote_boss_machinegunner` | 2 |
| `twitch_vote_boss_pistols` | 2 |
| `twitch_vote_boss_rifles` | 2 |
| `twitch_vote_boss_shotguns` | 2 |
| `twitch_vote_minion` | 2 |
| `twitch_vote_minion_bows` | 2 |
| `twitch_vote_minion_machinegunner` | 2 |

### `active` — seen 31 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 14 |
| `true` | 13 |
| `@!.IsFPV` | 2 |
| `@.IsFPV` | 2 |

### `enabled_font_color` — seen 31 times
Top literal values:
| Value | Count |
| --- | --- |
| `[labelColor]` | 27 |
| `${enabled_font_color}` | 3 |
| `[white]` | 1 |

### `local_rotation` — seen 31 times
Top literal values:
| Value | Count |
| --- | --- |
| `180,90,0` | 16 |
| `90,0,0` | 6 |
| `0,90,0` | 4 |
| `-80,180,0` | 2 |
| `90,90,0` | 2 |
| `0,0,0` | 1 |

### `block_tag` — seen 30 times
Top literal values:
| Value | Count |
| --- | --- |
| `challenge_farming` | 10 |
| `ore` | 8 |
| `challenge_cars` | 3 |
| `challenge_elec_parts` | 1 |
| `challenge_gore` | 1 |
| `challenge_leather` | 1 |
| `challenge_mech_parts` | 1 |
| `challenge_pallet` | 1 |
| `challenge_polymers` | 1 |
| `challenge_sinks` | 1 |
| `challenge_steel` | 1 |
| `challenge_stump` | 1 |

### `on_scroll` — seen 30 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 16 |
| `false` | 10 |
| `${on_scroll}` | 4 |

### `selectedcolor` — seen 30 times
Top literal values:
| Value | Count |
| --- | --- |
| `[mediumGrey]` | 17 |
| `[selectedColor]` | 11 |
| `${selectedcolor}` | 1 |
| `88,101,242` | 1 |

### `uniqueid` — seen 30 times
Top literal values:
| Value | Count |
| --- | --- |
| `next` | 15 |
| `prev` | 15 |

### `actionSet` — seen 29 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 27 |
| `controller` | 1 |
| `keyboard` | 1 |

### `hair` — seen 29 times
Top literal values:
| Value | Count |
| --- | --- |
| `buzzcut` | 3 |
| `midpart_shoulder` | 3 |
| `ponytail` | 3 |
| `slicked_back` | 3 |
| `comb_over` | 2 |
| `dreads` | 2 |
| `pixie_cut` | 2 |
| `small_fro` | 2 |
| `afro_curly` | 1 |
| `midpart_karen_messy` | 1 |
| `midpart_long` | 1 |
| `midpart_mid` | 1 |

### `cooldown_allowed` — seen 28 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 17 |
| `true` | 11 |

### `disabled_color` — seen 26 times
Top literal values:
| Value | Count |
| --- | --- |
| `[disabledLabelColor]` | 12 |
| `[iconColor]` | 8 |
| `[lightGrey]` | 5 |
| `${disabled_color}` | 1 |

### `health` — seen 26 times
Top literal values:
| Value | Count |
| --- | --- |
| `-2` | 8 |
| `-1` | 6 |
| `5` | 4 |
| `@$StormDamage` | 4 |
| `-3` | 2 |
| `-5` | 2 |

### `ignoreparentpadding` — seen 26 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 26 |

### `borderinset` — seen 25 times
Top literal values:
| Value | Count |
| --- | --- |
| `14,1,1` | 22 |
| `0` | 1 |
| `0,80` | 1 |
| `14,0,0` | 1 |

### `close_compass_on_open` — seen 25 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 25 |

### `end_amount` — seen 25 times
Top literal values:
| Value | Count |
| --- | --- |
| `49` | 5 |
| `14` | 3 |
| `19` | 3 |
| `4` | 3 |
| `9` | 3 |
| `1` | 2 |
| `29` | 2 |
| `99` | 2 |
| `24` | 1 |
| `5` | 1 |

### `entity_tags` — seen 24 times
Top literal values:
| Value | Count |
| --- | --- |
| `zombie` | 17 |
| `animal` | 3 |
| `allbiome,zombieAnimal,burnt,desert,snow` | 1 |
| `allbiome,zombieAnimal,burnt,desert,wasteland` | 1 |
| `allbiome,zombieAnimal,burnt,snow,wasteland` | 1 |
| `allbiome,zombieAnimal,desert,snow,wasteland` | 1 |

### `local_scale` — seen 24 times
Top literal values:
| Value | Count |
| --- | --- |
| `2,2,2` | 8 |
| `.75,.75,.75` | 4 |
| `1,1,1` | 4 |
| `1.5,1.5,1.5` | 2 |
| `1.75,1.75,1.75` | 2 |
| `2.25,2.25,2.25` | 2 |
| `5,5,5` | 2 |

### `notags` — seen 24 times
Top literal values:
| Value | Count |
| --- | --- |
| `commercial,industrial,downtown` | 12 |
| `downtown` | 12 |

### `overflow_width` — seen 24 times
Top literal values:
| Value | Count |
| --- | --- |
| `260` | 24 |

### `target_name_key` — seen 24 times
Top literal values:
| Value | Count |
| --- | --- |
| `xuiZombies` | 6 |
| `xuiAnimals` | 2 |
| `challengeKillTargetAntileechZombies` | 1 |
| `challengeKillTargetBigHeadZombies` | 1 |
| `challengeKillTargetBucketHeadZombies` | 1 |
| `challengeKillTargetCelebrateZombies` | 1 |
| `challengeKillTargetConfuseZombies` | 1 |
| `challengeKillTargetDancingZombies` | 1 |
| `challengeKillTargetDeafenZombies` | 1 |
| `challengeKillTargetDontMiss` | 1 |
| `challengeKillTargetHeadshotOnly` | 1 |
| `challengeKillTargetKeepMovingZombies` | 1 |

### `Volume` — seen 23 times
Top literal values:
| Value | Count |
| --- | --- |
| `.5` | 2 |
| `.65` | 2 |
| `0.4` | 2 |
| `0.58` | 2 |
| `.3` | 1 |
| `.6` | 1 |
| `.75` | 1 |
| `0.25` | 1 |
| `0.3` | 1 |
| `0.33` | 1 |
| `0.38` | 1 |
| `0.45` | 1 |

### `createuiwidget` — seen 23 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 23 |

### `delay` — seen 23 times
Top literal values:
| Value | Count |
| --- | --- |
| `1.0` | 18 |
| `28,36` | 3 |
| `26,34` | 1 |
| `26,36` | 1 |

### `hoversprite` — seen 23 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_select_row` | 22 |
| `${hoversprite}` | 1 |

### `random_count` — seen 23 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 12 |
| `2` | 6 |
| `3` | 5 |

### `search_field` — seen 23 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 21 |
| `${search_field}` | 1 |
| `false` | 1 |

### `categoryname` — seen 22 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 2 |
| `${categoryname}` | 2 |
| `Building` | 1 |
| `InfoVolume` | 1 |
| `Items` | 1 |
| `LevelDesign` | 1 |
| `Outdoor` | 1 |
| `PlayerBlocks` | 1 |
| `SleeperVolume` | 1 |
| `TraderTeleport` | 1 |
| `TriggerVolume` | 1 |
| `WallVolume` | 1 |

### `columns` — seen 22 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 12 |
| `2` | 8 |
| `3` | 2 |

### `entity_names` — seen 22 times
Top literal values:
| Value | Count |
| --- | --- |
| `zombieMutated,zombieMutatedFeral,zombieMutatedRadiated,zombieMutatedCharged,zombieMutatedInfernal` | 2 |
| `animalBear,animalBearSmall,animalZombieBear` | 1 |
| `animalBoar,animalBossGrace` | 1 |
| `animalChicken` | 1 |
| `animalCoyote` | 1 |
| `animalDoe,animalStag` | 1 |
| `animalMountainLion` | 1 |
| `animalRabbit` | 1 |
| `animalSnake` | 1 |
| `animalWolf,animalDirewolf` | 1 |
| `animalZombieVulture,animalZombieVultureRadiated` | 1 |
| `zombieBurnt,zombieBurntFeral,zombieBurntRadiated,zombieBurntCharged,zombieBurntInfernal` | 1 |

### `validation` — seen 22 times
Top literal values:
| Value | Count |
| --- | --- |
| `integer` | 20 |
| `${validation}` | 1 |
| `none` | 1 |

### `category` — seen 21 times
Top literal values:
| Value | Count |
| --- | --- |
| `Advanced` | 6 |
| `Basics` | 6 |
| `Biome Progression` | 4 |
| `Twitch` | 3 |
| `Spawns` | 1 |
| `Supplies` | 1 |

### `clear_button` — seen 21 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 14 |
| `false` | 6 |
| `${clear_button}` | 1 |

### `disabledcolor` — seen 21 times
Top literal values:
| Value | Count |
| --- | --- |
| `[lightGrey]` | 9 |
| `[mediumGrey]` | 4 |
| `[disabledLabelColor]` | 3 |
| `[darkGrey]` | 2 |
| `[disabledColor]` | 2 |
| `0,0,0,1` | 1 |

### `hint` — seen 21 times
Top literal values:
| Value | Count |
| --- | --- |
| `challengeBurntShelterHint1` | 1 |
| `challengeCraftArrowsHint1` | 1 |
| `challengeCraftBedrollHint2` | 1 |
| `challengeCraftBowHint1` | 1 |
| `challengeCraftBuildingBlocksHint1` | 1 |
| `challengeCraftClothesHint1` | 1 |
| `challengeCraftFarmPlotHint1` | 1 |
| `challengeCraftStoneAxeHint1` | 1 |
| `challengeCraftWoodClubHint1` | 1 |
| `challengeDesertShelterHint1` | 1 |
| `challengeGatherResourcesHint1` | 1 |
| `challengeGatherResourcesStoneAxeHint2` | 1 |

### `transform_path` — seen 21 times
Top literal values:
| Value | Count |
| --- | --- |
| `lightSource` | 5 |
| `flashlight_lightSource` | 3 |
| `gun_laser` | 3 |
| `gunlaser/gunlaser` | 3 |
| `scope` | 3 |
| `flashlight` | 1 |
| `gunlaser` | 1 |
| `holosight` | 1 |
| `silencer` | 1 |

### `checkresource` — seen 20 times
Top literal values:
| Value | Count |
| --- | --- |
| `-7` | 20 |

### `clipping` — seen 20 times
Top literal values:
| Value | Count |
| --- | --- |
| `softclip` | 19 |
| `SoftClip` | 1 |

### `clippingsoftness` — seen 20 times
Top literal values:
| Value | Count |
| --- | --- |
| `20,20` | 16 |
| `0,0` | 2 |
| `0,40` | 1 |
| `4,4` | 1 |

### `hide_inactive` — seen 20 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 20 |

### `onslopes` — seen 20 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 20 |

### `parentTransform` — seen 20 times
Top literal values:
| Value | Count |
| --- | --- |
| `Handle` | 6 |
| `#HeldItemRoot` | 5 |
| `CameraNode` | 3 |
| `LeftWeapon` | 3 |
| `Spotlight` | 3 |

### `end` — seen 19 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 5 |
| `10` | 3 |
| `20` | 3 |
| `30` | 3 |
| `4` | 3 |
| `40` | 2 |

### `change` — seen 18 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 6 |
| `1` | 5 |
| `3` | 4 |
| `4` | 2 |
| `2` | 1 |

### `clipAdapterType` — seen 18 times
Top literal values:
| Value | Count |
| --- | --- |
| `ClipAdapter` | 14 |
| `ClipPairAdapter` | 4 |

### `contentType` — seen 18 times
Top literal values:
| Value | Count |
| --- | --- |
| `ClipSet` | 14 |
| `BloodmoonClipSet` | 4 |

### `flip_y` — seen 18 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 18 |

### `force` — seen 18 times
Top literal values:
| Value | Count |
| --- | --- |
| `350` | 12 |
| `200` | 3 |
| `1400` | 1 |
| `250` | 1 |
| `300` | 1 |

### `noiseoffset` — seen 18 times
Top literal values:
| Value | Count |
| --- | --- |
| `1000, 111` | 5 |
| `2000, 222` | 5 |
| `3000, 333` | 5 |
| `4000, 444` | 3 |

### `relative` — seen 18 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 11 |
| `true` | 7 |

### `selectedsprite` — seen 18 times
Top literal values:
| Value | Count |
| --- | --- |
| `menu_empty` | 16 |
| `${selectedsprite}` | 1 |
| `ui_game_select_row` | 1 |

### `clear_searchtext_on_open` — seen 17 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 16 |
| `false` | 1 |

### `close_group_on_tab` — seen 17 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 15 |
| `${close_group_on_tab}` | 1 |
| `false` | 1 |

### `cooldown_max` — seen 17 times
Top literal values:
| Value | Count |
| --- | --- |
| `1000` | 2 |
| `150` | 2 |
| `1500` | 2 |
| `300` | 2 |
| `400` | 2 |
| `600` | 2 |
| `800` | 2 |
| `1200` | 1 |
| `200` | 1 |
| `500` | 1 |

### `is_action` — seen 17 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 17 |

### `material` — seen 17 times
Top literal values:
| Value | Count |
| --- | --- |
| `Materials/Transparent Colored` | 16 |
| `Materials/MaskableMainmap` | 1 |

### `open_backpack_on_open` — seen 17 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 17 |

### `reverse_list` — seen 17 times
Top literal values:
| Value | Count |
| --- | --- |
| `${reverse_list}` | 7 |
| `@DEF` | 7 |
| `true` | 3 |

### `block` — seen 16 times
Top literal values:
| Value | Count |
| --- | --- |
| `frameShapes:VariantHelper` | 2 |
| `bedrollBlockVariantHelper` | 1 |
| `campfire` | 1 |
| `cementMixer` | 1 |
| `chemistryStation` | 1 |
| `cntDewCollector` | 1 |
| `cntWoodWritableCrate` | 1 |
| `farmPlotBlockVariantHelper` | 1 |
| `forge` | 1 |
| `keystoneBlock` | 1 |
| `oldWoodDoor` | 1 |
| `trapSpikesWoodDmg0` | 1 |

### `selected` — seen 16 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 3 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{userlockmode}` | 3 |
| `{cam_position_add_open}` | 1 |
| `{discord_open}` | 1 |
| `{filtersbuttonselected}` | 1 |
| `{isfavorite}` | 1 |
| `{showpassword}` | 1 |
| `{typededicatedselected}` | 1 |
| `{typefriendsselected}` | 1 |
| `{typehistoryselected}` | 1 |
| `{typelanselected}` | 1 |
| `{typepeerselected}` | 1 |

### `virtual_keyboard_prompt` — seen 16 times
Top literal values:
| Value | Count |
| --- | --- |
| `vkPromptSearchTerm` | 7 |
| `vkPromptSignText` | 4 |
| `vkPromptCount` | 2 |
| `` | 1 |
| `${virtual_keyboard_prompt}` | 1 |
| `vkPromptWaypointName` | 1 |

### `altbackgroundcolor` — seen 15 times
Top literal values:
| Value | Count |
| --- | --- |
| `[darkestGrey]` | 12 |
| `[darkGrey]` | 3 |

### `body_parts` — seen 15 times
Top literal values:
| Value | Count |
| --- | --- |
| `Head` | 9 |
| `LeftUpperLeg,RightUpperLeg,LeftLowerLeg,RightLowerLeg` | 6 |

### `hidden_by` — seen 15 times
Top literal values:
| Value | Count |
| --- | --- |
| `Basics` | 15 |

### `localPos` — seen 15 times
Top literal values:
| Value | Count |
| --- | --- |
| `0,0,0` | 11 |
| `0,0.1,0` | 3 |
| `0.2,0.125,-0.055` | 1 |

### `localRot` — seen 15 times
Top literal values:
| Value | Count |
| --- | --- |
| `0,0,0` | 9 |
| `-90,180,0` | 3 |
| `90,0,0` | 3 |

### `weight` — seen 15 times
Top literal values:
| Value | Count |
| --- | --- |
| `2` | 6 |
| `3` | 5 |
| `1` | 3 |
| `4` | 1 |

### `challenge_stat` — seen 14 times
Top literal values:
| Value | Count |
| --- | --- |
| `challengeStatBurntShelter` | 2 |
| `challengeStatDesertShelter` | 2 |
| `challengeStatSnowShelter` | 2 |
| `challengeStatWastelandShelter` | 2 |
| `drinkwater` | 2 |
| `harvestHoneyStat` | 2 |
| `homerunderby` | 2 |

### `cooldown_time` — seen 14 times
Top literal values:
| Value | Count |
| --- | --- |
| `600` | 5 |
| `120` | 3 |
| `150` | 2 |
| `300` | 2 |
| `240` | 1 |
| `60` | 1 |

### `craft_exp_gain` — seen 14 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 14 |

### `effect_color` — seen 14 times
Top literal values:
| Value | Count |
| --- | --- |
| `0,0,0,255` | 7 |
| `[black]` | 4 |
| `0,0,0,150` | 2 |
| `${effect_color}` | 1 |

### `effect_distance` — seen 14 times
Top literal values:
| Value | Count |
| --- | --- |
| `1,1` | 9 |
| `2,2` | 4 |
| `${effect_distance}` | 1 |

### `normal_color` — seen 14 times
Top literal values:
| Value | Count |
| --- | --- |
| `[iconColor]` | 14 |

### `order` — seen 14 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1 |
| `10` | 1 |
| `11` | 1 |
| `12` | 1 |
| `13` | 1 |
| `14` | 1 |
| `2` | 1 |
| `3` | 1 |
| `4` | 1 |
| `5` | 1 |
| `6` | 1 |
| `7` | 1 |

### `start` — seen 14 times
Top literal values:
| Value | Count |
| --- | --- |
| `11` | 3 |
| `21` | 3 |
| `31` | 3 |
| `5` | 3 |
| `41` | 2 |

### `track_distance` — seen 14 times
Top literal values:
| Value | Count |
| --- | --- |
| `50` | 9 |
| `15` | 3 |
| `20` | 1 |
| `40` | 1 |

### `description` — seen 13 times
Top literal values:
| Value | Count |
| --- | --- |
| `+Bartering` | 1 |
| `+Crafting Speed` | 1 |
| `+Harvesting` | 1 |
| `+Loot GS` | 1 |
| `+XP` | 1 |
| `-Bartering` | 1 |
| `-Crafting Speed` | 1 |
| `-Harvesting` | 1 |
| `-Loot GS` | 1 |
| `-XP` | 1 |
| `Gives four skill points` | 1 |
| `No Twitch Actions are active.` | 1 |

### `flip` — seen 13 times
Top literal values:
| Value | Count |
| --- | --- |
| `Horizontally` | 8 |
| `horizontally` | 2 |
| `${align_right ? 'nothing' : 'horizontally'}` | 1 |
| `vertically` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{flip_dropdownbutton}` | 1 |

### `override_tracker_index` — seen 13 times
Top literal values:
| Value | Count |
| --- | --- |
| `challenge_cars` | 3 |
| `POILight` | 1 |
| `challenge_gore` | 1 |
| `challenge_leather` | 1 |
| `challenge_mech_parts` | 1 |
| `challenge_pallet` | 1 |
| `challenge_polymers` | 1 |
| `challenge_sinks` | 1 |
| `challenge_steel` | 1 |
| `quest_stone_boulder` | 1 |
| `quest_wood_trees` | 1 |

### `sections` — seen 13 times
Top literal values:
| Value | Count |
| --- | --- |
| `Exploration` | 7 |
| `Suspense` | 4 |
| `Bloodmoon` | 1 |
| `Combat` | 1 |

### `show_inverted` — seen 13 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 8 |
| `false` | 5 |

### `state` — seen 13 times
Top literal values:
| Value | Count |
| --- | --- |
| `Stunned` | 6 |
| `Deafened` | 4 |
| `1` | 1 |
| `2` | 1 |
| `3` | 1 |

### `strength` — seen 13 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.8` | 5 |
| `8` | 4 |
| `0.35` | 1 |
| `0.5` | 1 |
| `0.65` | 1 |
| `5` | 1 |

### `killer_has_bufftag` — seen 12 times
Top literal values:
| Value | Count |
| --- | --- |
| `twitch_antileech` | 1 |
| `twitch_buckethead` | 1 |
| `twitch_celebrate` | 1 |
| `twitch_confuse` | 1 |
| `twitch_dance` | 1 |
| `twitch_deafen` | 1 |
| `twitch_dontmiss` | 1 |
| `twitch_headshotonly` | 1 |
| `twitch_keepmoving` | 1 |
| `twitch_sillysounds` | 1 |
| `twitch_slow` | 1 |
| `twitch_weak` | 1 |

### `source` — seen 12 times
Top literal values:
| Value | Count |
| --- | --- |
| `@:Sounds/Prefabs/AudioSource_TraderTheme.prefab` | 5 |
| `@:Sounds/Prefabs/AudioSource_Home.prefab` | 2 |
| `@:Sounds/Prefabs/AudioSource_Bloodmoon.prefab` | 1 |
| `@:Sounds/Prefabs/AudioSource_Combat.prefab` | 1 |
| `@:Sounds/Prefabs/AudioSource_Exploration.prefab` | 1 |
| `@:Sounds/Prefabs/AudioSource_Suspense.prefab` | 1 |
| `treeTallGrassDiagonal` | 1 |

### `type_ds` — seen 12 times
Top literal values:
| Value | Count |
| --- | --- |
| `Vibration` | 3 |
| `WeaponSingle` | 3 |
| `Feedback` | 2 |
| `FeedbackSlope` | 2 |
| `MultipointFeedback` | 2 |

### `enabled_color` — seen 11 times
Top literal values:
| Value | Count |
| --- | --- |
| `[iconColor]` | 6 |
| `[labelColor]` | 3 |
| `${enabled_color}` | 1 |
| `[white]` | 1 |

### `item_name` — seen 11 times
Top literal values:
| Value | Count |
| --- | --- |
| `biomeWeatherItem1` | 4 |
| `biomeWeatherItem2` | 3 |
| `biomeWeatherItem3` | 2 |
| `biomeWeatherItem4` | 1 |
| `casinoCoin` | 1 |

### `message_key` — seen 11 times
Top literal values:
| Value | Count |
| --- | --- |
| `buffDukeNoteToolTip` | 3 |
| `buffAnimalTrackerNoneTooltip` | 1 |
| `buffDysentery01UntreatedTooltip` | 1 |
| `buffPerkAnimalTrackerLostTooltip` | 1 |
| `buffShowAIDisabledTooltip` | 1 |
| `buffShowAnimationDisabledTooltip` | 1 |
| `drinkJarFullRespecAdminTooltip` | 1 |
| `drinkJarGrandpasForgettingElixirTooltip` | 1 |
| `ttTwitchHomerunStart` | 1 |

### `mustache` — seen 11 times
Top literal values:
| Value | Count |
| --- | --- |
| `5` | 5 |
| `1` | 4 |
| `2` | 1 |
| `3` | 1 |

### `showonhud` — seen 11 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 7 |
| `true` | 4 |

### `actions_default_format` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `( [e61a16]###[-] )` | 8 |
| `( ### )` | 2 |

### `cosmetic_install_chance` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `.1` | 9 |
| `0` | 1 |

### `equip_slot` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `BiomeBadge` | 4 |
| `BiomeBadge2` | 3 |
| `BiomeBadge3` | 2 |
| `BiomeBadge4` | 1 |

### `focus_on_open` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 5 |
| `false` | 4 |
| `${focus_on_open}` | 1 |

### `hover_color` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `[mediumGrey]` | 6 |
| `[lightGrey]` | 3 |
| `[hoverColor]` | 1 |

### `mode` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `before` | 10 |

### `objective_type` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `BadAction` | 1 |
| `BitPot` | 1 |
| `ChannelPointRedeems` | 1 |
| `DefeatBossHorde` | 1 |
| `EnableExtras` | 1 |
| `Enabled` | 1 |
| `GoodAction` | 1 |
| `HelperReward` | 1 |
| `PimpPot` | 1 |
| `VoteComplete` | 1 |

### `on_doubleclick` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 10 |

### `open_vk_on_open` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 8 |
| `${open_vk_on_open}` | 1 |
| `true` | 1 |

### `reposition_twice` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 10 |

### `reset_interval` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `3` | 6 |
| `-1` | 2 |
| `1` | 2 |

### `row_color` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `[darkGrey]` | 6 |
| `[mediumGrey]` | 3 |
| `[white]` | 1 |

### `shape_mesh` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 8 |
| `false` | 2 |

### `silent_on_equip` — seen 10 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 10 |

### `console_enabled` — seen 9 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 9 |

### `force_custom` — seen 9 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 7 |
| `${force_custom}` | 1 |
| `false` | 1 |

### `rotation` — seen 9 times
Top literal values:
| Value | Count |
| --- | --- |
| `90` | 5 |
| `-90` | 2 |
| `45` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{# section_open ? '-90' : '0' }` | 1 |

### `select_tab_contents_on_open` — seen 9 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 7 |
| `false` | 2 |

### `shapes` — seen 9 times
Top literal values:
| Value | Count |
| --- | --- |
| `All` | 8 |
| `Bulletproof` | 1 |

### `spacing_x` — seen 9 times
Top literal values:
| Value | Count |
| --- | --- |
| `2` | 4 |
| `1` | 2 |
| `5` | 2 |
| `4` | 1 |

### `support_bb_code` — seen 9 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 9 |

### `anchor_side` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `bottomright` | 5 |
| `right` | 3 |

### `beard` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 3 |
| `3` | 2 |
| `4` | 2 |
| `2` | 1 |

### `debuff` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `buffArmBroken` | 1 |
| `buffDysenteryMain` | 1 |
| `buffFatigued` | 1 |
| `buffInfection01Untreated,buffInfection02Untreated,buffInfection03Untreated,buffInfection04` | 1 |
| `buffInjuryBleeding` | 1 |
| `buffInjuryConcussion` | 1 |
| `buffLaceration` | 1 |
| `buffLegBroken` | 1 |

### `disablefallthrough` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 8 |

### `link_challenges` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 8 |

### `negative_color` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `255,175,175` | 5 |
| `255,0,0,160` | 3 |

### `phase` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 8 |

### `positive_color` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `175,175,255` | 5 |
| `0,124,0,160` | 3 |

### `questtag` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `infested` | 5 |
| `fetch` | 2 |
| `hidden_cache` | 1 |

### `selectable` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 8 |

### `stat_type` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `ActiveItem` | 1 |
| `Food` | 1 |
| `Health` | 1 |
| `Stamina` | 1 |
| `Stealth` | 1 |
| `VehicleFuel` | 1 |
| `VehicleHealth` | 1 |
| `Water` | 1 |

### `sub_tier` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `Prime` | 2 |
| `Tier1` | 2 |
| `Tier2` | 2 |
| `Tier3` | 2 |

### `type_xb` — seen 8 times
Top literal values:
| Value | Count |
| --- | --- |
| `FeedbackSingle` | 5 |
| `Vibration` | 3 |

### `allow_dropping` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `${allow_dropping}` | 3 |
| `true` | 3 |
| `false` | 1 |

### `allow_key_paging` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 7 |

### `allow_unselect` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 7 |

### `bias` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `20` | 5 |
| `10` | 1 |
| `5` | 1 |

### `chops` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 3 |
| `4` | 3 |
| `3` | 1 |

### `dialog_id` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `trader` | 5 |
| `junkDrone` | 1 |
| `traderTest` | 1 |

### `disabled_tooltip_key` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 3 |
| `${disabled_tooltip_key}` | 3 |
| `xuiMaxProfilesReached` | 1 |

### `faction` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `whiteriver` | 6 |
| `trader` | 1 |

### `gamepad_decrease` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `GUI Page Down` | 3 |
| `${gamepad_decrease}` | 2 |
| `` | 1 |
| `GUI Window Paging Up` | 1 |

### `gamepad_increase` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `GUI Page Up` | 3 |
| `${gamepad_increase}` | 2 |
| `` | 1 |
| `GUI Window Paging Down` | 1 |

### `greeting_type` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `nearby` | 7 |

### `max_count` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `4` | 5 |
| `1` | 1 |
| `100` | 1 |

### `min_count` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `2` | 5 |
| `1` | 1 |
| `5` | 1 |

### `on_return` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `NewLine` | 3 |
| `newline` | 2 |
| `${on_return}` | 1 |
| `submit` | 1 |

### `override_cost` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `1,2,2,3` | 3 |
| `1,2,3` | 2 |
| `1,2,2` | 1 |
| `1,2,2,2,3` | 1 |

### `path` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `@:Sounds/Music/HomeDay.wav` | 1 |
| `@:Sounds/Music/HomeNight.wav` | 1 |
| `@:Sounds/Music/TraderBob.wav` | 1 |
| `@:Sounds/Music/TraderHugh.wav` | 1 |
| `@:Sounds/Music/TraderJen.wav` | 1 |
| `@:Sounds/Music/TraderJoel.wav` | 1 |
| `@:Sounds/Music/TraderRekt.wav` | 1 |

### `portrait` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `npc_hugh` | 2 |
| `npc_joel` | 2 |
| `npc_bob` | 1 |
| `npc_jen` | 1 |
| `npc_rekt` | 1 |

### `prefix_id` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `${prefix_id}` | 3 |
| `false` | 3 |
| `true` | 1 |

### `prerequisite_hint` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `challengeCraftBedrollHint1` | 1 |
| `challengeGatherResourcesStoneAxeHint1` | 1 |
| `challengeGroupCompleteHint1` | 1 |
| `challengePlaceBuildingBlocksHint1` | 1 |
| `challengePlaceCampfireHint1` | 1 |
| `challengeRedeemChallengeHint1` | 1 |
| `challengeUpgradeBlocksHint1` | 1 |

### `run` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 5 |
| `true` | 2 |

### `section` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `HomeDay` | 1 |
| `HomeNight` | 1 |
| `TraderBob` | 1 |
| `TraderHugh` | 1 |
| `TraderJen` | 1 |
| `TraderJoel` | 1 |
| `TraderRekt` | 1 |

### `show_favorites` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `${show_favorites}` | 3 |
| `false` | 3 |
| `true` | 1 |

### `side` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `right` | 4 |
| `left` | 3 |

### `stance` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `Like` | 5 |
| `Dislike` | 1 |
| `Neutral` | 1 |

### `stat_text_key` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `challengeStatBurntShelterDesc` | 1 |
| `challengeStatDesertShelterDesc` | 1 |
| `challengeStatDrinkWaterFromLake` | 1 |
| `challengeStatHarvestHoney` | 1 |
| `challengeStatHomerunDerby` | 1 |
| `challengeStatSnowShelterDesc` | 1 |
| `challengeStatWastelandShelterDesc` | 1 |

### `trader_id` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 2 |
| `2` | 1 |
| `6` | 1 |
| `7` | 1 |
| `8` | 1 |
| `9` | 1 |

### `voice_set` — seen 7 times
Top literal values:
| Value | Count |
| --- | --- |
| `trader_hugh` | 2 |
| `trader` | 1 |
| `trader_bob` | 1 |
| `trader_jen` | 1 |
| `trader_joel` | 1 |
| `trader_rekt` | 1 |

### `biomemapcolor` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `#001234` | 1 |
| `#004000` | 1 |
| `#FFE477` | 1 |
| `#FFFFFF` | 1 |
| `#ba00ff` | 1 |
| `#ffa800` | 1 |

### `close_time` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `21:50` | 6 |

### `compatible_version_color` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `255,216,0` | 5 |
| `[gold]` | 1 |

### `dropdown_lineheight` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `26` | 6 |

### `dropdown_size` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `14` | 5 |
| `10` | 1 |

### `filldirection` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `horizontal` | 4 |
| `Vertical` | 1 |
| `radial360` | 1 |

### `force_hide` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `${simplified}` | 3 |
| `${ !segmented_fill }` | 1 |
| `${ segmented_fill }` | 1 |
| `${not simplified}` | 1 |

### `incompatible_version_color` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `[red]` | 5 |
| `255,0,0` | 1 |

### `localization_id` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `npcTraderBob` | 1 |
| `npcTraderHugh` | 1 |
| `npcTraderJen` | 1 |
| `npcTraderJoel` | 1 |
| `npcTraderRekt` | 1 |
| `npcTraderTest` | 1 |

### `loopOnly` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 6 |

### `matching_version_color` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `60,255,60,128` | 4 |
| `[white]` | 2 |

### `min_level` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 4 |
| `1` | 2 |

### `password_field` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `${password_field}` | 2 |
| `false` | 2 |
| `true` | 2 |

### `quest_list` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `test_quests` | 1 |
| `trader_bob_quests` | 1 |
| `trader_hugh_quests` | 1 |
| `trader_jen_quests` | 1 |
| `trader_joel_quests` | 1 |
| `trader_rekt_quests` | 1 |

### `shake_amplitude` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 3 |
| `20` | 1 |
| `40` | 1 |
| `60` | 1 |

### `shake_speed` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 3 |
| `0.02` | 1 |
| `0.5` | 1 |
| `0.75` | 1 |

### `size_status_icon` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `14` | 3 |
| `20` | 3 |

### `spacing_y` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `5` | 2 |
| `6` | 2 |
| `10` | 1 |
| `4` | 1 |

### `status_icon_indent` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `5` | 3 |
| `8` | 3 |

### `use_ingredient_modifier` — seen 6 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 6 |

### `AudioSourceName` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `@:Sounds/Prefabs/AudioSource_Impact_XSmall.prefab` | 3 |
| `@:Sounds/Prefabs/AudioSource_MotorWeapIdle.prefab` | 1 |
| `@:Sounds/Weapons/Motorized/Auger/AugerAudioSource.prefab` | 1 |

### `clear_selection_on_open` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 5 |

### `color_lbl_available` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `[white]` | 5 |

### `color_lbl_locked` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `[lightGrey]` | 5 |

### `default` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 3 |
| `` | 1 |
| `${default}` | 1 |

### `difficulty` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1 |
| `2` | 1 |
| `3` | 1 |
| `4` | 1 |
| `5` | 1 |

### `dms_section_type` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `TraderBob` | 1 |
| `TraderHugh` | 1 |
| `TraderJen` | 1 |
| `TraderJoel` | 1 |
| `TraderRekt` | 1 |

### `empty_slot_text_key` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `xuiEmptyCosmeticSlot` | 3 |
| `xuiEmptyModifierSlot` | 2 |

### `endPosition` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `7` | 2 |
| `8` | 2 |
| `5` | 1 |

### `failed_icon` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_x` | 5 |

### `gamestage_bonus` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `10` | 2 |
| `0` | 1 |
| `20` | 1 |
| `30` | 1 |

### `gamestage_modifier` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.5` | 2 |
| `0` | 1 |
| `1` | 1 |
| `1.5` | 1 |

### `held` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `meleeToolRepairT0StoneAxe` | 4 |
| `meleeWpnBladeT0BoneKnife` | 1 |

### `lootstage_bonus` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 1 |
| `10` | 1 |
| `15` | 1 |
| `20` | 1 |
| `5` | 1 |

### `lootstage_modifier` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 1 |
| `0.5` | 1 |
| `1` | 1 |
| `1.5` | 1 |
| `2` | 1 |

### `mod_chance` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `.50` | 4 |
| `1` | 1 |

### `mods` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `barrelAttachments,sideAttachments,smallTopAttachments,trigger` | 4 |
| `scope` | 1 |

### `position` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 2 |
| `2` | 2 |
| `5` | 1 |

### `quest_faction` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 5 |

### `required_game_stat` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `BiomeProgression` | 5 |

### `scale` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `1.255` | 2 |
| `.5` | 1 |
| `.65` | 1 |
| `1.25` | 1 |

### `snap` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 5 |

### `sources` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `rfs://News.xml` | 2 |
| `` | 1 |
| `${sources}` | 1 |
| `rfs://NewsFeatured.xml` | 1 |

### `startPosition` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `2` | 3 |
| `0` | 2 |

### `trader_name` — seen 5 times
Top literal values:
| Value | Count |
| --- | --- |
| `npcTraderBob` | 1 |
| `npcTraderHugh` | 1 |
| `npcTraderJen` | 1 |
| `npcTraderJoel` | 1 |
| `npcTraderRekt` | 1 |

### `action_index` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 4 |

### `active_text_color` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `${active_text_color}` | 1 |
| `[labelColor]` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{customnamecolor}` | 1 |
| `{customsizecolor}` | 1 |

### `allow_sell` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 4 |

### `auto_cycle_time_per_entry` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 2 |
| `${auto_cycle_time_per_entry}` | 1 |
| `3` | 1 |

### `biomes` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `wasteland` | 4 |

### `color_bg_available` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `[lightGrey]` | 4 |

### `color_bg_bought` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `140,130,100,255` | 4 |

### `color_bg_locked` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `[darkGrey]` | 4 |

### `color_lbl_buffed` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `17,204,17` | 4 |

### `color_lbl_nerfed` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `204,17,17` | 4 |

### `complete_color` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `[green]` | 3 |
| `[disabledLabelColor]` | 1 |

### `complete_icon` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_check` | 4 |

### `crispness` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `Never` | 3 |
| `${crispness}` | 1 |

### `default_font_color` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `[labelColor]` | 4 |

### `displayname` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 2 |
| `${displayname}` | 2 |

### `dynamic` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 4 |

### `failed_color` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `255,0,0,255` | 4 |

### `file` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `GUI/loading_screen_1` | 1 |
| `GUI/loading_screen_2` | 1 |
| `GUI/loading_screen_3` | 1 |
| `GUI/loading_screen_4` | 1 |

### `has_default` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |
| `${has_default}` | 1 |
| `false` | 1 |

### `height_name` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `20` | 2 |
| `22` | 2 |

### `height_status_text` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `16` | 2 |
| `18` | 2 |

### `hi` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.95` | 2 |
| `0.85` | 1 |
| `1.0` | 1 |

### `hidden_entries_with_paging` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 3 |
| `2` | 1 |

### `index_markers` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 2 |
| `${index_markers}` | 1 |
| `true` | 1 |

### `is_textinput` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |
| `${is_textinput}` | 1 |
| `false` | 1 |

### `lo` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.7` | 1 |
| `0.75` | 1 |
| `0.8` | 1 |
| `0.90` | 1 |

### `max_entries` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `7` | 3 |
| `${max_entries}` | 1 |

### `name_width` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `220` | 3 |
| `200` | 1 |

### `nav_down` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 1 |
| `${nav_down}` | 1 |
| `btnNewGame` | 1 |
| `btnQuit` | 1 |

### `nav_up` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 1 |
| `${nav_up}` | 1 |
| `btnDlc` | 1 |
| `btnQuit` | 1 |

### `objective_text` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `Research the biome and unlock Desert Gear.` | 1 |
| `Research the biome and unlock Radiation Gear.` | 1 |
| `Research the biome and unlock Smoke Gear.` | 1 |
| `Research the biome and unlock Snow Gear.` | 1 |

### `on_drag` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 4 |

### `original_aspect_ratio` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 4 |

### `override_buy_markup` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `1.0` | 2 |
| `3` | 2 |

### `rarity` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 4 |

### `recipes` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `armorHeavyMaster,armorMinerHelmet,armorMinerOutfit,armorMinerGloves,armorMinerBoots,armorNomadHelmet,armorNomadOutfit,armorNomadGloves,armorNomadBoots,armorNerdHelmet,armorNerdOutfit,armorNerdGloves,armorNerdBoots,armorRaiderHelmet,armorRaiderOutfit,armorRaiderGloves,armorRaiderBoots` | 1 |
| `armorLightMaster,armorLumberjackHelmet,armorLumberjackOutfit,armorLumberjackGloves,armorLumberjackBoots,armorPreacherHelmet,armorPreacherOutfit,armorPreacherGloves,armorPreacherBoots,armorRogueHelmet,armorRogueOutfit,armorRogueGloves,armorRogueBoots,armorAthleticHelmet,armorAthleticOutfit,armorAthleticGloves,armorAthleticBoots,armorEnforcerHelmet,armorEnforcerOutfit,armorEnforcerGloves,armorEnforcerBoots` | 1 |
| `armorMediumMaster,armorFarmerHelmet,armorFarmerOutfit,armorFarmerGloves,armorFarmerBoots,armorBikerHelmet,armorBikerOutfit,armorBikerGloves,armorBikerBoots,armorScavengerHelmet,armorScavengerOutfit,armorScavengerGloves,armorScavengerBoots,armorRangerHelmet,armorRangerOutfit,armorRangerGloves,armorRangerBoots,armorCommandoHelmet,armorCommandoOutfit,armorCommandoGloves,armorCommandoBoots,armorAssassinHelmet,armorAssassinOutfit,armorAssassinGloves,armorAssassinBoots` | 1 |
| `armorPrimitiveMaster,armorPrimitiveHelmet,armorPrimitiveOutfit,armorPrimitiveGloves,armorPrimitiveBoots` | 1 |

### `repeat_count` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `${index_markers ? 20 : 1}` | 1 |
| `${segmented_fill ? segments_max : 1}` | 1 |
| `13` | 1 |
| `20` | 1 |

### `samples` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `1058400` | 2 |
| `1092542` | 1 |
| `838337` | 1 |

### `scroll_by_increment` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 2 |
| `${scroll_by_increment}` | 1 |
| `true` | 1 |

### `selected_color` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `222,206,163,255` | 3 |
| `[green]` | 1 |

### `shake_time` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `-1` | 2 |
| `10` | 2 |

### `show_splatter` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 4 |

### `tab_visible` — seen 4 times
Top bindings:
| Binding | Count |
| --- | --- |
| `{# (commsallowed and voiceavailable) or !is_console }` | 1 |
| `{# is_multiplayer and blocked_players_available }` | 1 |
| `{# is_online and commsallowed and multiplayerallowed }` | 1 |
| `{discord_ready}` | 1 |

### `values_enforced` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |
| `${values_enforced}` | 1 |
| `false` | 1 |

### `wrapMode` — seen 4 times
Top literal values:
| Value | Count |
| --- | --- |
| `wrap` | 4 |

### `ChunkMargin` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `7` | 3 |

### `allow_any` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${allow_any}` | 1 |
| `true` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{# !isprefilteredsearch}` | 1 |

### `alternating_color` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `[darkestGrey]` | 3 |

### `always_reposition` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 3 |

### `always_show` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${always_show}` | 1 |
| `false` | 1 |
| `true` | 1 |

### `amplitude` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `5` | 2 |
| `8` | 1 |

### `anchor_offset` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `-10,0` | 3 |

### `anchor_run_once` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 3 |

### `bg_color` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${bg_color}` | 1 |
| `35,31,31` | 1 |
| `[black]` | 1 |

### `blast_power` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 3 |

### `block_damage` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 2 |
| `1000` | 1 |

### `block_radius` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 2 |
| `5` | 1 |

### `button_enabled` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${enabled}` | 2 |
| `true` | 1 |

### `channel_point_title` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `7DTD: 500 PP` | 1 |
| `7DTD: Murder Chicken` | 1 |
| `7DTD: Mystery Supplies` | 1 |

### `channel_point_title_key` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `TwitchEventChannelPointChickenTitle` | 1 |
| `TwitchEventChannelPointMysteryTitle` | 1 |
| `TwitchEventChannelPointPPTitle` | 1 |

### `clear_on_open` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${clear_on_open}` | 1 |
| `false` | 1 |
| `true` | 1 |

### `colorTint` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 3 |

### `cursor_controllable` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 3 |

### `damage_type` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `Special` | 3 |

### `default_min` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 1 |
| `${default_min}` | 1 |
| `1` | 1 |

### `enabled_fill_color` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${enabled_fill_color}` | 1 |
| `[red]` | 1 |
| `[white]` | 1 |

### `entity_damage` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `30` | 3 |

### `entity_radius` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `4` | 3 |

### `frequency` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `128` | 2 |
| `30` | 1 |

### `gradient_end` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${gradient_end}` | 1 |
| `116,116,116` | 1 |
| `71,82,196` | 1 |

### `gradient_start` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${gradient_start}` | 1 |
| `101,113,243` | 1 |
| `135,135,135` | 1 |

### `header_key` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 1 |
| `xuiNewsHeaderFeatured` | 1 |
| `xuiNewsHeaderGame` | 1 |

### `ignore_up_down_keys` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${ignore_up_down_keys}` | 1 |
| `false` | 1 |
| `true` | 1 |

### `incomplete_icon` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_x` | 3 |

### `is_empty` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 3 |

### `items` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 2 |
| `twitchTurd` | 1 |

### `line_count` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1 |
| `2` | 1 |
| `3` | 1 |

### `localization_key_caseinsensitive` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${localization_key_caseinsensitive}` | 1 |
| `false` | 1 |
| `true` | 1 |

### `loop` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 3 |

### `message` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `Bookworm Hit!` | 1 |
| `Drink` | 1 |
| `XP gained during the last level:` | 1 |

### `nav_right` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 1 |
| `${nav_right}` | 1 |
| `btnContinue` | 1 |

### `oneshot` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 3 |

### `poimapcolor` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `#1` | 1 |
| `#2` | 1 |
| `#3` | 1 |

### `rect_offset` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.002,0.002` | 2 |
| `{#compass_rotation / 360 + 0.0625 - 0.125},0` | 1 |

### `rect_size` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.996,0.996` | 2 |
| `0.25,1` | 1 |

### `reference` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `$buffShockedDisplay` | 2 |
| `$shockDurationMax` | 1 |

### `required_held` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 3 |

### `reward_amount` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `250` | 3 |

### `reward_type` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `SP` | 3 |

### `segment_count` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${segment_count}` | 1 |
| `1` | 1 |

Top bindings:
| Binding | Count |
| --- | --- |
| `{news_count}` | 1 |

### `segmented_fill` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${segmented_fill}` | 1 |
| `false` | 1 |
| `true` | 1 |

### `size_width` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `100` | 2 |
| `105` | 1 |

### `sprite_color_default` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `110,0,0,180` | 2 |
| `0,0,0,180` | 1 |

### `sprite_color_hover` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `110,0,0,255` | 2 |
| `0,0,0,255` | 1 |

### `startstatementid` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `start` | 3 |

### `support_urls` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `HTTP` | 2 |
| `Chat,DiscordMessageButton` | 1 |

### `toggle_value` — seen 3 times
Top literal values:
| Value | Count |
| --- | --- |
| `${toggle_value}` | 1 |
| `false` | 1 |
| `true` | 1 |

### `UIAtlas` — seen 2 times
Top bindings:
| Binding | Count |
| --- | --- |
| `{rewardiconatlas}` | 2 |

### `align_right` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |
| `true` | 1 |

### `art_size` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `640` | 1 |
| `700` | 1 |

### `aspect_ratio` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.608` | 1 |
| `2.3` | 1 |

### `attribute` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `Fortitude` | 2 |

### `base_date` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `easter` | 1 |
| `thanksgiving` | 1 |

### `browse_sound` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `@:Sounds/Crafting/craft_click_recipe.wav` | 2 |

### `caption_size` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `50` | 2 |

### `caret_color` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${caret_color}` | 1 |
| `[labelColor]` | 1 |

### `challenge` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `Basics` | 1 |
| `redeemChallenge` | 1 |

### `clearonopen` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${clearonopen}` | 1 |
| `false` | 1 |

### `cost` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `1000` | 1 |
| `500` | 1 |

### `cost_multiplier_per_level` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1 |
| `1.14` | 1 |

### `date_width` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `180` | 2 |

### `default_background_color` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `[mediumGrey]` | 2 |

### `default_max` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 1 |
| `${default_max}` | 1 |

### `default_string` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 1 |
| `${default_string}` | 1 |

### `disabled` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |
| `true` | 1 |

### `disabled_fill_color` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${disabled_fill_color}` | 1 |
| `[lightGrey]` | 1 |

### `display_key` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `weather` | 2 |

### `dropdown_hovercolor` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${dropdown_hovercolor}` | 1 |
| `[tan]` | 1 |

### `dropdown_textcolor` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${dropdown_textcolor}` | 1 |
| `[white]` | 1 |

### `endStrength` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `4` | 2 |

### `fillinvert` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `font_face` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${font_face}` | 1 |
| `ReferenceFont` | 1 |

### `font_size_default` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${height-16}` | 1 |
| `24` | 1 |

### `font_size_hover` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${height-12}` | 1 |
| `24` | 1 |

### `gamepad_callout_size_increase` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 1 |
| `8` | 1 |

### `global_cooldown` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `5` | 1 |
| `900` | 1 |

### `highlight_color` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `[lightGrey]` | 1 |
| `[selectedColor]` | 1 |

### `hoveredcolor` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `[selectedColor]` | 2 |

### `inactive_color` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `[darkGrey]` | 1 |
| `[lightGrey]` | 1 |

### `invalid_font_color` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `[red]` | 2 |

### `invert_tag_check` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `is_buy` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |
| `true` | 1 |

### `is_redeemed` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `is_serverbrowser` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `is_twitch_spawn` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `keep_aspect_ratio` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `BasedOnHeight` | 2 |

### `killed_has_bufftag` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `twitch_bighead` | 1 |
| `twitch_tiny` | 1 |

### `left_panel_valign_top` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 2 |

### `lobby_type` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `global` | 1 |
| `party` | 1 |

### `manualcolors` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `match_all_tags` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `max_distance` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `10` | 2 |

### `max_per_user_per_stream` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1 |
| `3` | 1 |

### `modifier` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `base_add` | 1 |
| `perc_add` | 1 |

### `nav_left` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 1 |
| `${nav_left}` | 1 |

### `needed_resource` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `resourceCobblestones` | 1 |
| `resourceWood` | 1 |

### `needed_resource_count` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `10` | 1 |
| `8` | 1 |

### `override_sell_markup` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `1.0` | 2 |

### `per_page` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1 |
| `4` | 1 |

### `primary_pager` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${primary_pager}` | 1 |
| `true` | 1 |

### `quest_tag` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `nexttrader` | 1 |
| `tiercomplete` | 1 |

### `quest_text_key` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `challengeTargetTierCompleteQuest` | 1 |
| `quest_next_trader` | 1 |

### `redeem_always` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |
| `true` | 1 |

### `required_tools` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `toolBellows,toolAnvil,toolForgeCrucible` | 1 |
| `toolCookingPot,toolCookingGrill,toolBeaker` | 1 |

### `required_tools_only` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `reset_skills` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `segment_spacing` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${segment_spacing}` | 1 |
| `10` | 1 |

### `selection_color` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${selection_color}` | 1 |
| `[mediumGrey_half_alpha]` | 1 |

### `separator` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${separator}` | 1 |
| `/` | 1 |

### `sequence_link` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `resurrect` | 2 |

### `show_max_page` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${show_max_page}` | 1 |
| `false` | 1 |

### `show_type` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `BiomeProgression` | 1 |
| `twitch` | 1 |

### `simplified` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |
| `true` | 1 |

### `sortentries` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `${sortentries}` | 1 |
| `true` | 1 |

### `spacing` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `10` | 1 |
| `60` | 1 |

### `stackpanel_scale` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `1.05` | 2 |

### `startStrength` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `2` | 2 |

### `start_date` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `10/31` | 1 |
| `12/25` | 1 |

### `start_offset` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `-2` | 1 |
| `-4` | 1 |

### `strengths` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `3,2,6,5,4,8,2,1,8,8,` | 1 |
| `8,7,6,5,4,3,2,1,8,8,` | 1 |

### `toggle_dms` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `update_position` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 2 |

### `usesmarkers` — seen 2 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 2 |

### `active_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[white]` | 1 |

### `addDegrees` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 1 |

### `allow_client_call` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `allow_in_editor` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `allow_point_generation` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `allow_remove_item` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `alternate_item` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `meleeToolTorch` | 1 |

### `always_show_in_menu` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `biome_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[green]` | 1 |

### `biome_icon` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_foliage` | 1 |

### `bordersprite` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `menu_empty2px` | 1 |

### `boss_vote_setting` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `Disabled` | 1 |

### `boss_vote_settings` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `Daily` | 1 |

### `button_older` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `GUI Window Paging Down` | 1 |

### `button_younger` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `GUI Window Paging Up` | 1 |

### `buy_markup` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `3` | 1 |

### `can_zoom` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `chat_activity_time` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `300` | 1 |

### `clamp_exp_cost_at_level` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `60` | 1 |

### `clippingcenter` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `356,-356` | 1 |

### `clippingsize` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `712,712` | 1 |

### `col_available` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `52,52,52,255` | 1 |

### `col_pending` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `251,188,4,255` | 1 |

### `col_required` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `234,67,53,255` | 1 |

### `col_selected` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `52,168,83,255` | 1 |

### `col_used` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `74,86,90,255` | 1 |

### `combo_enabled` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `${enabled}` | 1 |

### `complete_sound` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_mag_read_set` | 1 |

### `cond` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `event('christmas')` | 1 |

### `cooldown_add` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `20` | 1 |

### `costcolor` — seen 1 times
Top bindings:
| Binding | Count |
| --- | --- |
| `{actioncostcolor}` | 1 |

### `currency_item` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `casinoCoin` | 1 |

### `daysAliveChangeWhenKilled` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `2` | 1 |

### `defaultDescriptionKey` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `creativeMenuBlockGroupDesc` | 1 |

### `default_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[labelColor]` | 1 |

### `default_cost_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[white]` | 1 |

### `default_health_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `255,0,0,128` | 1 |

### `default_reward` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `challenge_reward_default` | 1 |

### `default_reward_text_key` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `challenge_reward_100xp` | 1 |

### `defaultsprite` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `menu_empty` | 1 |

### `denied_crate_event` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `action_cratedenied` | 1 |

### `desc_base` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `Non localized modder descriptions go here` | 1 |

### `difficultyBonus` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `1.2` | 1 |

### `difficulty_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[red]` | 1 |

### `difficulty_icon` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_skull` | 1 |

### `diminishingReturns` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.5` | 1 |

### `disable_tracking` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `distance` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `6` | 1 |

### `element_padding_over_label` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `60` | 1 |

### `end_date` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `01/02` | 1 |

### `end_offset` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `2` | 1 |

### `evaluator` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `client` | 1 |

### `exp_to_level` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `10000` | 1 |

### `experience_multiplier` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `1.05` | 1 |

### `fade_delay` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.02` | 1 |

### `fade_window` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `fadeout_duration` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `2` | 1 |

### `fadeout_wait_time` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `5` | 1 |

### `finished_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `0,255,0,255` | 1 |

### `finished_icon` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_check` | 1 |

### `gamestat` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `BiomeProgression` | 1 |

### `height_bar` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `20` | 1 |

### `height_legend` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `24` | 1 |

### `height_title` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `26` | 1 |

### `hide_gamepad_callouts` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `hide_helper_in_creative` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `hight` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `46` | 1 |

### `hotkeys_enabled` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `hovered_font_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[hoverColor]` | 1 |

### `hyperbar-length` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `4` | 1 |

### `ignore_missing_class` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `incomplete_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[red]` | 1 |

### `invalid_materials_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[red]` | 1 |

### `invert` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `is_block` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `is_group` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `item_tags` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `csm` | 1 |

### `list_style` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `chat` | 1 |

### `locked_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[selectedColor]` | 1 |

### `locked_sprite` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_lock` | 1 |

### `lootBonusEvery` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `12` | 1 |

### `lootBonusMaxCount` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `30` | 1 |

### `lootBonusScale` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `25` | 1 |

### `lootWanderingBonusEvery` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `3` | 1 |

### `lootWanderingBonusScale` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `15` | 1 |

### `lp_width` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `180` | 1 |

### `massScale` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `.013` | 1 |

### `materials_accepted` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `iron,brass,lead,glass,stone,clay` | 1 |

### `max_entities` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `25` | 1 |

### `max_level_ratio_to_parent` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `5` | 1 |

### `max_quest_tier` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `6` | 1 |

### `move_start_bottom_left` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `nonsub_pp_cap` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `1000` | 1 |

### `notstarted_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[white]` | 1 |

### `notstarted_icon` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_quest` | 1 |

### `on_death_event` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `action_ondeath` | 1 |

### `on_player_respawn_event` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `action_ontwitchrespawn` | 1 |

### `override_stack_count` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1 |

### `override_text_key` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `xuiMagazine` | 1 |

### `party_kill_reward_max` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `250` | 1 |

### `party_respawn_event` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `buff_respawn` | 1 |

### `pimp_pot_default` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `500` | 1 |

### `pimp_pot_type` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `SP` | 1 |

### `play_at_self` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `player_owned` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `poi_tier_bonus` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `3,6,9,12,15` | 1 |

### `poi_tier_mod` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.05,0.1,0.15,0.2,0.25` | 1 |

### `pp_add_amount` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `500` | 1 |

### `prefix_first_line` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `` | 1 |

### `property` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `WalkType` | 1 |

### `quality_mod` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `1,2` | 1 |

### `quest_limited_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[red]` | 1 |

### `quest_limited_complete_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[white]` | 1 |

### `quest_tier_mod` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `0,0.05,0.1,0.15,0.2,0.25,0.3` | 1 |

### `quests_per_tier` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `10` | 1 |

### `ray_cast_moving` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `0` | 1 |

### `rent_cost` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `2500` | 1 |

### `rent_time` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `30` | 1 |

### `rentable` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `required_item` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `drinkJarEmpty` | 1 |

### `required_mods` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `toolDewGatherer,toolDewTarp,toolDewFilter` | 1 |

### `required_mods_only` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `reset_books` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `reset_crafting` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `reset_levels` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `sample-rate` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `44100` | 1 |

### `saves_width` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `125` | 1 |

### `scaleY` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `-1.5` | 1 |

### `segment_height` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `15` | 1 |

### `segments_max` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `20` | 1 |

### `select_contents_on_change` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `sell_markdown` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `0.2` | 1 |

### `shared_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[iconColor]` | 1 |

### `shared_icon` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_players` | 1 |

### `show_command_list` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `show_new_commands` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `show_requirements` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `sig-hi` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `6` | 1 |

### `sig-lo` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `4` | 1 |

### `skill_points_per_level` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1 |

### `slider_min_width` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `250` | 1 |

### `sound_play_on_press` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `spawn_sound` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `@:Sounds/UI/ui_spawn.wav` | 1 |

### `special_cost_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[selectedColor]` | 1 |

### `startingWeight` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `1` | 1 |

### `starting_cooldown_allowed` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `stealing_crate_event` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `action_cratesteal` | 1 |

### `sub_pp_cap` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `2000` | 1 |

### `tempo` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `60` | 1 |

### `text_bad` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `255,175,175` | 1 |

### `thumbareasize` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `${dropdown_size*dropdown_lineheight-64}` | 1 |

### `tracker_index` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `challenge_stump` | 1 |

### `twitch_health_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `100,65,165,128` | 1 |

### `unique_item` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `unlocked_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[disabledLabelColor]` | 1 |

### `unlocked_sprite` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `ui_game_symbol_unlock` | 1 |

### `use_helper_reward` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `false` | 1 |

### `valid_materials_color` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `[green]` | 1 |

### `values_from_gameserverconfig` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `true` | 1 |

### `visibility` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `godmode` | 1 |

### `visible_quest_count` — seen 1 times
Top bindings:
| Binding | Count |
| --- | --- |
| `{# questsautoaccept ? 14 : 9}` | 1 |

### `volume` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `7` | 1 |

### `width_legend` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `120` | 1 |

### `width_swatch` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `20` | 1 |

### `windows_to_open_globally` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `menuBackground,mainMenuDiscordButton,-discordInteractions` | 1 |

### `world_width` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `125` | 1 |

### `xp_fill_speed` — seen 1 times
Top literal values:
| Value | Count |
| --- | --- |
| `2.5` | 1 |


---
_This cheat‑sheet is empirical — it reflects what's in the scanned files (vanilla + any installed mods). Different game versions may add more._
