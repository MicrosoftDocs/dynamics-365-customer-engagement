---
title: Customize column headers of the forecast grid
description: Learn how to customize the column headers of the forecast grid
ms.date: 06/13/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---


# Customize column headers of the forecast grid

Using custom controls in Power Apps, you can customize column headers in the forecast grid. For example, you can change the label of the headers, add a tool tip for additional context, or translate the header.  

## Prerequisites

- You must have a good knowledge and experience with creating custom controls in Power Apps.  

- Create and build a code component for the column header component. For more information, see [Create and build a code component](/power-apps/developer/component-framework/create-custom-controls-using-pcf).

## Add the column header resource file

Add the column header resource file to specify the string customizations such the column names and its translations.  

1. Create the following folder structure under your component folder:  
    ```ColumnHeader > strings```
1.  Create a resource file with the following content:
    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <root>
    
      <xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
        <xsd:import namespace="http://www.w3.org/XML/1998/namespace" />
        <xsd:element name="root" msdata:IsDataSet="true">
          <xsd:complexType>
            <xsd:choice maxOccurs="unbounded">
              <xsd:element name="metadata">
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element name="value" type="xsd:string" minOccurs="0" />
                  </xsd:sequence>
                  <xsd:attribute name="name" use="required" type="xsd:string" />
                  <xsd:attribute name="type" type="xsd:string" />
                  <xsd:attribute name="mimetype" type="xsd:string" />
                  <xsd:attribute ref="xml:space" />
                </xsd:complexType>
              </xsd:element>
              <xsd:element name="assembly">
                <xsd:complexType>
                  <xsd:attribute name="alias" type="xsd:string" />
                  <xsd:attribute name="name" type="xsd:string" />
                </xsd:complexType>
              </xsd:element>
              <xsd:element name="data">
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
                    <xsd:element name="comment" type="xsd:string" minOccurs="0" msdata:Ordinal="2" />
                  </xsd:sequence>
                  <xsd:attribute name="name" type="xsd:string" use="required" msdata:Ordinal="1" />
                  <xsd:attribute name="type" type="xsd:string" msdata:Ordinal="3" />
                  <xsd:attribute name="mimetype" type="xsd:string" msdata:Ordinal="4" />
                  <xsd:attribute ref="xml:space" />
                </xsd:complexType>
              </xsd:element>
              <xsd:element name="resheader">
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
                  </xsd:sequence>
                  <xsd:attribute name="name" type="xsd:string" use="required" />
                </xsd:complexType>
              </xsd:element>
            </xsd:choice>
          </xsd:complexType>
        </xsd:element>
      </xsd:schema>
      <resheader name="resmimetype">
        <value>text/microsoft-resx</value>
      </resheader>
      <resheader name="version">
        <value>2.0</value>
      </resheader>
      <resheader name="reader">
        <value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
      </resheader>
      <resheader name="writer">
        <value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
      </resheader>
      <data name="Forecast" xml:space="preserve">
        <value>Projections</value>
      </data>
      <data name="Won" xml:space="preserve">
        <value>Deals won</value>
      </data>
    </root>
        ```
1. Add your header customizations using the ```<data>``` node.  
    In the above code sample, **Forecast** and **Won** column names are overridden with **Projections** and **Deals won**.

3. Save the file using the following naming convention:
    filename.languagecode.xml
    Example: ColumnHeader.1033.xml
4. Repeat steps 1 through 4 to add language-specific resource files. For example, to add French translations for column names, add a resource file named ColumnHeader.1036.xml.

## Modify the manifest file

The control manifest is an XML file that contains the metadata of the code component. It also defines the behavior of the code component. 

1. Open the ControlManifest.Input.XML file.

1. Update the ```control``` node as follows:
     ```xml
      <control namespace="YourNamespace" constructor="ColumnHeader" version="0.0.2" display-name-key="ColumnHeader" description-key="ColumnHeader description" control-type="standard" >
     ```
1. Add the following ```property``` node to specify that you're overriding the columnName property:
    `<property name="columnName" display-name-key="Property_Display_Key" description-key="Property_Desc_Key" of-type="SingleLine.Text" usage="bound" required="true" />` 

1. Add the `<resources>` node to specify the path to the resource files that includes the customizations:
    ```xml
    <resources>
      <code path="index.ts" order="1"/>
      <!-- UNCOMMENT TO ADD MORE RESOURCES
      <css path="css/ColumnHeader.css" order="1" />
      -->
      <resx path="strings/ColumnHeader.1033.resx" version="1.0.0" />
      <resx path="strings/ColumnHeader.1036.resx" version="1.0.0" />
    </resources>
    ```
1. Add the `<resx path>` tag for the languages that you're translating the header content into. In the preceding sample, we've added the resource files for English and French languages.

## Update the index.ts file

The next step after modifying the manifest file is to implement the component logic inside the ```index.ts``` file.

1. Open the ```index.ts``` file.
1. Add the following lines in the `updateView` method:
  
    ```xml
    public updateView(context: ComponentFramework.Context<IInputs>): void
        {
            // Add code to update control view
            const colName = (context.parameters.columnName && context.parameters.columnName.raw) || "";
            this._container.innerHTML = context.resources.getString(colName);
        }
    ```  

## Next steps  
- [Package a code component](/power-apps/developer/component-framework/import-custom-controls)
- [Override column headers (preview)](forecast-configure-advanced-settings.md#override-column-headers-preview)

