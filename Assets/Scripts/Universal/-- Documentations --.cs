/*
FONTS

PIXELATED ELEGANCE FONT

Font:       Text_PixelatedElegance
Materials:  PixelatedEleganceRegular-ovawB Atlas Material
Character Select
├── CanvasCharacterSelect
│   └── CharacterStatsHolder
│       └── TextHolderBox
│           ├── TextStats
│           ├── TextStatsTwo
│           ├── TextStatsThree
│           ├── TextVals
│           ├── TextValsTwo
│           └── TextValsThree
└── CanvasSettings
    ├── GraphicsSettingsHolder
    │   └── DropdownResolution
    │       ├── Label
    │       └── Template
    │           └── Viewport
    │               └── Content
    │                   └── Item
    │                       └── Item Label
    └── CreditsSettingsHolder
        └── ScrollViewCredits
            └── Viewport
                └── Content
                    └── TextCredits
Game Screen
├── CanvasGameScreen
│   ├── DataHolder
│   │   └── CalendarHolder
│   │       ├── TextYear
│   │       └── TextTime
│   ├── UpdatesHolder
│   │   ├── ItemBoundaryBox
│   │   │   ├── TextBoundaryBox
│   │   │   │   ├── TextUpdateSubtitle
│   │   │   │   ├── TextUpdate
│   │   │   │   └── TextUpdateTwo
│   │   │   └── ActionPanel
│   │   │       ├── ResourcesHolder
│   │   │       │   ├── MilitaryHolder
│   │   │       │   │   └── TextMilitary
│   │   │       │   ├── InfluenceHolder
│   │   │       │   │   └── TextInfluence
│   │   │       │   ├── MoneyHolder
│   │   │       │   │   └── TextMoney
│   │   │       │   └── TimeHolder
│   │   │       │       └── TextTime
│   │   │       └── TextDescription
│   │   └── NotifBoundaryBox
│   │       └── TextBoundaryBox
│   │           ├── TextNotifOne
│   │           ├── TextNotifTwo
│   │           ├── TextNotifThree
│   │           └── TextNotifFour
│   ├── ElectionHolder
│   │   └── MembersHolder
│   │       └── CandidatePrefab (x4)
│   │           ├── ResourcesHolder
│   │           │   └── TextBoundaryBox
│   │           │       └── TextVoters
│   │           └── TextOverall
│   └── NewspaperHolder
│       ├── TextBoundaryBox
│       │   ├── TextUpdateSubtitle
│       │   ├── TextUpdate
│       │   └── TextUpdateTwo
│       └── ChoicesHolder
│           ├── ButtonChoiceOne
│           │   └── TextChoice
│           └── ButtonChoiceTwo
│               └── TextChoice
└── CanvasSettings
    ├── GraphicsSettingsHolder
    │   └── DropdownResolution
    │       ├── Label
    │       └── Template
    │           └── Viewport
    │               └── Content
    │                   └── Item
    │                       └── Item Label
    └── CreditsSettingsHolder
        └── ScrollViewCredits
            └── Viewport
                └── Content
                    └── TextCredits
Lose Scene
├── CanvasLose
│   └── TextDescription
└── CanvasSettings
    ├── GraphicsSettingsHolder
    │   └── DropdownResolution
    │       ├── Label
    │       └── Template
    │           └── Viewport
    │               └── Content
    │                   └── Item
    │                       └── Item Label
    └── CreditsSettingsHolder
        └── ScrollViewCredits
            └── Viewport
                └── Content
                    └── TextCredits
Main Menu
├── CanvasMenu
│   └── TextBoundingBox
│       └── TextSubtitle
└── CanvasSettings
    ├── GraphicsSettingsHolder
    │   └── DropdownResolution
    │       ├── Label
    │       └── Template
    │           └── Viewport
    │               └── Content
    │                   └── Item
    │                       └── Item Label
    └── CreditsSettingsHolder
        └── ScrollViewCredits
            └── Viewport
                └── Content
                    └── TextCredits
Win Scene
└── CanvasSettings
    ├── GraphicsSettingsHolder
    │   └── DropdownResolution
    │       ├── Label
    │       └── Template
    │           └── Viewport
    │               └── Content
    │                   └── Item
    │                       └── Item Label
    └── CreditsSettingsHolder
        └── ScrollViewCredits
            └── Viewport
                └── Content
                    └── TextCredits

RASTER FORGE FONT

Font:       Title_RasterForge
Materials:  RasterForgeRegular-JpBgm Atlas Material
Character Select
└── CanvasSettings
    ├── MainSettingsHolder
    │   ├── TextGraphics
    │   ├── TextAudio
    │   ├── TextCredits
    │   └── TextExit
    ├── GraphicsSettingsHolder
    │   ├── TextResolution
    │   └── ToggleFullscreen
    │       └── TextFullscreen
    └── AudioSettingsHolder
        ├── TextMain
        ├── TextMusic
        └── TextSfx
Game Screen
├── CanvasGameScreen
│   ├── DataHolder
│   │   ├── SafetyHolder
│   │   │   └── TextClass
│   │   └── ResourcesHolder
│   │       ├── MilitaryHolder
│   │       │   └── TextBoundingBox
│   │       │       └── TextMilitaryValue
│   │       ├── InfluenceHolder
│   │       │   └── TextBoundingBox
│   │       │       └── TextInfluenceValue
│   │       └── MoneyHolder
│   │           └── TextBoundingBox
│   │               └── TextMoneyValue
│   ├── UpdatesHolder
│   │   └── ItemBoundaryBox
│   │       └── ActionPanel
│   │           └── TitleBoundaryBox
│   │               └── TextBoundingBox
│   │                   └── TextActionName
│   ├── -- TestRemove --
│   │   ├── KarmaButtons
│   │   │   ├── Good
│   │   │   │   └── TextBoundingBox
│   │   │   │       └── TextRunTitle
│   │   │   ├── Neutral
│   │   │   │   └── TextBoundingBox
│   │   │   │       └── TextRunTitle
│   │   │   └── Evil
│   │   │       └── TextBoundingBox
│   │   │           └── TextRunTitle
│   │   └── ElectionButtons
│   │       ├── Election
│   │       │   └── TextBoundingBox
│   │       │       └── TextRunTitle
│   │       └── Campaign
│   │           └── TextBoundingBox
│   │               └── TextRunTitle
│   └── CampaignHolder
│       └── RankingsHolder
│           └── OverallHolder
│               └── TextRank
└── CanvasSettings
    ├── MainSettingsHolder
    │   ├── TextGraphics
    │   ├── TextAudio
    │   ├── TextCredits
    │   └── TextExit
    ├── GraphicsSettingsHolder
    │   ├── TextResolution
    │   └── ToggleFullscreen
    │       └── TextFullscreen
    └── AudioSettingsHolder
        ├── TextMain
        ├── TextMusic
        └── TextSfx
Lose Scene
├── CanvasLose
│   └── TextLose
└── CanvasSettings
    ├── MainSettingsHolder
    │   ├── TextGraphics
    │   ├── TextAudio
    │   ├── TextCredits
    │   └── TextExit
    ├── GraphicsSettingsHolder
    │   ├── TextResolution
    │   └── ToggleFullscreen
    │       └── TextFullscreen
    └── AudioSettingsHolder
        ├── TextMain
        ├── TextMusic
        └── TextSfx
Main Menu
├── CanvasMenu
│   ├── ButtonRun
│   │   └── TextBoundingBox
│   │       └── TextRunTitle
│   ├── ButtonContinue
│   │   └── TextBoundingBox
│   │       └── TextRunTitle
│   └── ButtonResign
│       └── TextBoundingBox
│           └── TextRunTitle
└── CanvasSettings
    ├── MainSettingsHolder
    │   ├── TextGraphics
    │   ├── TextAudio
    │   ├── TextCredits
    │   └── TextExit
    ├── GraphicsSettingsHolder
    │   ├── TextResolution
    │   └── ToggleFullscreen
    │       └── TextFullscreen
    └── AudioSettingsHolder
        ├── TextMain
        ├── TextMusic
        └── TextSfx
Win Scene
├── CanvasWin
│   ├── ButtonReturn
│   │   └── TextBoundingBox
│   │       └── TextRunTitle
│   └── TextWin
└── CanvasSettings
    ├── MainSettingsHolder
    │   ├── TextGraphics
    │   ├── TextAudio
    │   ├── TextCredits
    │   └── TextExit
    ├── GraphicsSettingsHolder
    │   ├── TextResolution
    │   └── ToggleFullscreen
    │       └── TextFullscreen
    └── AudioSettingsHolder
        ├── TextMain
        ├── TextMusic
        └── TextSfx
=================================================================================================
Materials:  Title_RasterForge - Outline
Character Select
└── CanvasCharacterSelect
    └── CharacterStatsHolder
        └── TextName
Main Menu
└── CanvasMenu
    └── TextBoundingBox
        └── TextTitle
=================================================================================================
Materials:  Title_RasterForge - Outline 1
Game Screen
└── CanvasGameScreen
    └── ElectionHolder
        └── TitleHolder
            └── TextTitle

SOUNDS
AudioMaster/Music
├── Credits_Music
│   ├── Character Select : CanvasSettings
│   ├── Game Screen : CanvasSettings
│   ├── Lose Scene : CanvasSettings
│   ├── Main Menu : CanvasSettings
│   └── Win Scene : CanvasSettings
├── Game_Music
│   └── Game Screen : AudioSourceMusic
├── Lose_Music
│   └── Lose Scene : AudioSourceMusic
├── Main_Music
│   ├── Main Menu : AudioSourceMusic
│   └── Character Select : AudioSourceMusic
└── Win_Music
    └── Win Scene : AudioSourceMusic
=================================================================================================
AudioMaster/SFX
├── action_fail
│   └── Game Screen : CanvasGameScreen/ActionsHolder/ButtonsHolder/ButtonActionPrefab (x35)
├── action_success
│   └── Game Screen : CanvasGameScreen/ActionsHolder/ButtonsHolder/ButtonActionPrefab (x35)
├── button_click
│   ├── Character Select : CanvasCharacterSelect/ButtonLeft
│   ├── Character Select : CanvasCharacterSelect/ButtonRight
│   ├── Character Select : CanvasCharacterSelect/ButtonResign
│   ├── Character Select : CanvasCharacterSelect/ButtonRun
│   ├── Character Select : CanvasCharacterSelect/ButtonSettings
│   ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonGraphics
│   ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonAudio
│   ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonCredits
│   ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonExit
│   ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonMenu
│   ├── Character Select : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics
│   ├── Character Select : CanvasSettings/GraphicsSettingsHolder/DropdownResolution
│   ├── Character Select : CanvasSettings/AudioSettingsHolder/ButtonAudio
│   └── Character Select : CanvasSettings/CreditsSettingsHolder/ButtonCredits
│   ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Good
│   ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Neutral
│   ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Evil
│   ├── Game Screen : CanvasGameScreen/-- TestRemove --/ElectionButtons/Election
│   ├── Game Screen : CanvasGameScreen/-- TestRemove --/ElectionButtons/Campaign
│   ├── Game Screen : CanvasGameScreen/ElectionHolder/ButtonClose
│   ├── Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonChoiceOne
│   ├── Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonChoiceTwo
│   ├── Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonClose
│   ├── Game Screen : CanvasGameScreen/CampaignHolder/ButtonMove
│   ├── Game Screen : CanvasGameScreen/CampaignHolder/ButtonClose
│   ├── Game Screen : CanvasGameScreen/ButtonSettings
│   ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonGraphics
│   ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonAudio
│   ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonCredits
│   ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonExit
│   ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonMenu
│   ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics
│   ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/DropdownResolution
│   ├── Game Screen : CanvasSettings/AudioSettingsHolder/ButtonAudio
│   └── Game Screen : CanvasSettings/CreditsSettingsHolder/ButtonCredits
│   ├── Lose Scene : CanvasLose/ButtonReturn
│   ├── Lose Scene : CanvasLose/ButtonExit
│   ├── Lose Scene : CanvasLose/ButtonSettings
│   ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics
│   ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonAudio
│   ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonCredits
│   ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonExit
│   ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonMenu
│   ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics
│   ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution
│   ├── Lose Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio
│   └── Lose Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits
│   ├── Main Menu : CanvasMenu/ButtonRun
│   ├── Main Menu : CanvasMenu/ButtonContinue
│   ├── Main Menu : CanvasMenu/ButtonResign
│   ├── Main Menu : CanvasMenu/ButtonSettings
│   ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonGraphics
│   ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonAudio
│   ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonCredits
│   ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonExit
│   ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonMenu
│   ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics
│   ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/DropdownResolution
│   ├── Main Menu : CanvasSettings/AudioSettingsHolder/ButtonAudio
│   └── Main Menu : CanvasSettings/CreditsSettingsHolder/ButtonCredits
│   ├── Win Scene : CanvasWin/ButtonReturn
│   ├── Win Scene : CanvasWin/ButtonSettings
│   ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics
│   ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonAudio
│   ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonCredits
│   ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonExit
│   ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonMenu
│   ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics
│   ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution
│   ├── Win Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio
│   └── Win Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits
├── canvas_close
│   ├── Character Select : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics
│   ├── Character Select : CanvasSettings/AudioSettingsHolder/ButtonAudio
│   └── Character Select : CanvasSettings/CreditsSettingsHolder/ButtonCredits
│   ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics
│   ├── Game Screen : CanvasSettings/AudioSettingsHolder/ButtonAudio
│   └── Game Screen : CanvasSettings/CreditsSettingsHolder/ButtonCredits
│   ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics
│   ├── Lose Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio
│   └── Lose Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits
│   ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics
│   ├── Main Menu : CanvasSettings/AudioSettingsHolder/ButtonAudio
│   └── Main Menu : CanvasSettings/CreditsSettingsHolder/ButtonCredits
│   ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics
│   ├── Win Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio
│   └── Win Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits
├── canvas_open
│   ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonGraphics
│   ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonAudio
│   ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonCredits
│   └── Character Select : CanvasSettings/MainSettingsHolder/ButtonMenu
│   ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonGraphics
│   ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonAudio
│   ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonCredits
│   └── Game Screen : CanvasSettings/MainSettingsHolder/ButtonMenu
│   ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics
│   ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonAudio
│   ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonCredits
│   └── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonMenu
│   ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonGraphics
│   ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonAudio
│   ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonCredits
│   └── Main Menu : CanvasSettings/MainSettingsHolder/ButtonMenu
│   ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics
│   ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonAudio
│   ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonCredits
│   └── Win Scene : CanvasSettings/MainSettingsHolder/ButtonMenu
├── dropdown
│   ├── Character Select : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template
│   ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template
│   ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template
│   ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template
│   └── Win Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template
├── event_notif
│   └── Game Screen : CanvasGameScreen/UpdatesHolder
├── lose_election
│   └── Game Screen : CanvasGameScreen/ElectionHolder/TitleHolder   [ElectionController.cs]
├── pause_in
│   ├── Character Select : CanvasCharacterSelect/ButtonSettings
│   ├── Game Screen : CanvasGameScreen/ButtonSettings
│   ├── Lose Scene : CanvasLose/ButtonSettings
│   ├── Main Menu : CanvasMenu/ButtonSettings
│   └── Win Scene : CanvasWin/ButtonSettings
├── pause_out
│   ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonExit
│   ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonExit
│   ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonExit
│   ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonExit
│   └── Win Scene : CanvasSettings/MainSettingsHolder/ButtonExit
├── tally_votes
│   └── Game Screen : CanvasGameScreen/ElectionHolder
├── toggle
│   ├── Character Select : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen
│   ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen
│   ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen
│   ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen
│   └── Win Scene : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen
├── warning
│   └── Game Screen : CanvasGameScreen/CampaignHolder
└── win_election
    └── Game Screen : CanvasGameScreen/ElectionHolder/TitleHolder   [ElectionController.cs]CampaignHolder

SPRITES
[[  Project Settings/Player/Default Icon  ]]
IconImage
└── IconImage_0
=================================================================================================
FLOOD
├── FLOOD_BORDER
│   ├── Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ImageBoundaryBox/ImageBorderTest   > Image
│   ├── Game Screen : CanvasGameScreen/NewspaperHolder/ImageBoundaryBox/ImageBorderTest                 > Image
│   ├── Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonChoiceOne/ImageBackground    > Image
│   ├── Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonChoiceTwo/ImageBackground    > Image
│   └── Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonClose/ImageTemplate          > Image
└── FLOOD_TITLE
    ├── Game Screen : CanvasGameScreen/NewspaperHolder/ImageBoundaryBox/ImageTitleTest                  > Image
    └── Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ImageBoundaryBox/ImageTitleTest    > Image
=================================================================================================
[[  Game Screen : CanvasGameScreen/ActionsHolder/ButtonsHolder > ActionsPageHandler ]]
Actions/
├── assassination
│   └── assassination
├── assign_workers
│   └── assign_workers
├── bribe_locals
│   └── bribe_locals
├── build_barracks
│   └── build_barracks
├── build_farm
│   └── build_farm
├── build_mine
│   └── build_mine
├── build_wall
│   └── build_wall
├── drug_party
│   └── drug_party
├── drug_war
│   └── drug_war
├── fake_news
│   └── fake_news
├── free_tarpaulin
│   └── free_tarpaulin
├── ghost_project
│   └── ghost_project
├── hide_overseas
│   └── hide_overseas
├── hire_police
│   └── hire_police
├── hire_soldiers
│   └── hire_soldiers
├── online_trolls
│   └── online_trolls
├── pork_barrel
│   └── pork_barrel
├── porn_movie
│   └── porn_movie
├── road_repair
│   └── road_repair
├── start_trade
│   └── start_trade
├── suitcase
│   └── suitcase
├── tandem_riding
│   └── tandem_riding
├── tv_dance
│   └── tv_dance
└── upgrade_castle
    └── upgrade_castle
=================================================================================================
Animations/
│   [[  Assets/Resources/Sprites/Animations/BG/Background Animated.controller  ]]
├── BG/
│   ├── basebg.anim
│   ├── corruptedbg.anim
│   └── shadowbg.anim
│   [[  Assets/Resources/Sprites/Animations/BG/MascotAnimated.controller  ]]
├── Character/
│   ├── base.anim
│   ├── baseidle.anim
│   ├── corrupted.anim
│   ├── corruptedidle.anim
│   ├── shadow.anim
│   └── shadowidle.anim
│   [[  Assets/Resources/Sprites/Animations/BG/base.anim  ]]
│   [[  Assets/Resources/Sprites/Animations/BG/baseidle.anim  ]]
├── basesheet
│   ├── basesheet 1_0
│   ├── basesheet 1_1
│   ├── basesheet 1_2
│   ├── basesheet 1_3
│   ├── basesheet 1_4
│   └── basesheet 1_5
│   [[  Assets/Resources/Sprites/Animations/BG/basebg.anim  ]]
├── bgbasesheet
│   ├── basesheet_0
│   ├── basesheet_1
│   ├── basesheet_2
│   ├── basesheet_3
│   ├── basesheet_4
│   └── basesheet_5
│   [[  Assets/Resources/Sprites/Animations/BG/corruptedbg.anim  ]]
├── bgcorruptedsheet
│   ├── corruptedsheet_0
│   ├── corruptedsheet_1
│   ├── corruptedsheet_2
│   ├── corruptedsheet_3
│   ├── corruptedsheet_4
│   └── corruptedsheet_5
│   [[  Assets/Resources/Sprites/Animations/BG/shadowbg.anim  ]]
├── bgshadowsheet
│   ├── shadowsheet_0
│   ├── shadowsheet_1
│   ├── shadowsheet_2
│   ├── shadowsheet_3
│   ├── shadowsheet_4
│   └── shadowsheet_5
│   [[  Assets/Resources/Sprites/Animations/BG/corrupted.anim  ]]
│   [[  Assets/Resources/Sprites/Animations/BG/corruptedidle.anim  ]]
├── corruptedsheet
│   ├── corruptedsheet_0
│   ├── corruptedsheet_1
│   ├── corruptedsheet_2
│   ├── corruptedsheet_3
│   ├── corruptedsheet_4
│   └── corruptedsheet_5
│   [[  Assets/Resources/Sprites/Animations/BG/shadow.anim  ]]
│   [[  Assets/Resources/Sprites/Animations/BG/shadowidle.anim  ]]
└── shadowsheet
    ├── basesheet_0
    ├── basesheet_1
    ├── basesheet_2
    ├── basesheet_3
    ├── basesheet_4
    └── basesheet_5
=================================================================================================
[[  Game Screen : CanvasGameScreen/ElectionHolder > Election Controller  ]]
[[  Prefabs/CandidatePrefab.prefab  ]]
Character Select/
├── Action_Star
│   └── Action_Star_0
│       └── Assets/Scripts/Scriptables/Characters/ActionStar
├── Bhaby_mE
│   └── Bhaby_mE_0
│       └── Assets/Scripts/Scriptables/Characters/BhabymE
├── Father_D
│   └── Father_D_0
│       └── Assets/Scripts/Scriptables/Characters/FatherD
└── Rocky
    └── Rocky_0
        └── Assets/Scripts/Scriptables/Characters/Rocky
=================================================================================================
[[  Game Screen : CanvasGameScreen/ElectionHolder > Election Controller  ]]
[[  Game Screen : CanvasGameScreen/ElectionHolder/ImageResult > Image  ]]
Election/
├── lose_election
│   └── twilight_0
└── win_election
    ├── star_0
    └── star_1
=================================================================================================
Icons/
├── Locations/
│   ├── cloud
│   │   └── cloud_0
│   │       └── 
│   ├── midnight
│   │   └── midnight_0
│   │       └── 
│   ├── night
│   │   └── night_0
│   │       └── 
│   ├── star
│   │   ├── star_0
│   │   │   └── 
│   │   └── star_1
│   │       └── 
│   ├── sun
│   │   └── sun_0
│   │       └── 
│   ├── sunrise
│   │   └── sunrise_0
│   │       └── 
│   ├── sunset
│   │   └── sunset_0
│   │       └── 
│   └── twilight
│       └── twilight_0
│           └── 
├── Resources/
│   ├── influence
│   │   └── influence_0
│   │       ├── Game Screen : CanvasGameScreen/DataHolder/ResourcesHolder/InfluenceHolder/ImageBoundingBox/ImageSprite                  > Image
│   │       ├── Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ActionPanel/ResourcesHolder/InfluenceHolder/ImageInfluence > Image
│   │       └── Game Screen : CanvasGameScreen/CampaignHolder/RankingsHolder/InfluenceHolder/ImageResource                              > Image
│   ├── military
│   │   └── military_0
│   │       ├── Game Screen : CanvasGameScreen/DataHolder/ResourcesHolder/MilitaryHolder/ImageBoundingBox/ImageSprite                   > Image
│   │       ├── Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ActionPanel/ResourcesHolder/MilitaryHolder/ImageMilitary   > Image
│   │       └── Game Screen : CanvasGameScreen/CampaignHolder/RankingsHolder/MilitaryHolder/ImageResource                               > Image
│   ├── money
│   │   └── money_0
│   │       ├── Game Screen : CanvasGameScreen/DataHolder/ResourcesHolder/MoneyHolder/ImageBoundingBox/ImageSprite                      > Image
│   │       ├── Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ActionPanel/ResourcesHolder/MoneyHolder/ImageMoney         > Image
│   │       └── Game Screen : CanvasGameScreen/CampaignHolder/RankingsHolder/MoneyHolder/ImageResource                                  > Image
│   └── overall
│       └── overall
│           ├── Game Screen : CanvasGameScreen/CampaignHolder/RankingsHolder/OverallHolder/ImageBoundingBox/ImageLeft                   > Image
│           └── Game Screen : CanvasGameScreen/CampaignHolder/RankingsHolder/OverallHolder/ImageBoundingBox/ImageRight                  > Image
│   [[  Game Screen : CanvasGameScreen/DataHolder > DataTracker  ]]
│   [[  Game Screen : CanvasGameScreen/DataHolder/SafetyHolder/ImageCharacter > Image  ]]
├── Safety/
│   ├── Action_Star/
│   │   ├── 0
│   │   │   └── 0-Action_Star_0
│   │   ├── 1
│   │   │   └── 1-Action_Star_0
│   │   ├── 2
│   │   │   └── 2-Action_Star_0
│   │   └── 3
│   │       └── 3-Action_Star_0
│   ├── Bhaby_mE/
│   │   ├── 0
│   │   │   └── 0-Bhaby_mE_0
│   │   ├── 1
│   │   │   └── 1-Bhaby_mE_0
│   │   ├── 2
│   │   │   └── 2-Bhaby_mE_0
│   │   └── 3
│   │       └── 3-Bhaby_mE_0
│   ├── Father_D/
│   │   ├── 0
│   │   │   └── 0-Father_D_0
│   │   ├── 1
│   │   │   └── 1-Father_D_0
│   │   ├── 2
│   │   │   └── 2-Father_D_0
│   │   └── 3
│   │       └── 3-Father_D_0
│   └── Rocky/
│       ├── 0
│       │   └── 0-Rocky_0
│       ├── 1
│       │   └── 1-Rocky_0
│       ├── 2
│       │   └── 2-Rocky_0
│       └── 3
│           └── 3-Rocky_0
│   [[  Game Screen : CanvasGameScreen/DataHolder > DataTracker  ]]
│   [[  Game Screen : CanvasGameScreen/DataHolder/SatisfactionHolder/ImageSatisfaction > Image  ]]
├── Satisfaction/
│   ├── 0-Happy
│   │   └── 0-Happy
│   ├── 1-Smile
│   │   └── 1-Smile
│   ├── 2-Neutral
│   │   └── 2-Neutral
│   ├── 3-Sad
│   │   └── 3-Sad
│   └── 4-Angry
│       └── 4-Angry
│   [[  Game Screen : CanvasGameScreen/UpdatesHolder > Updates Tracker  ]]
│   [[  Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ImageIcon > Image  ]]
│   [[  Game Screen : CanvasGameScreen/NewspaperHolder > Newspaper Tracker  ]]
│   [[  Game Screen : CanvasGameScreen/NewspaperHolder/ImageIcon > Image  ]]
├── Updates/
│   ├── assassination
│   │   └── assassination
│   ├── assign_workers
│   │   └── assign_workers
│   ├── bribe_locals
│   │   └── bribe_locals
│   ├── build_barracks
│   │   └── build_barracks
│   ├── build_farm
│   │   └── build_farm
│   ├── build_mine
│   │   └── build_mine
│   ├── build_wall
│   │   └── build_wall
│   ├── drug_party
│   │   └── drug_party
│   ├── drug_war
│   │   └── drug_war
│   ├── fake_news
│   │   └── fake_news
│   ├── free_tarpaulin
│   │   └── free_tarpaulin
│   ├── ghost_project
│   │   └── ghost_project
│   ├── hide_overseas
│   │   └── hide_overseas
│   ├── hire_police
│   │   └── hire_police
│   ├── hire_soldiers
│   │   └── hire_soldiers
│   ├── online_trolls
│   │   └── online_trolls
│   ├── pork_barrel
│   │   └── pork_barrel
│   ├── porn_movie
│   │   └── porn_movie
│   ├── road_repair
│   │   └── road_repair
│   ├── start_trade
│   │   └── start_trade
│   ├── suitcase
│   │   └── suitcase
│   ├── tandem_riding
│   │   └── tandem_riding
│   ├── tv_dance
│   │   └── tv_dance
│   └── upgrade_castle
│       └── upgrade_castle
└── calendar
    └── calendar_0
        ├── Game Screen : CanvasGameScreen/DataHolder/CalendarHolder/ImageSprite                                                        > Image
        └── Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ActionPanel/ResourcesHolder/TimeHolder/ImageTime               > Image
=================================================================================================
Main Menu/
├── Resign/
│   ├── exit-off
│   │   └── exit-off_0
│   │       └── Character Select : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageBoundingBox/ImageSprite    > Image
│   │       └── Game Screen : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageBoundingBox/ImageSprite         > Image
│   │       └── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageBoundingBox/ImageSprite          > Image
│   │       ├── Main Menu : CanvasMenu/ButtonResign/ImageBoundingBox/ImageSprite                                > Image
│   │       └── Main Menu : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageBoundingBox/ImageSprite           > Image
│   │       └── Win Scene : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageBoundingBox/ImageSprite           > Image
│   └── exit-on
│       └── exit-on_0
│           └── Character Select : CanvasSettings/MainSettingsHolder/ButtonMenu                                 > Button
│           └── Game Screen : CanvasSettings/MainSettingsHolder/ButtonMenu                                      > Button
│           └── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonMenu                                       > Button
│           ├── Main Menu : CanvasMenu/ButtonResign                                                             > Button
│           └── Main Menu : CanvasSettings/MainSettingsHolder/ButtonMenu                                        > Button
│           └── Win Scene : CanvasSettings/MainSettingsHolder/ButtonMenu                                        > Button
├── Run/
│   ├── play-off
│   │   └── play-off_0
│           ├── Lose Scene : CanvasLose/ButtonReturn/ImageBoundingBox/ImageSprite                               > Image
│   │       └── Main Menu : CanvasMenu/ButtonRun/ImageBoundingBox/ImageSprite                                   > Image
│   └── play-on
│       └── play-on_0
│           └── Lose Scene : CanvasLose/ButtonReturn                                                            > Button
│           ├── Main Menu : CanvasMenu/ButtonRun                                                                > Button
│           ├── Main Menu : CanvasMenu/ButtonContinue                                                           > Button
│           └── Main Menu : CanvasMenu/ButtonContinue/ImageBoundingBox/ImageSprite                              > Image
└── bg-backup
    └── bg-backup_0
        └── Main Menu : CanvasMenu/ImageBoundingBox/ImageTitle                                                  > Image
=================================================================================================
Settings/
├── Audio/
│   ├── audio-off
│   │   └── audio-off 1_0
│   │       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageBoundingBox/ImageSprite           > Image
│   │       └── Character Select : CanvasSettings/AudioSettingsHolder/ButtonAudio                                       > Button
│   │       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageBoundingBox/ImageSprite                > Image
│   │       └── Game Screen : CanvasSettings/AudioSettingsHolder/ButtonAudio                                            > Button
│   │       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageBoundingBox/ImageSprite                 > Image
│   │       └── Lose Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio                                             > Button
│   │       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageBoundingBox/ImageSprite                  > Image
│   │       └── Main Menu : CanvasSettings/AudioSettingsHolder/ButtonAudio                                              > Button
│   │       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageBoundingBox/ImageSprite                  > Image
│   │       └── Win Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio                                              > Button
│   └── audio-on
│       └── audio-on 1_0
│           ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonAudio                                        > Button
│           └── Character Select : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageBoundingBox/ImageSprite          > Image
│           ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonAudio                                             > Button
│           └── Game Screen : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageBoundingBox/ImageSprite               > Image
│           ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonAudio                                              > Button
│           └── Lose Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageBoundingBox/ImageSprite                > Image
│           ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonAudio                                               > Button
│           └── Main Menu : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageBoundingBox/ImageSprite                 > Image
│           ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonAudio                                               > Button
│           └── Win Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageBoundingBox/ImageSprite                 > Image
├── Credits/
│   ├── credits-off
│   │   └── credits-off_0
│   │       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageBoundingBox/ImageSprite         > Image
│   │       └── Character Select : CanvasSettings/CreditsSettingsHolder/ButtonCredits                                   > Button
│   │       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageBoundingBox/ImageSprite              > Image
│   │       └── Game Screen : CanvasSettings/CreditsSettingsHolder/ButtonCredits                                        > Button
│   │       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageBoundingBox/ImageSprite               > Image
│   │       └── Lose Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits                                         > Button
│   │       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageBoundingBox/ImageSprite                > Image
│   │       └── Main Menu : CanvasSettings/CreditsSettingsHolder/ButtonCredits                                          > Button
│   │       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageBoundingBox/ImageSprite                > Image
│   │       └── Win Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits                                          > Button
│   └── credits-on
│       └── credits-on_0
│           ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonCredits                                      > Button
│           └── Character Select : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageBoundingBox/ImageSprite      > Image
│           ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonCredits                                           > Button
│           └── Game Screen : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageBoundingBox/ImageSprite           > Image
│           ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonCredits                                            > Button
│           └── Lose Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageBoundingBox/ImageSprite            > Image
│           ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonCredits                                             > Button
│           └── Main Menu : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageBoundingBox/ImageSprite             > Image
│           ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonCredits                                             > Button
│           └── Win Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageBoundingBox/ImageSprite             > Image
├── Exit/
│   ├── close
│   │   └── close_0
│   │       └── Character Select : CanvasSettings/MainSettingsHolder/ButtonExit/ImageBoundingBox/ImageSprite            > Image
│   │       ├── Game Screen : CanvasGameScreen/ElectionHolder/ButtonClose/ImageBoundingBox/ImageSprite                  > Image
│   │       ├── Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonClose/ImageBoundingBox/ImageSprite    > Image
│   │       └── Game Screen : CanvasSettings/MainSettingsHolder/ButtonExit/ImageBoundingBox/ImageSprite                 > Image
│   │       ├── Lose Scene : CanvasLose/ButtonExit/ImageBoundingBox/ImageSprite                                         > Image
│   │       └── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonExit/ImageBoundingBox/ImageSprite                  > Image
│   │       └── Main Menu : CanvasSettings/MainSettingsHolder/ButtonExit/ImageBoundingBox/ImageSprite                   > Image
│   │       └── Win Scene : CanvasSettings/MainSettingsHolder/ButtonExit/ImageBoundingBox/ImageSprite                   > Image
│   └── close-highlight
│       └── close-highlight_0
│           └── Character Select : CanvasSettings/MainSettingsHolder/ButtonExit                                         > Button
│           ├── Game Screen : CanvasGameScreen/ElectionHolder/ButtonClose                                               > Button
│           ├── Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonClose                                 > Button
│           └── Game Screen : CanvasSettings/MainSettingsHolder/ButtonExit                                              > Button
│           ├── Lose Scene : CanvasLose/ButtonExit/                                                                     > Button
│           └── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonExit                                               > Button
│           └── Main Menu : CanvasSettings/MainSettingsHolder/ButtonExit                                                > Button
│           └── Win Scene : CanvasSettings/MainSettingsHolder/ButtonExit                                                > Button
├── Graphics/
│   ├── graphics-off
│   │   └── graphics-off_0
│   │       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageBoundingBox/ImageSprite        > Image
│   │       └── Character Select : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics                                 > Button
│   │       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageBoundingBox/ImageSprite             > Image
│   │       └── Game Screen : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics                                      > Button
│   │       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageBoundingBox/ImageSprite              > Image
│   │       └── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics                                       > Button
│   │       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageBoundingBox/ImageSprite               > Image
│   │       └── Main Menu : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics                                        > Button
│   │       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageBoundingBox/ImageSprite               > Image
│   │       └── Win Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics                                        > Button
│   └── graphics-on
│       └── graphics-on_0
│           ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonGraphics                                     > Button
│           └── Character Select : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageBoundingBox/ImageSprite    > Image
│           ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonGraphics                                          > Button
│           └── Game Screen : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageBoundingBox/ImageSprite         > Image
│           ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics                                           > Button
│           └── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageBoundingBox/ImageSprite          > Image
│           ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonGraphics                                            > Button
│           └── Main Menu : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageBoundingBox/ImageSprite           > Image
│           ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics                                            > Button
│           └── Win Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageBoundingBox/ImageSprite           > Image
├── settings
│   └── settings_0
│       └── Character Select : CanvasCharacterSelect/ButtonSettings/ImageBoundingBox/ImageSprite                        > Image
│       └── Game Screen : CanvasGameScreen/ButtonSettings/ImageBoundingBox/ImageSprite                                  > Image
│       └── Lose Scene : CanvasMenu/ButtonSettings/ImageBoundingBox/ImageSprite                                         > Image
│       └── Main Menu : CanvasLose/ButtonSettings/ImageBoundingBox/ImageSprite                                          > Image
│       └── Win Scene : CanvasWin/ButtonSettings/ImageBoundingBox/ImageSprite                                           > Image
└── settings-hover
    └── settings-hover_0
        └── Character Select : CanvasCharacterSelect/ButtonSettings                                                     > Button
        └── Game Screen : CanvasGameScreen/ButtonSettings                                                               > Button
        └── Lose Scene : CanvasLose/ButtonSettings                                                                      > Button
        └── Main Menu : CanvasMenu/ButtonSettings                                                                       > Button
        └── Win Scene : CanvasWin/ButtonSettings                                                                        > Button
=================================================================================================
[[  Character Select : Main Camera (MainCameraPrefab) > Cursor Manager ]]
[[  Game Screen : Main Camera (MainCameraPrefab) > Cursor Manager ]]
[[  Lose Scene : Main Camera (MainCameraPrefab) > Cursor Manager ]]
[[  Main Menu : Main Camera (MainCameraPrefab) > Cursor Manager ]]
[[  Win Scene : Main Camera (MainCameraPrefab) > Cursor Manager ]]
UI/Cursor/
├── ActionClick
├── ActionHover
├── ButtonClick
├── ButtonHover
├── Default
├── Disabled
├── LocationClick
├── LocationHover
├── SliderClick
└── SliderHover
=================================================================================================
UI/
├── button-bg
│   └── button-bg_0
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageButtonFill                                         > Image
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageButtonFill                                            > Image
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageButtonFill                                          > Image
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonExit/ImageButtonFill                                             > Image
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageButtonFill                                             > Image
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageButtonFill                                     > Image
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/ImageFill                                       > Image
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template                                        > Image
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Viewport/Content/Item/Item Background  > Image
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageButtonFill                                           > Image
│       └── Character Select : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageButtonFill                                       > Image
│       ├── Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ActionPanel/TitleBoundaryBox/ImageTitleFill                    > Image
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Good/ImageButtonFill                                           > Image
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Neutral/ImageButtonFill                                        > Image
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Evil/ImageButtonFill                                           > Image
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/ElectionButtons/Election/ImageButtonFill                                    > Image
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/ElectionButtons/Campaign/ImageButtonFill                                    > Image
│       ├── Game Screen : CanvasGameScreen/ElectionHolder/ButtonClose/ImageButtonFill                                                   > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageButtonFill                                              > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageButtonFill                                                 > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageButtonFill                                               > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonExit/ImageButtonFill                                                  > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageButtonFill                                                  > Image
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageButtonFill                                          > Image
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/ImageFill                                            > Image
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template                                             > Image
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Viewport/Content/Item/Item Background       > Image
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageButtonFill                                                > Image
│       └── Game Screen : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageButtonFill                                            > Image
│       ├── Lose Scene : CanvasLose/ButtonReturn/ImageButtonFill                                                                        > Image
│       ├── Lose Scene : CanvasLose/ButtonExit/ImageButtonFill                                                                          > Image
│       ├── Lose Scene : CanvasLose/ButtonSettings/ImageButtonFill                                                                      > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageButtonFill                                               > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageButtonFill                                                  > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageButtonFill                                                > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonExit/ImageButtonFill                                                   > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageButtonFill                                                   > Image
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageButtonFill                                           > Image
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/ImageFill                                             > Image
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template                                              > Image
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Viewport/Content/Item/Item Background        > Image
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageButtonFill                                                 > Image
│       └── Lose Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageButtonFill                                             > Image
│       ├── Main Menu : CanvasMenu/ButtonRun/ImageButtonFill                                                                            > Image
│       ├── Main Menu : CanvasMenu/ButtonContinue/ImageButtonFill                                                                       > Image
│       ├── Main Menu : CanvasMenu/ButtonResign/ImageButtonFill                                                                         > Image
│       ├── Main Menu : CanvasMenu/ButtonSettings/ImageButtonFill                                                                       > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageButtonFill                                                > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageButtonFill                                                   > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageButtonFill                                                 > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonExit/ImageButtonFill                                                    > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageButtonFill                                                    > Image
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageButtonFill                                            > Image
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/ImageFill                                              > Image
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template                                               > Image
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Viewport/Content/Item/Item Background         > Image
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageButtonFill                                                  > Image
│       └── Main Menu : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageButtonFill                                              > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageButtonFill                                                > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageButtonFill                                                   > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageButtonFill                                                 > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonExit/ImageButtonFill                                                    > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageButtonFill                                                    > Image
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageButtonFill                                            > Image
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/ImageFill                                              > Image
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template                                               > Image
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Viewport/Content/Item/Item Background         > Image
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageButtonFill                                                  > Image
│       └── Win Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageButtonFill                                              > Image
├── button-border
│   └── button-border_0
│       ├── Character Select : CanvasCharacterSelect/ImageBorder                                                                        > Image
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageButtonBorder                                       > Image
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageButtonBorder                                          > Image
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageButtonBorder                                        > Image
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonExit/ImageButtonBorder                                           > Image
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageButtonBorder                                           > Image
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageButtonBorder                                   > Image
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/ImageBorder                                     > Image
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageButtonBorder                                         > Image
│       └── Character Select : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageButtonBorder                                     > Image
│       ├── Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ActionPanel/TitleBoundaryBox/ImageTitleBorder                  > Image
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Good/ImageButtonBorder                                         > Image
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Neutral/ImageButtonBorder                                      > Image
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Evil/ImageButtonBorder                                         > Image
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/ElectionButtons/Election/ImageButtonBorder                                  > Image
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/ElectionButtons/Campaign/ImageButtonBorder                                  > Image
│       ├── Game Screen : CanvasGameScreen/ElectionHolder/ButtonClose/ImageButtonBorder                                                 > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageButtonBorder                                            > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageButtonBorder                                               > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageButtonBorder                                             > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonExit/ImageButtonBorder                                                > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageButtonBorder                                                > Image
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageButtonBorder                                        > Image
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/ImageBorder                                          > Image
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageButtonBorder                                              > Image
│       └── Game Screen : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageButtonBorder                                          > Image
│       ├── Lose Scene : CanvasLose/ButtonReturn/ImageButtonBorder                                                                      > Image
│       ├── Lose Scene : CanvasLose/ButtonExit/ImageButtonBorder                                                                        > Image
│       ├── Lose Scene : CanvasLose/ButtonSettings/ImageButtonBorder                                                                    > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageButtonBorder                                             > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageButtonBorder                                                > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageButtonBorder                                              > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonExit/ImageButtonBorder                                                 > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageButtonBorder                                                 > Image
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageButtonBorder                                         > Image
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/ImageBorder                                           > Image
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageButtonBorder                                               > Image
│       └── Lose Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageButtonBorder                                           > Image
│       ├── Main Menu : CanvasMenu/ButtonRun/ImageButtonBorder                                                                          > Image
│       ├── Main Menu : CanvasMenu/ButtonContinue/ImageButtonBorder                                                                     > Image
│       ├── Main Menu : CanvasMenu/ButtonResign/ImageButtonBorder                                                                       > Image
│       ├── Main Menu : CanvasMenu/ButtonSettings/ImageButtonBorder                                                                     > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageButtonBorder                                              > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageButtonBorder                                                 > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageButtonBorder                                               > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonExit/ImageButtonBorder                                                  > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageButtonBorder                                                  > Image
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageButtonBorder                                          > Image
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/ImageBorder                                            > Image
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageButtonBorder                                                > Image
│       └── Main Menu : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageButtonBorder                                            > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics/ImageButtonBorder                                              > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonAudio/ImageButtonBorder                                                 > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonCredits/ImageButtonBorder                                               > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonExit/ImageButtonBorder                                                  > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonMenu/ImageButtonBorder                                                  > Image
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics/ImageButtonBorder                                          > Image
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/ImageBorder                                            > Image
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio/ImageButtonBorder                                                > Image
│       └── Win Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits/ImageButtonBorder                                            > Image
├── button-disabled
│   └── disabled_0
│       ├── Character Select : CanvasCharacterSelect/ButtonLeft                                                                         > Button
│       ├── Character Select : CanvasCharacterSelect/ButtonRight                                                                        > Button
│       ├── Character Select : CanvasCharacterSelect/ButtonSettings                                                                     > Button
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonGraphics                                                         > Button
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonAudio                                                            > Button
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonCredits                                                          > Button
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonExit                                                             > Button
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ButtonMenu                                                             > Button
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics                                                     > Button
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/ButtonAudio                                                           > Button
│       └── Character Select : CanvasSettings/CreditsSettingsHolder/ButtonCredits                                                       > Button
│       ├── Game Screen : CanvasGameScreen/ActionsHolder/ButtonsHolder/ButtonActionPrefab (x35)                                         > Button
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Good                                                           > Button
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Neutral                                                        > Button
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/KarmaButtons/Evil                                                           > Button
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/ElectionButtons/Election                                                    > Button
│       ├── Game Screen : CanvasGameScreen/-- TestRemove --/ElectionButtons/Campaign                                                    > Button
│       ├── Game Screen : CanvasGameScreen/ElectionHolder/ButtonClose                                                                   > Button
│       ├── Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonChoiceOne                                                > Button
│       ├── Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonChoiceTwo                                                > Button
│       ├── Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonClose                                                    > Button
│       ├── Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonMove                                                      > Button
│       ├── Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonClose                                                     > Button
│       ├── Game Screen : CanvasGameScreen/ButtonSettings                                                                               > Button
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonGraphics                                                              > Button
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonAudio                                                                 > Button
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonCredits                                                               > Button
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonExit                                                                  > Button
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ButtonMenu                                                                  > Button
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics                                                          > Button
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/ButtonAudio                                                                > Button
│       └── Game Screen : CanvasSettings/CreditsSettingsHolder/ButtonCredits                                                            > Button
│       ├── Lose Scene : CanvasLose/ButtonReturn                                                                                        > Button
│       ├── Lose Scene : CanvasLose/ButtonSettings                                                                                      > Button
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics                                                               > Button
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonAudio                                                                  > Button
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonCredits                                                                > Button
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonExit                                                                   > Button
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ButtonMenu                                                                   > Button
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics                                                           > Button
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio                                                                 > Button
│       └── Lose Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits                                                             > Button
│       ├── Main Menu : CanvasMenu/ButtonRun                                                                                            > Button
│       ├── Main Menu : CanvasMenu/ButtonContinue                                                                                       > Button
│       ├── Main Menu : CanvasMenu/ButtonResign                                                                                         > Button
│       ├── Main Menu : CanvasMenu/ButtonSettings                                                                                       > Button
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonGraphics                                                                > Button
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonAudio                                                                   > Button
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonCredits                                                                 > Button
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonExit                                                                    > Button
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ButtonMenu                                                                    > Button
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics                                                            > Button
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/ButtonAudio                                                                  > Button
│       └── Main Menu : CanvasSettings/CreditsSettingsHolder/ButtonCredits                                                              > Button
│       ├── Win Scene : CanvasWin/ButtonSettings                                                                                        > Button
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonGraphics                                                                > Button
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonAudio                                                                   > Button
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonCredits                                                                 > Button
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonExit                                                                    > Button
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ButtonMenu                                                                    > Button
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/ButtonGraphics                                                            > Button
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/ButtonAudio                                                                  > Button
│       └── Win Scene : CanvasSettings/CreditsSettingsHolder/ButtonCredits                                                              > Button
├── button-slide 1
│   └── button-slide 1
│       └── Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonMove/ImageBoundingBox/ImageSprite                         > Image
├── button-slided
│   └── button-slided
│       └── Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonMove                                                      > Button
├── canvas-bg
│   └── canvas-bg_0
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ImageFill                                                              > Image
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/ImageFill                                                          > Image
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Scrollbar                              > Image
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/ImageFill                                                             > Image
│       └── Character Select : CanvasSettings/CreditsSettingsHolder/ImageFill                                                           > Image
│       ├── Game Screen : CanvasGameScreen/ActionsHolder/ButtonsHolder/ButtonActionPrefab (x35)/ImageButtonFill                         > Image
│       ├── Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ActionPanel/ImageButtonFill                                    > Image
│       ├── Game Screen : CanvasGameScreen/ElectionHolder/ImageFill                                                                     > Image
│       ├── Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonMove/ImageButtonFill                                      > Image
│       ├── Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonClose/ImageButtonFill                                     > Image
│       ├── Game Screen : CanvasGameScreen/CampaignHolder/RankingsHolder/ImageFill                                                      > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ImageFill                                                                   > Image
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/ImageFill                                                               > Image
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Scrollbar                                   > Image
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/ImageFill                                                                  > Image
│       └── Game Screen : CanvasSettings/CreditsSettingsHolder/ImageFill                                                                > Image
│       ├── Lose Scene : CanvasLose/ImageFill                                                                                           > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ImageFill                                                                    > Image
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ImageFill                                                                > Image
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Scrollbar                                    > Image
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/ImageFill                                                                   > Image
│       └── Lose Scene : CanvasSettings/CreditsSettingsHolder/ImageFill                                                                 > Image
│       ├── Main Menu : CanvasMenu/ImageFill                                                                                            > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ImageFill                                                                     > Image
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/ImageFill                                                                 > Image
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Scrollbar                                     > Image
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/ImageFill                                                                    > Image
│       └── Main Menu : CanvasSettings/CreditsSettingsHolder/ImageFill                                                                  > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ImageFill                                                                     > Image
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/ImageFill                                                                 > Image
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Scrollbar                                     > Image
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/ImageFill                                                                    > Image
│       └── Win Scene : CanvasSettings/CreditsSettingsHolder/ImageFill                                                                  > Image
├── canvas-border
│   └── canvas-border
│       ├── Character Select : CanvasMenu/ImageBorder                                                                                   > Image
│       ├── Character Select : CanvasSettings/MainSettingsHolder/ImageBorder                                                            > Image
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/ImageBorder                                                        > Image
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/ImageBorder                                                           > Image
│       └── Character Select : CanvasSettings/CreditsSettingsHolder/ImageBorder                                                         > Image
│       ├── Game Screen : CanvasGameScreen/ActionsHolder/ButtonsHolder/ButtonActionPrefab (x35)/ImageButtonBorder                       > Image
│       ├── Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ActionPanel/ImageButtonBorder                                  > Image
│       ├── Game Screen : CanvasGameScreen/ImageBorder                                                                                  > Image
│       ├── Game Screen : CanvasMenu/ImageBorder                                                                                        > Image
│       ├── Game Screen : CanvasSettings/MainSettingsHolder/ImageBorder                                                                 > Image
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/ImageBorder                                                             > Image
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/ImageBorder                                                                > Image
│       └── Game Screen : CanvasSettings/CreditsSettingsHolder/ImageBorder                                                              > Image
│       ├── Lose Scene : CanvasLose/ImageBorder                                                                                         > Image
│       ├── Lose Scene : CanvasMenu/ImageBorder                                                                                         > Image
│       ├── Lose Scene : CanvasSettings/MainSettingsHolder/ImageBorder                                                                  > Image
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ImageBorder                                                              > Image
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/ImageBorder                                                                 > Image
│       └── Lose Scene : CanvasSettings/CreditsSettingsHolder/ImageBorder                                                               > Image
│       ├── Main Menu : CanvasMenu/ImageBorder                                                                                          > Image
│       ├── Main Menu : CanvasSettings/MainSettingsHolder/ImageBorder                                                                   > Image
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/ImageBorder                                                               > Image
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/ImageBorder                                                                  > Image
│       └── Main Menu : CanvasSettings/CreditsSettingsHolder/ImageBorder                                                                > Image
│       ├── Win Scene : CanvasMenu/ImageBorder                                                                                          > Image
│       ├── Win Scene : CanvasSettings/MainSettingsHolder/ImageBorder                                                                   > Image
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/ImageBorder                                                               > Image
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/ImageBorder                                                                  > Image
│       └── Win Scene : CanvasSettings/CreditsSettingsHolder/ImageBorder                                                                > Image
├── canvas-slice
│   └── canvas-slice_0
│       ├── Game Screen : CanvasGameScreen/ActionsHolder/ImageFill                                                                      > Image
│       └── Game Screen : CanvasGameScreen/DataHolder/ImageFill                                                                         > Image
├── dropdown-arrow
│   └── dropdown-arrow_0
│       ├── Character Select : CanvasCharacterSelect/ButtonLeft/ImageBoundingBox/ImageSprite                                            > Image
│       ├── Character Select : CanvasCharacterSelect/ButtonRight/ImageBoundingBox/ImageSprite                                           > Image
│       └── Character Select : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Arrow                                           > Image
│       └── Game Screen : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Arrow                                                > Image
│       └── Lose Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Arrow                                                 > Image
│       └── Main Menu : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Arrow                                                  > Image
│       └── Win Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Arrow                                                  > Image
├── dropdown-check
│   └── dropdown-check_0
│       ├── Character Select : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Viewport/Content/Item/Item Checkmark   > Image
│       └── Character Select : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen/Background/Checkmark                              > Image
│       ├── Game Screen : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Viewport/Content/Item/Item Checkmark        > Image
│       └── Game Screen : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen/Background/Checkmark                                   > Image
│       ├── Lose Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Viewport/Content/Item/Item Checkmark         > Image
│       └── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen/Background/Checkmark                                    > Image
│       ├── Main Menu : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Viewport/Content/Item/Item Checkmark          > Image
│       └── Main Menu : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen/Background/Checkmark                                     > Image
│       ├── Win Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Viewport/Content/Item/Item Checkmark          > Image
│       └── Win Scene : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen/Background/Checkmark                                     > Image
├── dropdown-handle
│   └── dropdown-handle_0
│       └── Character Select : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Scrollbar/Sliding Area/Handle          > Image
│       └── Game Screen : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Scrollbar/Sliding Area/Handle               > Image
│       └── Lose Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Scrollbar/Sliding Area/Handle                > Image
│       └── Main Menu : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Scrollbar/Sliding Area/Handle                 > Image
│       └── Win Scene : CanvasSettings/GraphicsSettingsHolder/DropdownResolution/Template/Scrollbar/Sliding Area/Handle                 > Image
├── flames
│   └── flames_0
│       └── Game Screen : CanvasGameScreen/ElectionHolder/TitleHolder/ImageFire                                                         > Image
├── light-border
│   └── light-border
│       ├── Game Screen : CanvasGameScreen/ElectionHolder/ImageBorder                                                                   > Image
│       ├── Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonMove/ImageButtonBorder                                    > Image
│       ├── Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonClose/ImageButtonBorder                                   > Image
│       └── Game Screen : CanvasGameScreen/CampaignHolder/ImageBorder                                                                   > Image
├── shade-border
│   └── shade-border_0
│       ├── Game Screen : CanvasGameScreen/ActionsHolder/ImageBorder                                                                    > Image
│       └── Game Screen : CanvasGameScreen/DataHolder/ImageBorder                                                                       > Image
├── slider-bg
│   └── slider-fill_0
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/SliderMain/Background                                                 > Image
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/SliderMusic/Background                                                > Image
│       └── Character Select : CanvasSettings/AudioSettingsHolder/SliderSfx/Background                                                  > Image
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/SliderMain/Background                                                      > Image
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/SliderMusic/Background                                                     > Image
│       └── Game Screen : CanvasSettings/AudioSettingsHolder/SliderSfx/Background                                                       > Image
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/SliderMain/Background                                                       > Image
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/SliderMusic/Background                                                      > Image
│       └── Lose Scene : CanvasSettings/AudioSettingsHolder/SliderSfx/Background                                                        > Image
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/SliderMain/Background                                                        > Image
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/SliderMusic/Background                                                       > Image
│       └── Main Menu : CanvasSettings/AudioSettingsHolder/SliderSfx/Background                                                         > Image
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/SliderMain/Background                                                        > Image
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/SliderMusic/Background                                                       > Image
│       └── Win Scene : CanvasSettings/AudioSettingsHolder/SliderSfx/Background                                                         > Image
├── slider-fill
│   └── slider-fill_0
│       ├── Character Select : CanvasCharacterSelect/ImageFill                                                                          > Image
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/SliderMain/Fill Area/Fill                                             > Image
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/SliderMusic/Fill Area/Fill                                            > Image
│       └── Character Select : CanvasSettings/AudioSettingsHolder/SliderSfx/Fill Area/Fill                                              > Image
│       ├── Game Screen : CanvasGameScreen/ImageFill                                                                                    > Image
│       ├── Game Screen : CanvasGameScreen/DataHolder/ResourcesHolder/MilitaryHolder/ImageFill                                          > Image
│       ├── Game Screen : CanvasGameScreen/DataHolder/ResourcesHolder/InfluenceHolder/ImageFill                                         > Image
│       ├── Game Screen : CanvasGameScreen/DataHolder/ResourcesHolder/MoneyHolder/ImageFill                                             > Image
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/SliderMain/Fill Area/Fill                                                  > Image
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/SliderMusic/Fill Area/Fill                                                 > Image
│       └── Game Screen : CanvasSettings/AudioSettingsHolder/SliderSfx/Fill Area/Fill                                                   > Image
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/SliderMain/Fill Area/Fill                                                   > Image
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/SliderMusic/Fill Area/Fill                                                  > Image
│       └── Lose Scene : CanvasSettings/AudioSettingsHolder/SliderSfx/Fill Area/Fill                                                    > Image
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/SliderMain/Fill Area/Fill                                                    > Image
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/SliderMusic/Fill Area/Fill                                                   > Image
│       └── Main Menu : CanvasSettings/AudioSettingsHolder/SliderSfx/Fill Area/Fill                                                     > Image
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/SliderMain/Fill Area/Fill                                                    > Image
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/SliderMusic/Fill Area/Fill                                                   > Image
│       └── Win Scene : CanvasSettings/AudioSettingsHolder/SliderSfx/Fill Area/Fill                                                     > Image
├── slider-handle
│   └── slider-handle_0
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/SliderMain/Handle Slide Area/Handle                                   > Image
│       ├── Character Select : CanvasSettings/AudioSettingsHolder/SliderMusic/Handle Slide Area/Handle                                  > Image
│       └── Character Select : CanvasSettings/AudioSettingsHolder/SliderSfx/Handle Slide Area/Handle                                    > Image
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/SliderMain/Handle Slide Area/Handle                                        > Image
│       ├── Game Screen : CanvasSettings/AudioSettingsHolder/SliderMusic/Handle Slide Area/Handle                                       > Image
│       └── Game Screen : CanvasSettings/AudioSettingsHolder/SliderSfx/Handle Slide Area/Handle                                         > Image
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/SliderMain/Handle Slide Area/Handle                                         > Image
│       ├── Lose Scene : CanvasSettings/AudioSettingsHolder/SliderMusic/Handle Slide Area/Handle                                        > Image
│       └── Lose Scene : CanvasSettings/AudioSettingsHolder/SliderSfx/Handle Slide Area/Handle                                          > Image
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/SliderMain/Handle Slide Area/Handle                                          > Image
│       ├── Main Menu : CanvasSettings/AudioSettingsHolder/SliderMusic/Handle Slide Area/Handle                                         > Image
│       └── Main Menu : CanvasSettings/AudioSettingsHolder/SliderSfx/Handle Slide Area/Handle                                           > Image
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/SliderMain/Handle Slide Area/Handle                                          > Image
│       ├── Win Scene : CanvasSettings/AudioSettingsHolder/SliderMusic/Handle Slide Area/Handle                                         > Image
│       └── Win Scene : CanvasSettings/AudioSettingsHolder/SliderSfx/Handle Slide Area/Handle                                           > Image
├── toggle-box
│   └── toggle-box_0
│       └── Character Select : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen/Background                                        > Image
│       └── Game Screen : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen/Background                                             > Image
│       └── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen/Background                                              > Image
│       └── Main Menu : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen/Background                                               > Image
│       └── Win Scene : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen/Background                                               > Image
└── toggle-hover
    └── toggle-hover_0
        └── Character Select : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen                                                   > Toggle
        └── Game Screen : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen                                                        > Toggle
        └── Lose Scene : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen                                                         > Toggle
        └── Main Menu : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen                                                          > Toggle
        └── Win Scene : CanvasSettings/GraphicsSettingsHolder/ToggleFullscreen                                                          > Toggle

*/