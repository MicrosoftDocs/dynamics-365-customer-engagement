---
title: "ISV configuration file schema | MicrosoftDocs"
description: "The topic shows you the schema definition for the ISV Configuration section of an import/export customization file."
ms.custom: 
ms.date: 12/22/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 7e473dfe-f4fd-4c5a-bd43-96fc487620dd
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# ISV configuration file schema

This topic shows you the schema definition for the ISV Configuration section of an import/export customization file. This schema is included from the [Customization Solutions File Schema](customization-solutions-file-schema.md). For more information, see [Package and Distribute Extensions with Microsoft Dynamics 365 Customer Engagement Solutions](../package-distribute-extensions-use-solutions.md). [!INCLUDE[schema_download](../../includes/schema-download.md)] and see the file `ISV.config.xsd`.
  
## Schema  
  
```xml  
<?xml version="1.0"?>  
<xs:schema attributeFormDefault="unqualified"  
           elementFormDefault="qualified"  
           xmlns:xs="https://www.w3.org/2001/XMLSchema">  
  <xs:element name="configuration"  
              type="IsvConfigurationType" />  
  <xs:complexType name="IsvConfigurationType">  
    <xs:sequence>  
      <xs:element name="Root">  
        <xs:complexType>  
          <xs:sequence>  
            <xs:element name="NavBarAreas"  
                        type="NavBarAreasType"  
                        minOccurs="0"  
                        maxOccurs="1">  
            </xs:element>  
  
            <xs:element name="MenuBar"  
                        minOccurs="0"  
                        maxOccurs="1">  
              <xs:complexType>  
                <xs:sequence>  
                  <xs:element name="CustomMenus"  
                              minOccurs="0"  
                              maxOccurs="1">  
                    <xs:complexType>  
                      <xs:sequence>  
                        <xs:element name="Menu"  
                                    minOccurs="0"  
                                    maxOccurs="unbounded"  
                                    type="Menu" />  
                      </xs:sequence>  
                    </xs:complexType>  
                  </xs:element>  
                </xs:sequence>  
              </xs:complexType>  
            </xs:element>  
            <xs:element name="ToolBar"  
                        type="ToolBar"  
                        minOccurs="0"  
                        maxOccurs="1" />  
            <xs:element name="Areas"  
                        minOccurs="0"  
                        maxOccurs="1">  
              <xs:complexType>  
                <xs:all>  
                  <xs:element name="Home"  
                              type="NavigationArea"  
                              maxOccurs="1"  
                              minOccurs="0" />  
                  <xs:element name="Workplace"  
                              type="NavigationArea"  
                              maxOccurs="1"  
                              minOccurs="0" />  
                  <xs:element name="Sales"  
                              type="NavigationArea"  
                              maxOccurs="1"  
                              minOccurs="0" />  
                  <xs:element name="Marketing"  
                              type="NavigationArea"  
                              maxOccurs="1"  
                              minOccurs="0" />  
                  <xs:element name="Service"  
                              type="NavigationArea"  
                              maxOccurs="1"  
                              minOccurs="0" />  
                  <xs:element name="Reports"  
                              type="NavigationArea"  
                              maxOccurs="1"  
                              minOccurs="0" />  
                </xs:all>  
              </xs:complexType>  
            </xs:element>  
          </xs:sequence>  
        </xs:complexType>  
      </xs:element>  
      <xs:element name="Entities"  
                  minOccurs="0"  
                  maxOccurs="1">  
        <xs:complexType>  
          <xs:sequence>  
            <xs:element name="Entity"  
                        type="EntityNode"  
                        minOccurs="0"  
                        maxOccurs="unbounded" />  
          </xs:sequence>  
        </xs:complexType>  
      </xs:element>  
      <xs:element name="ServiceManagement"  
                  minOccurs="0"  
                  maxOccurs="1">  
        <xs:complexType>  
          <xs:sequence>  
            <xs:element name="AppointmentBook"  
                        minOccurs="0"  
                        maxOccurs="1">  
              <xs:complexType>  
                <xs:sequence>  
                  <xs:element name="SmoothScrollLimit"  
                              type="xs:integer"  
                              minOccurs="0"  
                              maxOccurs="1" />  
                  <xs:element name="ValidationChunkSize"  
                              type="xs:integer"  
                              minOccurs="0"  
                              maxOccurs="1" />  
                  <xs:element name="TimeBlocks"  
                              minOccurs="0"  
                              maxOccurs="1">  
                    <xs:complexType>  
                      <xs:sequence>  
                        <xs:element name="TimeBlock"  
                                    type="TimeBlockNode"  
                                    minOccurs="0"  
                                    maxOccurs="unbounded" />  
                      </xs:sequence>  
                    </xs:complexType>  
                  </xs:element>  
                </xs:sequence>  
              </xs:complexType>  
            </xs:element>  
          </xs:sequence>  
        </xs:complexType>  
      </xs:element>  
    </xs:sequence>  
    <xs:attribute name="version"  
                  type="xs:string"  
                  use="required" />  
  </xs:complexType>  
  <!--  
A Timeblock definition  
-->  
  <xs:complexType name="TimeBlockNode">  
    <xs:attribute name="EntityType"  
                  type="xs:string"  
                  use="required" />  
    <xs:attribute name="StatusCode"  
                  type="xs:string"  
                  use="required" />  
    <xs:attribute name="CssClass"  
                  type="xs:string"  
                  use="required" />  
    <xs:attribute name="Client"  
                  type="xs:string"  
                  use="optional" />  
    <xs:attribute name="AvailableOffline"  
                  type="xs:boolean"  
                  use="optional" />  
  </xs:complexType>  
  <!--  
The Homepage Left Navigation Area  
-->  
  <xs:complexType name="NavigationArea">  
    <xs:sequence>  
      <xs:element minOccurs="0"  
                  maxOccurs="unbounded"  
                  name="NavBarItem">  
        <xs:complexType>  
          <xs:sequence>  
            <xs:element name="Titles"  
                        minOccurs="1"  
                        maxOccurs="1"  
                        type="LocalizedTitles" />  
          </xs:sequence>  
          <xs:attribute name="Icon"  
                        type="xs:string"  
                        use="required" />  
          <xs:attribute name="Url"  
                        type="xs:string"  
                        use="required" />  
          <xs:attribute name="Id"  
                        type="xs:string"  
                        use="required" />  
          <xs:attribute name="PassParams"  
                        type="CRM_Boolean"  
                        use="optional" />  
          <xs:attribute name="Client"  
                        type="xs:string"  
                        use="optional" />  
          <xs:attribute name="AvailableOffline"  
                        type="xs:boolean"  
                        use="optional" />  
        </xs:complexType>  
      </xs:element>  
    </xs:sequence>  
    <xs:attribute name="code"  
                  type="xs:string"  
                  use="required" />  
  </xs:complexType>  
  <!--  
A Menu that contains 1 or more Menu Items or Sub-Menus  
-->  
  <xs:complexType name="Menu">  
    <xs:sequence>  
      <xs:element name="Titles"  
                  minOccurs="0"  
                  maxOccurs="1"  
                  type="LocalizedTitles" />  
      <xs:group ref="MenuNodes"  
                minOccurs="0"  
                maxOccurs="unbounded" />  
    </xs:sequence>  
    <xs:attribute name="AccessKey"  
                  type="CRM_AccessKey"  
                  use="optional" />  
    <xs:attribute name="ValidForCreate"  
                  type="CRM_Boolean"  
                  use="optional" />  
    <xs:attribute name="ValidForUpdate"  
                  type="CRM_Boolean"  
                  use="optional" />  
  </xs:complexType>  
  <!--  
Valid nodes that may appear inside of a Menu  
This may appear in any order and may occur as many times as needed  
-->  
  <xs:group name="MenuNodes">  
    <xs:choice>  
      <xs:element name="MenuItem"  
                  type="MenuItem" />  
      <xs:element name="MenuSpacer" />  
      <xs:element name="SubMenu"  
                  type="Menu" />  
    </xs:choice>  
  </xs:group>  
  <!--  
A Menu Item that appears in a top-level menu or in a sub-menu  
-->  
  <xs:complexType name="MenuItem">  
    <xs:sequence>  
      <xs:element name="Titles"  
                  minOccurs="1"  
                  maxOccurs="1"  
                  type="LocalizedTitles" />  
    </xs:sequence>  
    <xs:attribute name="Url"  
                  type="xs:string"  
                  use="optional" />  
    <xs:attribute name="Icon"  
                  type="xs:string"  
                  use="optional" />  
    <xs:attribute name="WinMode"  
                  type="xs:unsignedByte"  
                  use="optional" />  
    <xs:attribute name="PassParams"  
                  type="CRM_Boolean"  
                  use="optional" />  
    <xs:attribute name="WinParams"  
                  type="xs:string"  
                  use="optional" />  
    <xs:attribute name="JavaScript"  
                  type="xs:string"  
                  use="optional" />  
    <xs:attribute name="Client"  
                  type="xs:string"  
                  use="optional" />  
    <xs:attribute name="AvailableOffline"  
                  type="xs:boolean"  
                  use="optional" />  
    <xs:attribute name="AccessKey"  
                  type="CRM_AccessKey"  
                  use="optional" />  
    <xs:attribute name="ValidForCreate"  
                  type="CRM_Boolean"  
                  use="optional" />  
    <xs:attribute name="ValidForUpdate"  
                  type="CRM_Boolean"  
                  use="optional" />  
  </xs:complexType>  
  <!--  
A Tool Bar that contains buttons  
-->  
  <xs:complexType name="ToolBar">  
    <xs:sequence>  
      <xs:choice maxOccurs="unbounded">  
        <xs:element name="Button">  
          <xs:complexType>  
            <xs:sequence>  
              <xs:element name="Titles"  
                          minOccurs="0"  
                          maxOccurs="1"  
                          type="LocalizedTitles" />  
              <xs:element name="ToolTips"  
                          minOccurs="0"  
                          maxOccurs="1"  
                          type="LocalizedToolTips" />  
            </xs:sequence>  
            <xs:attribute name="Icon"  
                          type="xs:string"  
                          use="optional" />  
            <xs:attribute name="Url"  
                          type="xs:string"  
                          use="optional" />  
            <xs:attribute name="JavaScript"  
                          type="xs:string"  
                          use="optional" />  
            <xs:attribute name="PassParams"  
                          type="CRM_Boolean"  
                          use="optional" />  
            <xs:attribute name="WinParams"  
                          type="xs:string"  
                          use="optional" />  
            <xs:attribute name="WinMode"  
                          type="xs:unsignedByte"  
                          use="optional" />  
            <xs:attribute name="Client"  
                          type="xs:string"  
                          use="optional" />  
            <xs:attribute name="AvailableOffline"  
                          type="xs:boolean"  
                          use="optional" />  
            <xs:attribute name="AccessKey"  
                          type="CRM_AccessKey"  
                          use="optional" />  
            <xs:attribute name="ValidForCreate"  
                          type="CRM_Boolean"  
                          use="optional" />  
            <xs:attribute name="ValidForUpdate"  
                          type="CRM_Boolean"  
                          use="optional" />  
          </xs:complexType>  
        </xs:element>  
        <xs:element name="ToolBarSpacer" />  
      </xs:choice>  
    </xs:sequence>  
    <xs:attribute name="ValidForCreate"  
                  type="CRM_Boolean"  
                  use="optional" />  
    <xs:attribute name="ValidForUpdate"  
                  type="CRM_Boolean"  
                  use="optional" />  
  </xs:complexType>  
  <xs:complexType name="LocalizedTitles">  
    <xs:sequence minOccurs="1"  
                 maxOccurs="unbounded">  
      <xs:element name="Title"  
                  type="LocalizedLabel" />  
    </xs:sequence>  
  </xs:complexType>  
  <xs:complexType name="LocalizedToolTips">  
    <xs:sequence minOccurs="1"  
                 maxOccurs="unbounded">  
      <xs:element name="ToolTip"  
                  type="LocalizedLabel" />  
    </xs:sequence>  
  </xs:complexType>  
  <xs:complexType name="LocalizedLabel">  
    <xs:attribute name="LCID"  
                  type="xs:integer" />  
    <xs:attribute name="Text"  
                  type="xs:string" />  
  </xs:complexType>  
  <xs:complexType name="EntityNode">  
    <xs:all>  
      <xs:element name="MenuBar"  
                  minOccurs="0"  
                  maxOccurs="1">  
        <xs:complexType>  
          <xs:sequence>  
            <xs:element name="CustomMenus"  
                        minOccurs="0"  
                        maxOccurs="1">  
              <xs:complexType>  
                <xs:sequence>  
                  <xs:element name="Menu"  
                              minOccurs="0"  
                              maxOccurs="unbounded"  
                              type="Menu" />  
                </xs:sequence>  
              </xs:complexType>  
            </xs:element>  
          </xs:sequence>  
        </xs:complexType>  
      </xs:element>  
      <xs:element name="ToolBar"  
                  minOccurs="0"  
                  maxOccurs="1"  
                  type="ToolBar" />  
      <xs:element name="NavBar"  
                  minOccurs="0"  
                  maxOccurs="1">  
        <xs:complexType>  
          <xs:sequence>  
            <xs:element maxOccurs="unbounded"  
                        name="NavBarItem">  
              <xs:complexType>  
                <xs:sequence>  
                  <xs:element name="Titles"  
                              minOccurs="1"  
                              maxOccurs="1"  
                              type="LocalizedTitles" />  
                </xs:sequence>  
                <xs:attribute name="Icon"  
                              type="xs:string"  
                              use="required" />  
                <xs:attribute name="Url"  
                              type="xs:string"  
                              use="required" />  
                <xs:attribute name="Id"  
                              type="xs:string"  
                              use="required" />  
                <xs:attribute name="PassParams"  
                              type="CRM_Boolean"  
                              use="optional" />  
                <xs:attribute name="Area"  
                              type="xs:string"  
                              use="optional" />  
                <xs:attribute name="Client"  
                              type="xs:string"  
                              use="optional" />  
                <xs:attribute name="AvailableOffline"  
                              type="xs:boolean"  
                              use="optional" />  
              </xs:complexType>  
            </xs:element>  
          </xs:sequence>  
          <xs:attribute name="ValidForCreate"  
                        type="CRM_Boolean"  
                        use="optional" />  
          <xs:attribute name="ValidForUpdate"  
                        type="CRM_Boolean"  
                        use="optional" />  
        </xs:complexType>  
      </xs:element>  
      <xs:element name="Grid"  
                  minOccurs="0"  
                  maxOccurs="1">  
        <xs:complexType>  
          <xs:sequence>  
            <xs:element name="MenuBar">  
              <xs:complexType>  
                <xs:sequence>  
                  <xs:element name="ActionsMenu"  
                              type="Menu"  
                              minOccurs="0" />  
                  <xs:element name="Buttons"  
                              type="ToolBar"  
                              minOccurs="0" />  
                </xs:sequence>  
              </xs:complexType>  
            </xs:element>  
          </xs:sequence>  
        </xs:complexType>  
      </xs:element>  
    </xs:all>  
    <xs:attribute name="name"  
                  type="xs:string"  
                  use="required" />  
    <xs:attribute name="Client"  
                  type="CRM_Client"  
                  use="optional" />  
    <xs:attribute name="AvailableOffline"  
                  type="xs:boolean"  
                  use="optional" />  
  </xs:complexType>  
  <xs:simpleType name="CRM_Client">  
    <xs:restriction base="xs:string">  
      <xs:pattern value="((None|Outlook|Web|All|OutlookWorkstationClient|OutlookLaptopClient),?)+" />  
    </xs:restriction>  
  </xs:simpleType>  
  <xs:complexType name="NavBarAreasType">  
    <xs:sequence>  
      <xs:element name="NavBarArea"  
                  minOccurs="0"  
                  maxOccurs="unbounded">  
        <xs:complexType>  
          <xs:sequence>  
            <xs:element name="Titles"  
                        minOccurs="1"  
                        maxOccurs="1"  
                        type="LocalizedTitles" />  
          </xs:sequence>  
          <xs:attribute name="Id"  
                        type="xs:string"  
                        use="required" />  
        </xs:complexType>  
      </xs:element>  
    </xs:sequence>  
  </xs:complexType>  
  <xs:complexType name="NavBarType">  
    <xs:choice minOccurs="0"  
               maxOccurs="100000">  
      <xs:element minOccurs="0"  
                  maxOccurs="1"  
                  name="NavBarItem">  
        <xs:complexType>  
          <xs:sequence>  
            <xs:element name="Titles"  
                        minOccurs="1"  
                        maxOccurs="1"  
                        type="LocalizedTitles" />  
          </xs:sequence>  
          <xs:attribute name="Icon"  
                        type="xs:string"  
                        use="required" />  
          <xs:attribute name="Url"  
                        type="xs:string"  
                        use="required" />  
          <xs:attribute name="Id"  
                        type="xs:string"  
                        use="required" />  
          <xs:attribute name="PassParams"  
                        type="CRM_Boolean"  
                        use="optional" />  
          <xs:attribute name="Area"  
                        type="xs:string"  
                        use="optional" />  
          <xs:attribute name="Client"  
                        type="xs:string"  
                        use="optional" />  
          <xs:attribute name="AvailableOffline"  
                        type="xs:boolean"  
                        use="optional" />  
        </xs:complexType>  
      </xs:element>  
      <xs:element name="NavBarByRelationshipItem"  
                  minOccurs="0"  
                  maxOccurs="1">  
        <xs:complexType>  
          <xs:all>  
            <xs:element name="Titles"  
                        minOccurs="0"  
                        maxOccurs="1"  
                        type="LocalizedTitles" />  
            <xs:element name="ToolTip"  
                        minOccurs="0"  
                        maxOccurs="1">  
              <xs:complexType>  
                <xs:sequence>  
                  <xs:element name="Titles"  
                              minOccurs="1"  
                              maxOccurs="1"  
                              type="LocalizedTitles" />  
                </xs:sequence>  
              </xs:complexType>  
            </xs:element>  
            <xs:element name="Privileges"  
                        minOccurs="0"  
                        maxOccurs ="1">  
              <xs:complexType>  
                <xs:sequence >  
                  <xs:element name ="Privilege"  
                              minOccurs ="1"  
                              maxOccurs ="100000">  
                    <xs:complexType>  
                      <xs:attribute name ="Entity"  
                                    type ="xs:string"  
                                    use ="required"/>  
                      <xs:attribute name="Privilege"  
                                    type ="xs:string"  
                                    use ="required"/>  
                    </xs:complexType>  
                  </xs:element>  
                </xs:sequence>  
              </xs:complexType>  
            </xs:element>  
          </xs:all>  
          <xs:attribute name="RelationshipName"  
                        type="xs:string"  
                        use="required" />  
          <xs:attribute name="Id"  
                        type="xs:string"  
                        use="required" />  
          <xs:attribute name="Area"  
                        type="xs:string"  
                        use="optional" />  
          <xs:attribute name="TitleResourceId"  
                        type="xs:string"  
                        use="optional" />  
          <xs:attribute name="Client"  
                        type="xs:string"  
                        use="optional" />  
          <xs:attribute name="AvailableOffline"  
                        type="xs:boolean"  
                        use="optional" />  
          <xs:attribute name="Icon"  
                        type="xs:string"  
                        use="optional" />  
          <xs:attribute name="Sequence"  
                        type="xs:nonNegativeInteger"  
                        use="optional" />  
          <xs:attribute name="Show"  
                        type="xs:boolean"  
                        use="optional" />  
          <xs:attribute name="ViewId"  
                        type="ISVGuid"  
                        use="optional" />  
        </xs:complexType>  
      </xs:element>  
    </xs:choice>  
    <xs:attribute name="ValidForCreate"  
                  type="CRM_Boolean"  
                  use="optional" />  
    <xs:attribute name="ValidForUpdate"  
                  type="CRM_Boolean"  
                  use="optional" />  
  </xs:complexType>  
  <xs:simpleType name="ISVGuid">  
    <xs:restriction base="xs:string">  
      <xs:pattern value="\{?[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}\}?" />  
    </xs:restriction>  
  </xs:simpleType>  
  
  <xs:simpleType name="CRM_Boolean">  
    <xs:restriction base="xs:unsignedByte">  
      <xs:minInclusive value="0" />  
      <xs:maxInclusive value="1" />  
    </xs:restriction>  
  </xs:simpleType>  
  <xs:simpleType name="CRM_AccessKey">  
    <xs:restriction base="xs:string">  
      <xs:length value="1" />  
    </xs:restriction>  
  </xs:simpleType>  
</xs:schema>  
  
```  
  
### See also  
 [Service calendar appearance configuration](service-calendar-appearance-configuration.md)   
 [Schemas Used in Microsoft Dynamics 365 Customer Engagement](../schemas-used-dynamics-365.md)   
 [Schema Support for the Customization File](edit-customizations-xml-file-schema-validation.md)   
 <xref:Microsoft.Crm.Sdk.Messages.ExportSolutionRequest.ExportIsvConfig>


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]