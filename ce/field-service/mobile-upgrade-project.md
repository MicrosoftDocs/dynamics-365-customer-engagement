---
title: "Upgrade the Field Service Mobile Project Template | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/09/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Upgrade the Field Service Mobile Project Template

Dynamics 365 Field Service comes with a mobile project template that serves as a baseline template for how the Field Service Mobile app should look and function. As an example, it has default views and forms for work orders, as well as logic that runs when a work order is saved, among many other customizations for various field service entities: bookings, customer assets, etc. Customers and partners build on top of the mobile project template to edit the mobile app for their specific business needs. See the topic on [Common Field Service Mobile customizations](./mobile-app-configuration-customization.md).

Periodically, Microsoft releases a new mobile project template when major and minor updates to the Field Service Mobile app are released.

[Download the latest Field Service Mobile Project Template](https://aka.ms/fsmobile-project)

## Starting a new mobile project

If you have a new field service environment and want to set up the mobile app simply,

1. [Download the latest Field Service Mobile Project Template](https://aka.ms/fsmobile-project) and 
2. Follow the instructions to [import and derive it in the mobile configuration tool (Woodford)](https://docs.microsoft.com/en-us/dynamics365/field-service/install-field-service#import-the-mobile-project-template)

## Upgrading an existing mobile project

In other scenarios, you may have been using and customizing a field service mobile project template, and Microsoft has released a new template. In this scenario, you want to use the new template while keeping your customizations.

This applies to customers who were using the project for Field Service Mobile version 9 and want to upgrade to version 11+ which has a new project template. 

Here is an example:

1. You imported a field service mobile project template from Microsoft and published it
2. You derived that project and made customizations for your organization


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-upgrade-project-customizations.png)

Now Microsoft has released a new mobile project template (Example: FSDyn_1.0.2735).

You have 2 options:

1. Import the new project template from Microsoft, derive the template, and manually recreate your customizations in the derived child
2. Use GitHub to understand the difference between the new project template and your customized project template and copy and paste the changes. 

Below are steps for option 2:

- Determine which Microsoft project template you customized. View the [version history](https://docs.microsoft.com/en-us/dynamics365/field-service/version-history#mobile-project-file-library) to find and download if you do not have the template.
- Once you have the project determined, download your customized project on your desktop along with the original Microsoft project that you started customizing. Simply select and highlight your project and choose Export.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-upgrade-project-export.png)

- Download Github Desktop. 
- Open Github Desktop and initialize a repo in a folder of your choosing. 
- Rename the .Woodford files for your project and ours to .zip. Extract it and drag the Microsoft project files from the extraction into the folder where you initialized the Git repo. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-upgrade-extract.png)


- Commit this to the master branch in Github desktop. 
- Create a new branch in Github Desktop and call it “customizations.” 
- Drag the extracted files from YOUR customized project files into same folder where you initialized the Git repo and placed the files before. 
- Open Github desktop, click refresh, and ensure you are on the “customizations” branch. You should then see the diff of YOUR project compared to the Microsoft project. 
- In the Mobile Configuration Tool (Woodford), [download](https://aka.ms/fsmobile-project) and import the latest Field Service Mobile project. Create a child project off of the Microsoft project by clicking **Derive** in Woordford. Export the derived child project, rename the downloaded project extension from .Woodford to .zip and extract it as above. 
- For any files that are called out as being a diff from our original, you will need to copy those files/folders into the NEW derived child project.
- Zip the NEW derived child project and rename the project extension from .zip to .woodford.
- Go into the Mobile Configuration Tool (Woodford) and highlight the New derived child project that was exported a few steps ago. Click the Import button and upload your NEW child project that contains the diff customizations. When prompted to ‘Overwrite’ the derived child project, click yes.
- Now publish your new child project and begin testing 


## Configuration considerations
If you make changes to a mobile entity, it will show as **Overridden**. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-upgrade-overridden.png)

### See also

- [Version history](https://docs.microsoft.com/en-us/dynamics365/field-service/version-history#mobile-project-file-library)
- [Set up Field Service Mobile](https://docs.microsoft.com/en-us/dynamics365/field-service/install-field-service#download-the-field-service-mobile-app-on-a-phone-or-tablet)
- [Common Field Service Mobile customizations](./mobile-app-configuration-customization.md)
