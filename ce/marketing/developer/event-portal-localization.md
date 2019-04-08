---
title: "Custom event portal localization| MicrosoftDocs"
description: "Provides information about how you can extend event management web application functionality."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 02/06/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - "marketing"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
author: Nkrb
ms.author: nabuthuk
manager: kvivek
---

# Custom Event Portal Localization

## Frontend part

Localization on the frontend part (Angular application) is supported using custom `appTranslate` directive made for Event Management application. You can see the usage of the directive throughout the application and the directive implementation itself in the `/src/app/components/directives/translate.directive.ts`. To add a new localized content you have to apply the directive to the newly added content. If you added a new paragraph for example:

`<p>this is my new paragraph</p>`

You need to name the label and apply directive. If you name the label as `NewLabel` it would result in this:

`<p [appTranslate]="'NewLabel'">this is my new paragraph</p>`

After you add the directive in the code, you need to add the label in your localization files located under `/Localization` folder. It contains a lot of files named in `portalLCID.json` format. To add the translated label , modify the `portal1033.json` file. It contains the labels in the Json format, so in order to add new label you can append the following Json object to the file:

```JSON
"NewLabel": {
  "Purpose": "This only describes the purpose of this label",
  "Value": "this is my new paragraph in English"
}
```

After doing this, the resulting paragraph should contain text `this is my new paragraph in English` if you have selected English as a active website language. Since you have added the label for English only, other languages will default to the original text `this is my new paragraph`.

## Backend part

The localization files containing labels are not bundeled up with the application themselves. They need to be hosted independently. 

If you are using [Dynamics 365 Portal hosting](portal-hosted.md), then the script `DeployToDynamics365Instance.ps1` will take care to put the localization file to the right place. In this case the `localizationEndpoint` environment setting  points to the `localization/` path as shown in `environment.d365.ts` sample environment.

If you are using [self-hosted](self-hosted.md), then you need to choose a place to host the files (they can be on the same server as the application), and then you should modify `localizationEndpoint` environment setting to point to that location.

## See also

[Custom Event Portal](event-management-web-application.md)<br />
[Azure Active Directory](https://docs.microsoft.com/azure/active-directory/fundamentals/active-directory-whatis)
