---
title: "Custom event portal localization (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Provides information about how you can extend event management web application functionality."
ms.date: 02/06/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Custom Event Portal Localization

## Frontend part

Localization on the frontend part (Angular application) is supported using custom `appTranslate` directive made for event management application. You can see the usage of the directive throughout the application and the directive implementation itself in the `/src/app/components/directives/translate.directive.ts`. To add new localized content, you have to apply the directive to the newly added content. If you added a new paragraph for example:

`<p>this is my new paragraph</p>`

You need to name the label and apply the directive. If you name the label as `NewLabel` it results in this:

`<p [appTranslate]="'NewLabel'">this is my new paragraph</p>`

After you add the directive in the code, you need to add the label in your localization files located under `/Localization` folder. This directory contain a JSON file for each language that is supported. The localization files use the [Windows Language Code Identifier (LCID)](https://docs.microsoft.com/openspecs/windows_protocols/ms-lcid/70feba9f-294e-491e-b6eb-56532684c37f) as naming schema (e.g. `1033.json`). 

To add the translated label, modify the `1033.json` file (this file contains all english translations). It contains the labels in the JSON format, so to add the new label you can append the following to the JSON object:

```JSON
"NewLabel": "this is my new paragraph in English"
```

After doing this, the resulting paragraph should contain the text `this is my new paragraph in English`, if you have selected English as a current website language. Since you have added the label for English only, other languages default to the original text `this is my new paragraph`.

## Backend part

The localization files containing labels are not bundled up with the application themselves. They need to be hosted independently. 

If you are using [Power Apps portal hosting](portal-hosted.md), then the script `DeployToDynamics365Instance.ps1` takes care to put the localization file to the right place. In this case the `localizationEndpoint` environment setting points to the `localization/` path as shown in the `environment.d365.ts` sample environment.

If you are using [self-hosted](self-hosted.md), then you need to choose a place to host the files (they can be on the same server as the application), and then you should modify `localizationEndpoint` environment setting to point to that location.

## See also

[Custom Event Portal](event-management-web-application.md)<br />
[Azure Active Directory](https://docs.microsoft.com/azure/active-directory/fundamentals/active-directory-whatis)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]