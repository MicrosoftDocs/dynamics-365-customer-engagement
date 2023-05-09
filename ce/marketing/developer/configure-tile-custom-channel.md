---
title: "Step 2: Configure the custom channel tile (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn about how to configure a Tile for a custom channel in Dynamics 365 Marketing."
ms.date: 02/09/2022

ms.custom: 
  - dyn365-marketing
ms.topic: how-to
author: alfergus
ms.author: alfergus
search.audienceType: 
  - developer
---

# Step 2: Configure the custom channel tile

A custom channel is exposed as a “tile” in the customer journey designer. You can define the tile using an XML file.

## Define the Tile XML file

Define tile properties of the custom Tile in an XML file. The XML file name should be in the following format: **\<SolutionPublisherPrefix>_\<FileNamePrefix>CustomerJourneyDesignerTileConfig.xml**.

For example, if you want to use **SpecialTile** as the name for your XML file then the file name will be the following assuming the [solution publisher prefix](/powerapps/maker/common-data-service/change-solution-publisher-prefix) in your Dynamics 365 Marketing instance is "sample": **sample_SpecialTileCustomerJourneyDesignerTileConfig.xml**

### Sample Tile XML file

The following is a sample Tile XML file. Description of the elements in the XML file is available later in this topic:

```xml
<?xml version="1.0" encoding="utf-8"?>
<!-- file name should only contain alpha-numeric characters and underscore -->
<!-- format: <fileNamePrefix>CustomerJourneyDesignerTileConfig.xml> -->
<LibraryTile>
  <!-- mandatory -->
  <ChannelProperties>
    <!-- mandatory -->
    <EntityType>sample_specialmessage</EntityType>
    <EntitySetName>sample_specialmessages</EntitySetName>
    <TitleFieldName>sample_name</TitleFieldName>
    <ComplianceField>donotphone</ComplianceField>
    <!-- mandatory -->
    <!-- Lookup view id for your entity-->
    <LookupViewId>4112769C-F12D-4F63-B8C3-9068FECBB4E9</LookupViewId>
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
    <td>Contains a boolean attribute of the <a href="/dynamics365/customerengagement/on-premises/developer/entities/contact" data-raw-source="[Contact](/powerapps/developer/common-data-service/reference/entities/contact)">Contact</a> entity whose value determines whether an instance of the Custom Channel Activity (<b>msdyncrm_customerjourneycustomchannelactivity</b>) entity is created when the Contact record goes through a customer journey.<br/><br/>
    
    For example, if you set the value of this element to <a href="/powerapps/developer/common-data-service/reference/entities/contact#BKMK_DoNotPhone" data-raw-source="[donotphone](/powerapps/developer/common-data-service/reference/entities/contact#BKMK_DoNotPhone)">donotphone</a>:<br/><br/>

    <code>&lt;ComplianceField&gt;donotphone&lt;/ComplianceField&gt;</code>
 
    <br/><br/>The value of this attribute will be checked for a Contact record while going through a customer journey and an instance of the Custom Channel Activity entity will be created only if the value of the <a href="/powerapps/developer/common-data-service/reference/entities/contact#BKMK_DoNotPhone" data-raw-source="[donotphone](/powerapps/developer/common-data-service/reference/entities/contact#BKMK_DoNotPhone)">donotphone</a> attribute for the contact record is <b>false</b>.
    </td>
    </tr>
    <tr>
    <td>LookupViewId</td>
    <td>Lookup view ID for the custom entity.</td>
    </tr>
    <tr>
    <td>QuickViewFormId</td>
    <td>Quick view form ID for the custom entity.</td>
    </tr>
    </table>

- **ResponseTypes**: Add information about the expected response types. The **id** property defines the name or the ID of a response type. The **Labels** element lets you specify localized labels for the response type. Use the **locId** property in the **Label** element to specify localized label names. For example:

    ```xml
    <ResponseTypes>
      <ResponseType id="sent">
        <Labels>
        <!-- Labels should always have a Label for 1033 -->
          <Label locId="1033">Sent</Label>
          <Label locId="1031">[Sent]</Label>
        </Labels>
      </ResponseType>
    </ResponseTypes>    
    ```
- **Tooltips**: Provides tooltip for the tile; can also specify localized values using the **locId** property. For example:

    ```xml
    <Tooltips>
      <!-- Tooltips should always have a tooltip for 1033 -->
      <!-- mandatory -->
      <Tooltip locId="1033">Custom Tile tool tip</Tooltip>
      <!-- optional -->
      <Tooltip locId="1031">[Custom Tile tool tip]</Tooltip>
    </Tooltips>
    ```

> [!div class="nextstepaction"]
> [Step 3: Create a workflow or plug-in to implement your custom logic](create-workflow-plugin-custom-channel.md)

  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
