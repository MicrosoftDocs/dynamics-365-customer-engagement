---
title: "Social Profile (SocialProfile) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Social Profile (SocialProfile) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Social Profile (SocialProfile) table/entity reference

This entity is used to store social profile information of its associated account and contacts on different social channels.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Social Profile (SocialProfile) table extends the [Microsoft Dataverse Social Profile (SocialProfile) table](/power-apps/developer/data-platform/reference/entities/socialprofile).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_customeroptout](#BKMK_msdyn_customeroptout)
- [msdyn_ocfollowercount](#BKMK_msdyn_ocfollowercount)
- [msdyn_ocfollowingcount](#BKMK_msdyn_ocfollowingcount)
- [msdyn_ocfriendcount](#BKMK_msdyn_ocfriendcount)
- [msdyn_octwitterhandleid](#BKMK_msdyn_octwitterhandleid)
- [msdyn_phonenumber](#BKMK_msdyn_phonenumber)
- [msdyn_profileimagelink](#BKMK_msdyn_profileimagelink)
- [msdyn_sourceid](#BKMK_msdyn_sourceid)
- [msdyn_wechatopenid](#BKMK_msdyn_wechatopenid)

### <a name="BKMK_msdyn_customeroptout"></a> msdyn_customeroptout

|Property|Value|
|---|---|
|Description|**Flag specifying whether Customer has opted out of getting messages using this SP.**|
|DisplayName|**customeroptout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customeroptout`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_socialprofile_msdyn_customeroptout`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_ocfollowercount"></a> msdyn_ocfollowercount

|Property|Value|
|---|---|
|Description|**Customer's Followers on the Social channel.**|
|DisplayName|**Follower Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfollowercount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ocfollowingcount"></a> msdyn_ocfollowingcount

|Property|Value|
|---|---|
|Description|**Customer's followings on the Social channel**|
|DisplayName|**Followings Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfollowingcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ocfriendcount"></a> msdyn_ocfriendcount

|Property|Value|
|---|---|
|Description|**Customer's Friend count on the Social Channel**|
|DisplayName|**Friend Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfriendcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_octwitterhandleid"></a> msdyn_octwitterhandleid

|Property|Value|
|---|---|
|Description|**Lookup for Twitter Handle entity.**|
|DisplayName|**Twitter Handle Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_octwitterhandleid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_octwitterhandle|

### <a name="BKMK_msdyn_phonenumber"></a> msdyn_phonenumber

|Property|Value|
|---|---|
|Description|**The phone number of the social profile.**|
|DisplayName|**Phone number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonenumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_profileimagelink"></a> msdyn_profileimagelink

|Property|Value|
|---|---|
|Description|**Link to the Customer's Social Channel Profile image.**|
|DisplayName|**Profile Image Link**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_profileimagelink`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_sourceid"></a> msdyn_sourceid

|Property|Value|
|---|---|
|Description|**Source Id field of social profile entity for Apple Business Messages channel.**|
|DisplayName|**Source Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_wechatopenid"></a> msdyn_wechatopenid

|Property|Value|
|---|---|
|Description|**Open ID field of social profile entity for WeChat channel.**|
|DisplayName|**WeChat Open ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wechatopenid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_Community"></a> Community

Changes from [Community (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialprofile#BKMK_Community)

#### Community Choices/Options

|Value|Label|
|---|---|
|3|**Line**|
|4|**Wechat**|
|5|**Cortana**|
|6|**Direct Line**|
|7|**Microsoft Teams**|
|8|**Direct Line Speech**|
|9|**Email**|
|10|**GroupMe**|
|11|**Kik**|
|12|**Telegram**|
|13|**Skype**|
|14|**Slack**|
|15|**WhatsApp**|
|16|**Apple Messages For Business**|
|17|**Google's Business Messages**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_octwitterhandle_socialprofile_octwitterhandleid"></a> msdyn_msdyn_octwitterhandle_socialprofile_octwitterhandleid

One-To-Many Relationship: [msdyn_octwitterhandle msdyn_msdyn_octwitterhandle_socialprofile_octwitterhandleid](msdyn_octwitterhandle.md#BKMK_msdyn_msdyn_octwitterhandle_socialprofile_octwitterhandleid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandle`|
|ReferencedAttribute|`msdyn_octwitterhandleid`|
|ReferencingAttribute|`msdyn_octwitterhandleid`|
|ReferencingEntityNavigationPropertyName|`msdyn_octwitterhandleid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid](#BKMK_msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid)
- [socialprofile_cases](#BKMK_socialprofile_cases)

### <a name="BKMK_msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid"></a> msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid](msdyn_ocliveworkitem.md#BKMK_msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_socialprofileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_socialprofile_cases"></a> socialprofile_cases

Many-To-One Relationship: [incident socialprofile_cases](incident.md#BKMK_socialprofile_cases)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`socialprofileid`|
|ReferencedEntityNavigationPropertyName|`socialprofile_cases`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Service`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: null<br />ViewId: `00000000-0000-0000-00aa-000010003501`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.socialprofile?displayProperty=fullName>
