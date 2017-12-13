---
title: "Step 3: Configure the tile for custom channel (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Creating a custom channel for customer journeys involves using the extensibility infrastructure in Dynamics 365 Customer Engagement such as custom entities, workflows, plugins, and web resources, which allows developers and partners to leverage their existing knowledge of Customer Engagement."
ms.custom: ""
ms.date: 12/15/2017
ms.service: "crm-online"
ms.technology: 
  - "marketing"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: db4ef53d-8a48-4b27-899f-8f4c788bc43c
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Step 3: Configure the tile for custom channel

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[Pre-release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Custom channel is exposed as a “tile” in the customer journey designer. You define the tile using 2 files: an XML file and a CSS file.

## Define the Tile XML file

Define tile properties of the custom Tile in in an XML file. The XML file name should be in the following format: **<SolutionPublisherPrefix>_<FileNamePrefix>CustomerJourneyDesignerTileConfig.xml**.

For example if you want to use **SpecialTile** as the name for your XML file then the file name will be the following assuming the [solution publisher prefix](../../customize/change-solution-publisher-prefix.md) in your Customer Engagement instance is "sample": **sample_SpecialTileCustomerJourneyDesignerTileConfig.xml**. 

### Sample Tile XML file 

The following is a sample Tile XML file. Description of the elements in the XML file is available later in this topic:

```xml
<?xml version="1.0" encoding="utf-8"?>
<!-- file name should only contain alpha-numeric characters and underscore -->
<!-- format: <fileNamePrefix>CustomerJourneyDesignerTileConfig.xml> -->
<LibraryTile>
  <!-- mandatory -->
  <!-- icon: CSS class defining your tile icon-->
  <!-- fontFamily: CSS class definiing font-family for your icon-->
  <!-- cssFileName: your CSS file name in CRM-->
  <Definition icon="sample_SpecialTile" fontFamily="sample_SpecialTileSymbolFont" cssFileName="sample_SpecialTileCustomerJourneyDesignerTileConfig.css" />
  <!-- mandatory -->
  <ChannelProperties>
    <!-- mandatory -->
    <EntityType>sample_specialmessage</EntityType>
    <EntitySetName>sample_specialmessages</EntitySetName>
    <TitleFieldName>sample_name</TitleFieldName>
    <ComplianceField>donotphone</ComplianceField>
    <!-- optional -->
    <!-- Lookup view id for your entity-->
    <LookupViewId>4112769C-F12D-4F63-B8C3-9068FECBB4E9</LookupViewId>
    <!--Insights form id for your entity -->
    <InsightsMainFormId>6370c410-6dd5-43f5-b1d1-7b757992d2de</InsightsMainFormId>
    <!--Quick view form id for your entity -->
    <QuickViewFormId>404BA31B-2C12-4233-8711-804B78DE1267</QuickViewFormId>
  </ChannelProperties>
  <!-- optional -->
  <ResponseTypes>
    <ResponseType id="sent">
      <Labels>
        <!-- Labels should always have a Label for 1033 -->
        <Label locId="1033">Sent</Label>
        <Label locId="1031">[Sent]</Label>
      </Labels>
    </ResponseType>
    <ResponseType id="delivered">
      <Labels>
        <!-- Labels should always have a Label for 1033 -->
        <Label locId="1033">Delivered</Label>
        <Label locId="1031">[Delivered]</Label>
      </Labels>
    </ResponseType>
    <ResponseType id="keyword" custom="True">
      <!-- there should be only one response type with attribute custom=true -->
      <Labels>
        <!-- Labels should always have a Label for 1033 -->
        <Label locId="1033">Keyword match</Label>
        <Label locId="1031">[Keyword match]</Label>
      </Labels>
    </ResponseType>
  </ResponseTypes>
  <!-- mandatory -->
  <Labels>
    <!-- Labels should always have a Label for 1033 -->
    <Label locId="1033">Special</Label>
    <Label locId="1031">[Special]</Label>
  </Labels>
  <!-- mandatory -->
  <Tooltips>
    <!-- Tooltips should always have a tooltip for 1033 -->
    <!-- mandatory -->
    <Tooltip locId="1033">Custom Tile tool tip</Tooltip>
    <!-- optional -->
    <Tooltip locId="1031">[Custom Tile tool tip]</Tooltip>
  </Tooltips>
</LibraryTile>
```

### Tile XML file elements

The XML file has the following elements:

- **Definition**: Defines the icon by specifying the following properties:

    <table>
    <tr>
    <th>Property</th>
    <th>Description</th>
    </tr>
    <tr>
    <td>icon</td>
    <td>CSS class defining your tile icon. This definition is available in your CSS file.</td>
    </tr>
    <tr>
    <td>fontFamily</td>
    <td>CSS class definiing font-family for your icon. This definition is available in your CSS file.</td>
    </tr>
    <tr>
    <td>cssFileName</td>
    <td>Your CSS file name containing the definitions.</td>
    </tr>
    </table>

    Example:

    ```xml
    <Definition icon="sample_SpecialTile" fontFamily="sample_SpecialTileSymbolFont" cssFileName="sample_SpecialTileCustomerJourneyDesignerTileConfig.css" />
    ```

- **ChannelProperties**: Contains information about the custom entity that you created to store and manage data related to your custom channel.

    <table>
    <tr>
    <th>Element</th>
    <th>Description</th>
    </tr>
    <tr>
    <td>EntityType</td>
    <td>Logical name of the custom entity.</td>
    </tr>
    <tr>
    <td>EntitySetName</td>
    <td>Collection name (plural name) of the custom entity.</td>
    </tr>
    <tr>
    <td>ComplianceField</td>
    <td>Contains a boolean attribute of the [Contact]((../../developer/entities/contact.md)) entity whose value determines whether an instance of the Custom Channel Activity (<b>msdyncrm_customerjourneycustomchannelactivity</b>) entity is created when the Contact record goes through a customer journey.
    
    For example, if you set the value of this element to [donotphone](https://docs.microsoft.com/dynamics365/customer-engagement/developer/entities/contact#BKMK_DoNotPhone):

    `<ComplianceField>donotphone</ComplianceField>`
 
    The value of this attribute will be checked for a Contact record while going through a customer journey and an instance of the Custom Channel Activity entity will be created only if the value of the [donotphone](https://docs.microsoft.com/dynamics365/customer-engagement/developer/entities/contact#BKMK_DoNotPhone) attribute for the contact record is <b>false</b>.
    </td>
    </tr>
    </table>








> [!div class="nextstepaction"]
> [Step 4: Test your custom channel tile](test-custom-channel-tile.md)

  