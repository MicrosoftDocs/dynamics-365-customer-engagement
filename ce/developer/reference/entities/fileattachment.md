---
title: "FileAttachment table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the FileAttachment table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# FileAttachment table/entity reference (Microsoft Dynamics 365)

File Attachment

> [!NOTE]
> The Microsoft Dynamics 365 FileAttachment table extends the [Microsoft Dataverse FileAttachment table](/power-apps/developer/data-platform/reference/entities/fileattachment).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fileattachment#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_channelmessageattachment, msdyn_conversationinsight, msdyn_copilotinteractiondata, msdyn_copilottranscriptdata, msdyn_customerassetattachment, msdyn_entityattachment, msdyn_ocexternalcontext, msdyn_ocrecording, msdyn_ocrichobject, msdyn_soundfile, msdyn_transcript, msfp_fileresponse|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_channelmessageattachment_FileAttachments](#BKMK_msdyn_channelmessageattachment_FileAttachments)
- [msdyn_conversationinsight_FileAttachments](#BKMK_msdyn_conversationinsight_FileAttachments)
- [msdyn_copilotinteractiondata_FileAttachments](#BKMK_msdyn_copilotinteractiondata_FileAttachments)
- [msdyn_copilottranscriptdata_FileAttachments](#BKMK_msdyn_copilottranscriptdata_FileAttachments)
- [msdyn_customerassetattachment_FileAttachments](#BKMK_msdyn_customerassetattachment_FileAttachments)
- [msdyn_entityattachment_FileAttachments](#BKMK_msdyn_entityattachment_FileAttachments)
- [msdyn_ocexternalcontext_FileAttachments](#BKMK_msdyn_ocexternalcontext_FileAttachments)
- [msdyn_ocrecording_FileAttachments](#BKMK_msdyn_ocrecording_FileAttachments)
- [msdyn_ocrichobject_FileAttachments](#BKMK_msdyn_ocrichobject_FileAttachments)
- [msdyn_soundfile_FileAttachments](#BKMK_msdyn_soundfile_FileAttachments)
- [msdyn_transcript_FileAttachments](#BKMK_msdyn_transcript_FileAttachments)
- [msfp_fileresponse_FileAttachments](#BKMK_msfp_fileresponse_FileAttachments)

### <a name="BKMK_msdyn_channelmessageattachment_FileAttachments"></a> msdyn_channelmessageattachment_FileAttachments

One-To-Many Relationship: [msdyn_channelmessageattachment msdyn_channelmessageattachment_FileAttachments](msdyn_channelmessageattachment.md#BKMK_msdyn_channelmessageattachment_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channelmessageattachment`|
|ReferencedAttribute|`msdyn_channelmessageattachmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_channelmessageattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_conversationinsight_FileAttachments"></a> msdyn_conversationinsight_FileAttachments

One-To-Many Relationship: [msdyn_conversationinsight msdyn_conversationinsight_FileAttachments](msdyn_conversationinsight.md#BKMK_msdyn_conversationinsight_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_conversationinsight`|
|ReferencedAttribute|`msdyn_conversationinsightid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_conversationinsight`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_copilotinteractiondata_FileAttachments"></a> msdyn_copilotinteractiondata_FileAttachments

One-To-Many Relationship: [msdyn_copilotinteractiondata msdyn_copilotinteractiondata_FileAttachments](msdyn_copilotinteractiondata.md#BKMK_msdyn_copilotinteractiondata_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilotinteractiondata`|
|ReferencedAttribute|`msdyn_copilotinteractiondataid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_copilotinteractiondata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_copilottranscriptdata_FileAttachments"></a> msdyn_copilottranscriptdata_FileAttachments

One-To-Many Relationship: [msdyn_copilottranscriptdata msdyn_copilottranscriptdata_FileAttachments](msdyn_copilottranscriptdata.md#BKMK_msdyn_copilottranscriptdata_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscriptdata`|
|ReferencedAttribute|`msdyn_copilottranscriptdataid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_copilottranscriptdata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customerassetattachment_FileAttachments"></a> msdyn_customerassetattachment_FileAttachments

One-To-Many Relationship: [msdyn_customerassetattachment msdyn_customerassetattachment_FileAttachments](msdyn_customerassetattachment.md#BKMK_msdyn_customerassetattachment_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerassetattachment`|
|ReferencedAttribute|`msdyn_customerassetattachmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_customerassetattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entityattachment_FileAttachments"></a> msdyn_entityattachment_FileAttachments

One-To-Many Relationship: [msdyn_entityattachment msdyn_entityattachment_FileAttachments](msdyn_entityattachment.md#BKMK_msdyn_entityattachment_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_entityattachment`|
|ReferencedAttribute|`msdyn_entityattachmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_entityattachment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocexternalcontext_FileAttachments"></a> msdyn_ocexternalcontext_FileAttachments

One-To-Many Relationship: [msdyn_ocexternalcontext msdyn_ocexternalcontext_FileAttachments](msdyn_ocexternalcontext.md#BKMK_msdyn_ocexternalcontext_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocexternalcontext`|
|ReferencedAttribute|`msdyn_ocexternalcontextid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocexternalcontext`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocrecording_FileAttachments"></a> msdyn_ocrecording_FileAttachments

One-To-Many Relationship: [msdyn_ocrecording msdyn_ocrecording_FileAttachments](msdyn_ocrecording.md#BKMK_msdyn_ocrecording_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocrecording`|
|ReferencedAttribute|`msdyn_ocrecordingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocrecording`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocrichobject_FileAttachments"></a> msdyn_ocrichobject_FileAttachments

One-To-Many Relationship: [msdyn_ocrichobject msdyn_ocrichobject_FileAttachments](msdyn_ocrichobject.md#BKMK_msdyn_ocrichobject_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocrichobject`|
|ReferencedAttribute|`msdyn_ocrichobjectid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocrichobject`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_soundfile_FileAttachments"></a> msdyn_soundfile_FileAttachments

One-To-Many Relationship: [msdyn_soundfile msdyn_soundfile_FileAttachments](msdyn_soundfile.md#BKMK_msdyn_soundfile_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_soundfile`|
|ReferencedAttribute|`msdyn_soundfileid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_soundfile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transcript_FileAttachments"></a> msdyn_transcript_FileAttachments

One-To-Many Relationship: [msdyn_transcript msdyn_transcript_FileAttachments](msdyn_transcript.md#BKMK_msdyn_transcript_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transcript`|
|ReferencedAttribute|`msdyn_transcriptid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_transcript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_fileresponse_FileAttachments"></a> msfp_fileresponse_FileAttachments

One-To-Many Relationship: [msfp_fileresponse msfp_fileresponse_FileAttachments](msfp_fileresponse.md#BKMK_msfp_fileresponse_FileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_fileresponse`|
|ReferencedAttribute|`msfp_fileresponseid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_fileresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [FileAttachment_msdyn_ChannelMessageAttachment_msdyn_FileAttachment](#BKMK_FileAttachment_msdyn_ChannelMessageAttachment_msdyn_FileAttachment)
- [FileAttachment_msdyn_conversationinsight_msdyn_insights](#BKMK_FileAttachment_msdyn_conversationinsight_msdyn_insights)
- [FileAttachment_msdyn_conversationinsight_msdyn_TranscriptWithInsights](#BKMK_FileAttachment_msdyn_conversationinsight_msdyn_TranscriptWithInsights)
- [FileAttachment_msdyn_copilotinteractiondata_msdyn_interactiondata](#BKMK_FileAttachment_msdyn_copilotinteractiondata_msdyn_interactiondata)
- [FileAttachment_msdyn_copilottranscriptdata_msdyn_transcriptdata](#BKMK_FileAttachment_msdyn_copilottranscriptdata_msdyn_transcriptdata)
- [FileAttachment_msdyn_customerassetattachment_msdyn_File](#BKMK_FileAttachment_msdyn_customerassetattachment_msdyn_File)
- [FileAttachment_msdyn_entityattachment_msdyn_FileBlob](#BKMK_FileAttachment_msdyn_entityattachment_msdyn_FileBlob)
- [FileAttachment_msdyn_ocexternalcontext_msdyn_transcript](#BKMK_FileAttachment_msdyn_ocexternalcontext_msdyn_transcript)
- [FileAttachment_msdyn_ocrecording_msdyn_recording](#BKMK_FileAttachment_msdyn_ocrecording_msdyn_recording)
- [FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata](#BKMK_FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata)
- [FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile](#BKMK_FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile)
- [FileAttachment_msdyn_soundfile_msdyn_Uploadsoundfile](#BKMK_FileAttachment_msdyn_soundfile_msdyn_Uploadsoundfile)
- [FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted](#BKMK_FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted)
- [FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript](#BKMK_FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript)
- [FileAttachment_msdyn_transcript_msdyn_voicetranscript](#BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript)
- [FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted](#BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted)
- [FileAttachment_msfp_fileresponse_msfp_file1](#BKMK_FileAttachment_msfp_fileresponse_msfp_file1)
- [FileAttachment_msfp_fileresponse_msfp_file10](#BKMK_FileAttachment_msfp_fileresponse_msfp_file10)
- [FileAttachment_msfp_fileresponse_msfp_file2](#BKMK_FileAttachment_msfp_fileresponse_msfp_file2)
- [FileAttachment_msfp_fileresponse_msfp_file3](#BKMK_FileAttachment_msfp_fileresponse_msfp_file3)
- [FileAttachment_msfp_fileresponse_msfp_file4](#BKMK_FileAttachment_msfp_fileresponse_msfp_file4)
- [FileAttachment_msfp_fileresponse_msfp_file5](#BKMK_FileAttachment_msfp_fileresponse_msfp_file5)
- [FileAttachment_msfp_fileresponse_msfp_file6](#BKMK_FileAttachment_msfp_fileresponse_msfp_file6)
- [FileAttachment_msfp_fileresponse_msfp_file7](#BKMK_FileAttachment_msfp_fileresponse_msfp_file7)
- [FileAttachment_msfp_fileresponse_msfp_file8](#BKMK_FileAttachment_msfp_fileresponse_msfp_file8)
- [FileAttachment_msfp_fileresponse_msfp_file9](#BKMK_FileAttachment_msfp_fileresponse_msfp_file9)

### <a name="BKMK_FileAttachment_msdyn_ChannelMessageAttachment_msdyn_FileAttachment"></a> FileAttachment_msdyn_ChannelMessageAttachment_msdyn_FileAttachment

Many-To-One Relationship: [msdyn_channelmessageattachment FileAttachment_msdyn_ChannelMessageAttachment_msdyn_FileAttachment](msdyn_channelmessageattachment.md#BKMK_FileAttachment_msdyn_ChannelMessageAttachment_msdyn_FileAttachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessageattachment`|
|ReferencingAttribute|`msdyn_fileattachment`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_ChannelMessageAttachment_msdyn_FileAttachment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_conversationinsight_msdyn_insights"></a> FileAttachment_msdyn_conversationinsight_msdyn_insights

Many-To-One Relationship: [msdyn_conversationinsight FileAttachment_msdyn_conversationinsight_msdyn_insights](msdyn_conversationinsight.md#BKMK_FileAttachment_msdyn_conversationinsight_msdyn_insights)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationinsight`|
|ReferencingAttribute|`msdyn_insights`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_conversationinsight_msdyn_insights`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_conversationinsight_msdyn_TranscriptWithInsights"></a> FileAttachment_msdyn_conversationinsight_msdyn_TranscriptWithInsights

Many-To-One Relationship: [msdyn_conversationinsight FileAttachment_msdyn_conversationinsight_msdyn_TranscriptWithInsights](msdyn_conversationinsight.md#BKMK_FileAttachment_msdyn_conversationinsight_msdyn_TranscriptWithInsights)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationinsight`|
|ReferencingAttribute|`msdyn_transcriptwithinsights`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_conversationinsight_msdyn_TranscriptWithInsights`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_copilotinteractiondata_msdyn_interactiondata"></a> FileAttachment_msdyn_copilotinteractiondata_msdyn_interactiondata

Many-To-One Relationship: [msdyn_copilotinteractiondata FileAttachment_msdyn_copilotinteractiondata_msdyn_interactiondata](msdyn_copilotinteractiondata.md#BKMK_FileAttachment_msdyn_copilotinteractiondata_msdyn_interactiondata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotinteractiondata`|
|ReferencingAttribute|`msdyn_interactiondata`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_copilotinteractiondata_msdyn_interactiondata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_copilottranscriptdata_msdyn_transcriptdata"></a> FileAttachment_msdyn_copilottranscriptdata_msdyn_transcriptdata

Many-To-One Relationship: [msdyn_copilottranscriptdata FileAttachment_msdyn_copilottranscriptdata_msdyn_transcriptdata](msdyn_copilottranscriptdata.md#BKMK_FileAttachment_msdyn_copilottranscriptdata_msdyn_transcriptdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscriptdata`|
|ReferencingAttribute|`msdyn_transcriptdata`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_copilottranscriptdata_msdyn_transcriptdata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_customerassetattachment_msdyn_File"></a> FileAttachment_msdyn_customerassetattachment_msdyn_File

Many-To-One Relationship: [msdyn_customerassetattachment FileAttachment_msdyn_customerassetattachment_msdyn_File](msdyn_customerassetattachment.md#BKMK_FileAttachment_msdyn_customerassetattachment_msdyn_File)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerassetattachment`|
|ReferencingAttribute|`msdyn_file`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_customerassetattachment_msdyn_File`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_entityattachment_msdyn_FileBlob"></a> FileAttachment_msdyn_entityattachment_msdyn_FileBlob

Many-To-One Relationship: [msdyn_entityattachment FileAttachment_msdyn_entityattachment_msdyn_FileBlob](msdyn_entityattachment.md#BKMK_FileAttachment_msdyn_entityattachment_msdyn_FileBlob)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityattachment`|
|ReferencingAttribute|`msdyn_fileblob`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_entityattachment_msdyn_FileBlob`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_ocexternalcontext_msdyn_transcript"></a> FileAttachment_msdyn_ocexternalcontext_msdyn_transcript

Many-To-One Relationship: [msdyn_ocexternalcontext FileAttachment_msdyn_ocexternalcontext_msdyn_transcript](msdyn_ocexternalcontext.md#BKMK_FileAttachment_msdyn_ocexternalcontext_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocexternalcontext`|
|ReferencingAttribute|`msdyn_transcript`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_ocexternalcontext_msdyn_transcript`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_ocrecording_msdyn_recording"></a> FileAttachment_msdyn_ocrecording_msdyn_recording

Many-To-One Relationship: [msdyn_ocrecording FileAttachment_msdyn_ocrecording_msdyn_recording](msdyn_ocrecording.md#BKMK_FileAttachment_msdyn_ocrecording_msdyn_recording)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrecording`|
|ReferencingAttribute|`msdyn_recording`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_ocrecording_msdyn_recording`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata"></a> FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata

Many-To-One Relationship: [msdyn_ocrecording FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata](msdyn_ocrecording.md#BKMK_FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrecording`|
|ReferencingAttribute|`msdyn_recordingmetadata`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_ocrecording_msdyn_recordingmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile"></a> FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile

Many-To-One Relationship: [msdyn_ocrichobject FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile](msdyn_ocrichobject.md#BKMK_FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrichobject`|
|ReferencingAttribute|`msdyn_objectjsonfile`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_ocrichobject_msdyn_objectjsonfile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_soundfile_msdyn_Uploadsoundfile"></a> FileAttachment_msdyn_soundfile_msdyn_Uploadsoundfile

Many-To-One Relationship: [msdyn_soundfile FileAttachment_msdyn_soundfile_msdyn_Uploadsoundfile](msdyn_soundfile.md#BKMK_FileAttachment_msdyn_soundfile_msdyn_Uploadsoundfile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_soundfile`|
|ReferencingAttribute|`msdyn_uploadsoundfile`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_soundfile_msdyn_Uploadsoundfile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted"></a> FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted

Many-To-One Relationship: [msdyn_transcript FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted](msdyn_transcript.md#BKMK_FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`msdyn_englishtranslatedtranscriptformatted`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_transcript_msdyn_englishtranslatedtranscriptformatted`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript"></a> FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript

Many-To-One Relationship: [msdyn_transcript FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript](msdyn_transcript.md#BKMK_FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`msdyn_rawvoicetranscript`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_transcript_msdyn_rawvoicetranscript`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript"></a> FileAttachment_msdyn_transcript_msdyn_voicetranscript

Many-To-One Relationship: [msdyn_transcript FileAttachment_msdyn_transcript_msdyn_voicetranscript](msdyn_transcript.md#BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`msdyn_voicetranscript`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_transcript_msdyn_voicetranscript`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted"></a> FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted

Many-To-One Relationship: [msdyn_transcript FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted](msdyn_transcript.md#BKMK_FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`msdyn_voicetranscript_formatted`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msdyn_transcript_msdyn_voicetranscript_formatted`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msfp_fileresponse_msfp_file1"></a> FileAttachment_msfp_fileresponse_msfp_file1

Many-To-One Relationship: [msfp_fileresponse FileAttachment_msfp_fileresponse_msfp_file1](msfp_fileresponse.md#BKMK_FileAttachment_msfp_fileresponse_msfp_file1)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`msfp_file1`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msfp_fileresponse_msfp_file1`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msfp_fileresponse_msfp_file10"></a> FileAttachment_msfp_fileresponse_msfp_file10

Many-To-One Relationship: [msfp_fileresponse FileAttachment_msfp_fileresponse_msfp_file10](msfp_fileresponse.md#BKMK_FileAttachment_msfp_fileresponse_msfp_file10)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`msfp_file10`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msfp_fileresponse_msfp_file10`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msfp_fileresponse_msfp_file2"></a> FileAttachment_msfp_fileresponse_msfp_file2

Many-To-One Relationship: [msfp_fileresponse FileAttachment_msfp_fileresponse_msfp_file2](msfp_fileresponse.md#BKMK_FileAttachment_msfp_fileresponse_msfp_file2)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`msfp_file2`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msfp_fileresponse_msfp_file2`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msfp_fileresponse_msfp_file3"></a> FileAttachment_msfp_fileresponse_msfp_file3

Many-To-One Relationship: [msfp_fileresponse FileAttachment_msfp_fileresponse_msfp_file3](msfp_fileresponse.md#BKMK_FileAttachment_msfp_fileresponse_msfp_file3)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`msfp_file3`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msfp_fileresponse_msfp_file3`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msfp_fileresponse_msfp_file4"></a> FileAttachment_msfp_fileresponse_msfp_file4

Many-To-One Relationship: [msfp_fileresponse FileAttachment_msfp_fileresponse_msfp_file4](msfp_fileresponse.md#BKMK_FileAttachment_msfp_fileresponse_msfp_file4)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`msfp_file4`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msfp_fileresponse_msfp_file4`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msfp_fileresponse_msfp_file5"></a> FileAttachment_msfp_fileresponse_msfp_file5

Many-To-One Relationship: [msfp_fileresponse FileAttachment_msfp_fileresponse_msfp_file5](msfp_fileresponse.md#BKMK_FileAttachment_msfp_fileresponse_msfp_file5)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`msfp_file5`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msfp_fileresponse_msfp_file5`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msfp_fileresponse_msfp_file6"></a> FileAttachment_msfp_fileresponse_msfp_file6

Many-To-One Relationship: [msfp_fileresponse FileAttachment_msfp_fileresponse_msfp_file6](msfp_fileresponse.md#BKMK_FileAttachment_msfp_fileresponse_msfp_file6)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`msfp_file6`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msfp_fileresponse_msfp_file6`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msfp_fileresponse_msfp_file7"></a> FileAttachment_msfp_fileresponse_msfp_file7

Many-To-One Relationship: [msfp_fileresponse FileAttachment_msfp_fileresponse_msfp_file7](msfp_fileresponse.md#BKMK_FileAttachment_msfp_fileresponse_msfp_file7)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`msfp_file7`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msfp_fileresponse_msfp_file7`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msfp_fileresponse_msfp_file8"></a> FileAttachment_msfp_fileresponse_msfp_file8

Many-To-One Relationship: [msfp_fileresponse FileAttachment_msfp_fileresponse_msfp_file8](msfp_fileresponse.md#BKMK_FileAttachment_msfp_fileresponse_msfp_file8)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`msfp_file8`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msfp_fileresponse_msfp_file8`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_FileAttachment_msfp_fileresponse_msfp_file9"></a> FileAttachment_msfp_fileresponse_msfp_file9

Many-To-One Relationship: [msfp_fileresponse FileAttachment_msfp_fileresponse_msfp_file9](msfp_fileresponse.md#BKMK_FileAttachment_msfp_fileresponse_msfp_file9)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`msfp_file9`|
|ReferencedEntityNavigationPropertyName|`FileAttachment_msfp_fileresponse_msfp_file9`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.fileattachment?displayProperty=fullName>
