---
title: Customize column headers in the forecast grid
description: Learn how to customize the column headers of the forecast grid.
ms.date: 12/16/2022
author: lavanyakr01
ms.author: lavanyakr
ms.topic: how-to
ms.custom: bap-template
---

# Customize column headers in the forecast grid

You can customize column headers in the forecast grid using Power Apps code components. For example, you can translate the column name or add a tooltip for additional context.  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System administrator or customizer <br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## How to customize the header

Let's understand the customizations with an example. We'll add the French translation for the column names **Forecast** and **Won** in the forecast grid.  

1. [Create a code component](/power-apps/developer/component-framework/create-custom-controls-using-pcf#create-a-new-component) with the name ```ColumnHeader```  
1. [Create a resource file and add translations](#create-a-resource-file-and-add-translations)
1. [Implement the manifest](#implement-the-manifest)
1. [Implement the component logic](#implement-the-component-logic)
1. [Build and package the component](#next-steps)

### Create a resource file and add translations

After you create the code component, the `ColumnHeader` folder is created in the path you've specified. Let's create a resource file and add the French translations in the resource file.

1. Create a folder named ```strings``` under the ```ColumnHeader``` folder.

1. Copy the following code to a new file, ColumnHeader.1036.resx.
    > [!NOTE]
    > The number 1036 in the file name is the language code for French. For a list of language codes, see [this article](/openspecs/office_standards/ms-oe376/6c085406-a698-4e12-9d4d-c3b0ee3dbc4a). 
 
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
        <value>Prévision</value>
      </data>
      <data name="Won" xml:space="preserve">
        <value>Gagné</value>
      </data>
    </root>
    ```
 
    In the above code sample, the column names for **Forecast** and **Won** are overridden with the French translations **Prévision** and **Gagné** respectively in the `<data>` node.
    
    > [!NOTE]
    > In the `name` parameter, specify the exact column name that you've configured in the **Layout** step of the forecast.
    > 
    > :::image type="content" source="media/forecast-column-names.png" alt-text="A screenshot of the column names in the **Layout** step of the forecast configuration":::  

    If you want to translate the column name into additional languages, create a resource file for each language that you want to translate into. Make sure that the resource file name uses the following naming convention:  
        
    ```
    filename.languagecode.resx  
    **Example file name for German:** ColumnHeader.1031.resx
    ```


### Implement the manifest

Next, we'll modify the manifest file to specify the property that we're overriding. In our example, we're overriding the `ColumnName` property. We'll also specify the path to the resource file that contains the translated text.

1. Open the `ControlManifest.Input.XML` file.

1. Search for the ```property``` node and replace it with the following code as-is:
    
    `<property name="columnName" display-name-key="Property_Display_Key" description-key="Property_Desc_Key" of-type="SingleLine.Text" usage="bound" required="true" />`  

1. Update the `<resources>` node to specify the path to the resource file that includes the French translations:
    ```xml
    <resources>
      <code path="index.ts" order="1"/>
      <!-- UNCOMMENT TO ADD MORE RESOURCES
      <css path="css/ColumnHeader.css" order="1" />
      -->
      <resx path="strings/ColumnHeader.1036.resx" version="1.0.0" />
    </resources>
    ```
    The `<resx path>` node contains the resource file path. In the preceding code sample, we've added the resource file for the French language. If you have translations for other languages, add the resource file path for those languages as well.

### Implement the component logic  

Let's add the code to implement the component logic in the ```index.ts``` file.

1. Open the ```index.ts``` file.
1. Add the following lines in the `updateView` method:
  
    ```java
    public updateView(context: ComponentFramework.Context<IInputs>): void
        {
            // Add code to update control view
            const colName = (context.parameters.columnName && context.parameters.columnName.raw) || "";
            this._container.innerHTML = context.resources.getString(colName);
        }
    ```

### Next steps
  
- [Build the code component](/power-apps/developer/component-framework/create-custom-controls-using-pcf#build-your-component)  
- [Package the code component](/power-apps/developer/component-framework/import-custom-controls)  
- [Override column headers (preview)](forecast-configure-advanced-settings.md#override-column-headers-preview)  
