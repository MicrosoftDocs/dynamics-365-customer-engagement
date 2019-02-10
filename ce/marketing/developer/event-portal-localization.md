---
title: "Custom event portal localization| MicrosoftDocs"
description: "Provides information about how you can extend event management web application functionality."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 2/06/2019
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

Localization on the frontend part (Angular application) is supported using custom `appTranslate` directive made for Event Management application. You can see the usage of the directive throughout the application and the directive implementation itself in the `/src/app/components/directives/translate.directive.ts`. To add a new localized content you have to apply the directive to the newly added content. If you added a new paragraph like this for example:

`<p>this is my new paragraph</p>`

You need to come up with the name of the label and apply directive. If you name your label as `NewLabel` it would result in this:

`<p [appTranslate]="'NewLabel'">this is my new paragraph</p>`

After you add the directive in the code, you need to add the label in your localization files. They are located under `/Localization` folder. It contains a lot of files named in `portalLCID.json` format. To add the translated label for the English language for example modify the `portal1033.json` file. It contains the labels in the Json format, so in order to add new label you can append the following Json object to the file:

```
"NewLabel": {
  "Purpose": "This only describes the purpose of this label",
  "Value": "this is my new paragraph in English"
}
```

After doing this the resulting paragraph should contain text `this is my new paragraph in English` if you have actually selected English as a active website language. As you added the label for English only, the other languages will default to the original text in this moment: `this is my paragraph`.

## Backend part

The localization files containing labels are not bundeled up with the application themselves. They need to be hosted independently. 

If you are using [Dynamics 365 Portal hosting](portal-hosted.md), then the script `DeployToDynamics365Instance.ps1` will take care to put the localization file to the right place. In that case point the `localizationEndpoint` environment setting to the `localization/` path as shown in provided `environment.d365.ts` sample environment.

If you are using [self-hosted](self-hosted.md) approach, then you need to choose yourself where do you want to host the files (they can of course be on the same server as the application), and then you should modify `localizationEndpoint` environment setting to point to that location.

## See also

[Event Portal](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/set-up-event-portal)<br />
[Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-whatis)
