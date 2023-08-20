using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

// Token: 0x02000843 RID: 2115
[XmlRoot(ElementName = "RPD", Namespace = "")]
[Serializable]
public class RaisedPetData
{
    public RaisedPetData(RaisedPetData inData)
    {
        this.RaisedPetID = inData.RaisedPetID;
        this.EntityID = inData.EntityID;
        this.UserID = inData.UserID;
        this.Name = inData.Name;
        this.PetTypeID = inData.PetTypeID;
        this.ImagePosition = inData.ImagePosition;
        this.Geometry = inData.Geometry;
        this.Texture = inData.Texture;
        this.Gender = inData.Gender;
        this.IsSelected = inData.IsSelected;
        this.IsReleased = inData.IsReleased;
        this.CreateDate = inData.CreateDate;
        this.UpdateDate = inData.CreateDate;
        this.pStage = inData.pStage;
        this.GrowthState = inData.GrowthState;
        this.Accessories = inData.Accessories;
        this.Attributes = inData.Attributes;
        this.Colors = inData.Colors;
        this.Skills = inData.Skills;
        this.States = inData.States;
    }

    [XmlIgnore]
    public RaisedPetStage pStage;

    [XmlElement(ElementName = "id")]
    public int RaisedPetID;

    // Token: 0x04003465 RID: 13413
    [XmlElement(ElementName = "eid", IsNullable = true)]
    public Guid? EntityID;

    // Token: 0x04003466 RID: 13414
    [XmlElement(ElementName = "uid")]
    public Guid UserID;

    // Token: 0x04003467 RID: 13415
    [XmlElement(ElementName = "n")]
    public string Name;

    // Token: 0x04003468 RID: 13416
    [XmlElement(ElementName = "ptid")]
    public int PetTypeID;

    // Token: 0x04003469 RID: 13417
    [XmlElement(ElementName = "gs")]
    public RaisedPetGrowthState GrowthState;

    // Token: 0x0400346A RID: 13418
    [XmlElement(ElementName = "ip", IsNullable = true)]
    public int? ImagePosition;

    // Token: 0x0400346B RID: 13419
    [XmlElement(ElementName = "g")]
    public string Geometry;

    // Token: 0x0400346C RID: 13420
    [XmlElement(ElementName = "t")]
    public string Texture;

    // Token: 0x0400346D RID: 13421
    [XmlElement(ElementName = "gd")]
    public Gender Gender;

    // Token: 0x0400346E RID: 13422
    [XmlElement(ElementName = "ac")]
    public RaisedPetAccessory[] Accessories;

    // Token: 0x0400346F RID: 13423
    [XmlElement(ElementName = "at")]
    public RaisedPetAttribute[] Attributes;

    // Token: 0x04003470 RID: 13424
    [XmlElement(ElementName = "c")]
    public RaisedPetColor[] Colors;

    // Token: 0x04003471 RID: 13425
    [XmlElement(ElementName = "sk")]
    public RaisedPetSkill[] Skills;

    // Token: 0x04003472 RID: 13426
    [XmlElement(ElementName = "st")]
    public RaisedPetState[] States;

    // Token: 0x04003473 RID: 13427
    [XmlElement(ElementName = "is")]
    public bool IsSelected;

    // Token: 0x04003474 RID: 13428
    [XmlElement(ElementName = "ir")]
    public bool IsReleased;

    // Token: 0x04003475 RID: 13429
    [XmlElement(ElementName = "cdt")]
    public DateTime CreateDate;

    // Token: 0x04003476 RID: 13430
    [XmlElement(ElementName = "updt")]
    public DateTime UpdateDate;

    [XmlIgnore]
    public Texture2D pTexture;

    // Token: 0x04003486 RID: 13446
    [XmlIgnore]
    public GrBitmap pTextureBMP;

    // Token: 0x04003487 RID: 13447
    [XmlIgnore]
    public DateTime pHatchEndTime;

    // Token: 0x04003488 RID: 13448
    [XmlIgnore]
    public bool pIsSleeping;

    // Token: 0x04003489 RID: 13449
    [XmlIgnore]
    public bool pTextureUpdated;

    // Token: 0x0400348A RID: 13450
    [XmlIgnore]
    public bool pNoSave;

    // Token: 0x0400348B RID: 13451
    [XmlIgnore]
    public bool pIsActive;

    // Token: 0x0400348C RID: 13452
    [XmlIgnore]
    public GameObject pObject;

    // Token: 0x0400348D RID: 13453
    [XmlIgnore]
    public bool mIsDirty;

    // Token: 0x0400348E RID: 13454
    [XmlIgnore]
    public bool pIsNameCustomized;

    // Token: 0x0400348F RID: 13455
    [XmlIgnore]
    public int pPriority;

    // Token: 0x04003490 RID: 13456
    [XmlIgnore]
    public Dictionary<int, DateTime> pFoodEffect = new Dictionary<int, DateTime>();

    // Token: 0x04003491 RID: 13457
    [XmlIgnore]
    public int pRank = 1;

    // Token: 0x04003492 RID: 13458
    [XmlIgnore]
    public int pIncubatorID = -1;

    // Token: 0x04003493 RID: 13459
    [XmlIgnore]
    public bool pAbortCreation;

    // Token: 0x04003479 RID: 13433
    public const int TerribleTerror = 12;

	// Token: 0x0400347A RID: 13434
	public const int Gronkle = 13;

	// Token: 0x0400347B RID: 13435
	public const int Nadder = 14;

	// Token: 0x0400347C RID: 13436
	public const int Nightmare = 15;

	// Token: 0x0400347D RID: 13437
	public const int Zippleback = 16;

	// Token: 0x0400347E RID: 13438
	public const int NightFury = 17;

	// Token: 0x0400347F RID: 13439
	public const int TimberJack = 18;

	// Token: 0x04003480 RID: 13440
	public const int ThunderDrum = 19;

	// Token: 0x04003481 RID: 13441
	public const int WhisperingDeath = 20;

	// Token: 0x04003482 RID: 13442
	public const string EQUPPED_SKILL = "ES";

	// Token: 0x04003495 RID: 13461
	public static Dictionary<int, RaisedPetData[]> pReleasedPets = new Dictionary<int, RaisedPetData[]>();

	// Token: 0x04003496 RID: 13462
	public static Dictionary<int, RaisedPetData[]> pActivePets = new Dictionary<int, RaisedPetData[]>();


}
