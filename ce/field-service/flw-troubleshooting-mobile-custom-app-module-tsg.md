---
title: The Field Service Mobile App Module does not show the Settings area, so I can't enable the new Native experience
description: The Field Service Mobile App Module does not show the Settings area, so I can't enable the new Native experience
ms.date: 09/19/2023
ms.topic: troubleshooting
author: andrea-orimoto
ms.author: andreo
ms.reviewer: 
ms.custom: bap-template
---

Michael the content for [this page is here](https://eng.ms/docs/cloud-ai-platform/business-applications-and-platform/bap-frontline/field-service/field-service-mobile/troubleshooting-guides/native/configuration/enablesettingsarea)

1. summarize as needed
2. clean up screenshots (names, etc.)


# Enable Settings Area and Toggle on FSM Sitemap
The new Native Experience app setting toggle is available through a new "Settings" sitemap area shipped in the **OOB FSM app module**. Additionally, this area is **only accessible to users with write-permissions for the `FieldServiceSetting` entity (e.g., System Admin, FS Admin roles).**

> Note: Any clones/copies of the OOB FSM app module done before the (2023) FS 6.3 release ([see release calendar](https://eng.ms/docs/cloud-ai-platform/business-applications-and-platform/bap-frontline/field-service/dynamics-365-field-service/engineering-docs/releases/calendar)) will have to [manually add the Settings area and toggle to the sitemap of the custom app module](#manually-add-settings-area-and-toggle-to-sitemap).

> Note: If any customizations were made on the sitemap of the OOB FSM app module between the (2023) FS 6.1 and 6.3 releases ([see release calendar](https://eng.ms/docs/cloud-ai-platform/business-applications-and-platform/bap-frontline/field-service/dynamics-365-field-service/engineering-docs/releases/calendar)), then there are two options to enable the Settings Area:
> 1. [Remove the sitemap customization layer and then manually customize it again](#customization-layer-on-the-sitemap-of-the-oob-fsm-app-module).
> 2. [Manually add the Settings area and toggle to the sitemap](#manually-add-settings-area-and-toggle-to-sitemap).

![image.png](./resources/enableSettingsArea_finalProduct.png)

## FCB (Feature Control Bit) and FCS (Feature Control Setting)
Before Public Preview, the sitemap area in the **OOB FSM app module** was hiding via two controls, FCB and FCS, which were turned ON at launch:
- FCB: `FCB.FSMobilePreviewSettings`
- FCS:
  - Namespace: `FieldService.FSMobile`
  - Key: `ShowSettingsAreaOnSitemap`

Therefore, both the FCB and the FCS have to be enabled for the sitemap to be visible.

### Check FCB and FCS
To check whether they are enabled, open the FSM app module on a desktop browser and then open the DevTools Inspector (`CTRL+SHIFT+I`). Then, type the following in the Console:
- FCB: `Xrm.Internal.isFeatureEnabled("FSMobilePreviewSettings")`
- FCS: `Xrm.Utility.getGlobalContext().getFeatureControlSetting("FieldService.FSMobile","ShowSettingsAreaOnSitemap")`

### Enable FCB and FCS
If either is disabled (Console commands return `false`), they can be enabled with the following instructions:
- FCB
  - Option 1 [temporary]: Directly on browser url: `&flags=FCB.FSMobilePreviewSettings=true`.
  - Option 2 [permanent]: [Enabling FCB in Jarvis Action](https://dynamicscrm.visualstudio.com/OneCRM/_wiki/wikis/OneCRM.wiki/31533/Enabling-FCB-in-Jarvis-Action)
- FCS
  - [Overrides for FeatureControlSettings - Overview](https://dev.azure.com/dynamicscrm/OneCRM/_wiki/wikis/OneCRM.wiki/15040/Overrides-for-FeatureControlSettings).
    - The override file where changes are needed already exists: [FieldService.FSMobile.overrides.ini - Repos](https://dynamicscrm.visualstudio.com/OneCRM/_git/CRM.FeatureConfigSettings?path=/src/Apps/FieldService/FSMobile/Overrides/FieldService.FSMobile.overrides.ini)
    > **IMPORTANT:** Make sure to do the override for the specific org or scale group without affecting other production (customer) orgs.

## Customization layer on the sitemap of the OOB FSM app module
To check whether the Sitemap area exists on the OOB FS solution layer but was overriden in a customization layer sitting on top:
1. Open FS on a desktop browser
2. Go to Advanced Settings -> Customizations -> Client Extensions -> Field Service Mobile -> Solution Layers
3. Search for `msdyn_FSMobileSettingsArea` in the `fieldservice_patch_update` solution layer

![image.png](./resources/enableSettingsArea_solutionLayer.png)

If the area is present and both the FCB and FCS are enabled, then most likely there is a customization layer on the sitemap sitting at the top which does not contain (removed) the area. In that case, there are two options:
1. Remove the customization layer and then manually customize the sitemap again.
   1. In the "Solution Layers" window, click on the "..." button on the customization layer, and then click on "Remove Active Customizations".
   2. Then, re-apply the [sitemap customizations](https://learn.microsoft.com/en-us/power-apps/maker/model-driven-apps/create-site-map-app).
2. [Manually add the Settings area and toggle to the sitemap](#manually-add-settings-area-and-toggle-to-sitemap).

![image.png](./resources/enableSettingsArea_customLayer.png)

## Manually add Settings area and toggle to sitemap
1. Open the corresponding app module in the App Designer.
2. Click "Settings", select "Navigation", and check "Enable Areas".

![image.png](./resources/enableSettingsArea_enableSitemapAreas.png)

3. Underneath the "Pages" header (left panel), click the areas dropdown, and then click "New area".
   1. Give the new area a Title (right panel), we recommend "Settings".
   2. Give the new area an ID (right panel), we recommend "msdyn_FSMobileSettingsArea".

![image.png](./resources/enableSettingsArea_newArea.png)

4. Click the "New Group" created for the new area under "Navigation".
   1. Give the new group a Title, we recommend "Mobile settings".
   2. Give the new group an ID, we recommend "msdyn_MobileSettingsGroup".
5. Click "+ Add page" or "+ New".
6. Select "URL" as content for the page. Click "Next".
7. Copy and paste the following into the "URL" input.
   - `/main.aspx?etn=msdyn_fieldservicesetting&pagetype=entityrecord&id=e49c6117-5065-423f-8ab5-fcacfda85a04&formid=ee334fea-0cd5-471c-bb30-829f4511a59f`
8. Give the subarea a Title, we recommend "Preview features". Click "Add".
9.  Give the subarea an ID, we recommend "msdyn_PreviewFeaturesSubArea".
10. Expand "Advanced settings" and "Privileges".
11. Click "Add table privilege", select "Field Service Setting", check only the "Write" privilege, and click "Apply".

![image.png](./resources/enableSettingsArea_addTablePrivilege.png)

12. Save and Publish.

## Release Dates
- App Setting (`LaunchNativeExperience`):
  - [CRM] 2034.2
  - [Mobile Player] t2305.4
- FCB (`FCB.FSMobilePreviewSettings`):
  - [CDS/UCI] 2305.3
- Sitemap Area:
  - [FS] 6.1
- FCS (`FieldService.FSMobile.ShowSettingsAreaOnSitemap`):
  - [FS] 6.3

Enabled FCS/FCB on August 9th, 2023 (Public Preview - Marketing Moment).