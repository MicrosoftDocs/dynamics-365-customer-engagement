---
title: Sales accelerator FAQs
description: Get answers to frequently asked questions about sales accelerator.
ms.date: 03/15/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Sales accelerator FAQs

This article answers frequently asked questions about sales accelerator in Dynamics 365 Sales and Sales premium.

## How do I add the Up next widget to an entity form?

You can add the **Up next** widget only to managed entity forms. To add the **Up next** widget to a managed entity form, create a solution, modify the XML files, and then import the solution.

#### Create a solution

1. Go to **Settings** > **Solutions**, and then create an empty solution; for example, **AddWidget**.  
1. Add a **Form** to the solution.  
1. Save the changes and publish the customizations.
1. Export the created **AddWidget** solution as **UnManaged**.
1. Delete the solution **AddWidget** from the organization.
1. Extract the zip file of the downloaded solution.

#### Modify the XML files

1. In the file `solution.xml`, change the `<Managed>` value to **1**.
1. In the `customizations.xml` file, delete the parameter `<systemform unmodified="1">`.
1. On the **Summary** tab, select the `<column>` where you want to add the widget.
1. Add the `<section>` tag as follows:

    ```xml
    <section name="CadenceWidget" showlabel="false" showbar="false" id="{<NEW_GUID_G1>}" IsUserDefined="0" layout="varwidth" columns="1" labelwidth="115" celllabelalignment="Left" celllabelposition="Left" labelid="{<NEW_GUID_G2> }">
      <labels>
          <label description="Cadence Widget" languagecode="1033" />
      </labels>
      <rows>
          <row>
              <cell id="{<NEW_GUID_G3>}" showlabel="false" colspan="1" rowspan="6" labelid="{<NEW_GUID_G4> }">
                  <labels>
                      <label description="Cadence widget" languagecode="1033" />
                  </labels>
                  <control id="CadenceWidgetControl" classid="{F9A8A302-114E-466A-B582-6771B2AE0D92}"  uniqueid="{<NEW_GUID_G5>}" isunbound="true">
                      <parameters />
                  </control>
              </cell>
          </row>
          <row />
          <row />
          <row />
          <row />
          <row />
      </rows>
    </section>
    ``` 
1. Replace all the `<NEW_GUID_G>` occurrences by generating a new GUID for each place.  
1. In the `<controlDescriptions>` node, add a child node:  
    ```xml
    <controlDescription forControl="{<GUID_G5>}">
    <customControl formFactor="2" name="MscrmControls.AcceleratedSales.CadenceWidgetControl">
        <parameters />
    </customControl>
    <customControl formFactor="0" name="MscrmControls.AcceleratedSales.CadenceWidgetControl">
        <parameters />
    </customControl>
    <customControl formFactor="1" name="MscrmControls.AcceleratedSales.CadenceWidgetControl">
        <parameters />
    </customControl>
    </controlDescription>
    ```     
1. Replace the `<GUID_G5>` in `customizations.xml` with the **GUID_G5** generated from **step 11**.  
1. Save the changes and zip the folder.  

#### Import the solution

1. Open Dynamics 365 and go to **Settings** > **Solutions**.  
1. Import the zipped solution.  
1. Publish all customizations.  
1. Verify that the **Up next** widget successfully shows up on the form.

## How do I add the sales accelerator site map to my custom app?

Use the site map designer in the app designer to [add the sales accelerator site map to your custom app](add-sales-accelerator-sitemap-entry-custom-app.md).
