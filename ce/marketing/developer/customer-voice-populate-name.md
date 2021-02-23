---
title: "Attach names and emails to Dynamics 365 Customer Voice surveys sent from customer journeys (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn how to map names and emails to surveys with a custom Power Automate flow."
ms.date: 01/22/2021
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

# Attach names and emails to Dynamics 365 Customer Voice surveys sent from customer journeys

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

Standalone Dynamics 365 Customer Voice surveys function as expected, returning names and email addresses when a survey is filled out. The steps below only apply to Dynamics 365 Customer Voice surveys sent from Dynamics 365 Marketing.

## Export Dynamics 365 Customer Voice survey responses to Microsoft Excel

The export to Excel feature uses Microsoft Dataverse information to join and pull the contact record information for Marketing integration customers, making it available in Excel.

To export survey response data to Excel:

1. Enter the following URL into your browser, replacing the value for {surveyidentifier} with the ID of your chosen survey:

    ```https://forms.office.com/FormsPro/Pages/DesignPage.aspx?experienceType=Pro#Analysis=true&FormId={suveyidentifier}```

    > [!NOTE]
    > Do not confuse the survey identifier with the GUID. To find the survey identifier in the Dynamics 365 Customer Voice survey entity, look in the **Source survey identifier** field.
	>
    > The survey identifier will look like the following string: <br>
    ```v4j5cvGGr0GRqy180BHbR8HxyywSGiFAkJ7eG-r1E-9UODI0UzIzUFBOM1FTUENON0pQV1UzV0VTNi4u```

1. After the page loads, select the **Responses** tile.

1. To export the response data, select **Export all**.

### See also

[Use Dynamics 365 Customer Voice surveys with Dynamics 365 Marketing](../customer-voice.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]