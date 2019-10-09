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

Here are the steps you can follow to perform a field service mobile project version 9 to version 11+ upgrade. Note, in the first step, it is important to determine which version of our project you started customizing and you need that original file. If you and your team does not have this, please send MS support your project file and they we will attempt to determine and provide you the original project file. This is needed to generate the Git Diff between our original and your customized project. 

- Determine which project you started customizing. Please send us your project if you do not have the original project of ours and I will have our team take a look and try to determine which project of ours you started customizing. 
- Once you have the project determined, download your project on your desktop along with our original project that you started customizing (we will get you this if you don’t have it).
- Download Github Desktop. 
- Open Github Desktop and initialize a repo in a folder of your choosing. 
- Rename the .Woodford files for your project and ours to .zip. Extract it and drag OUR Woodford project files from the extraction into the folder where you initialized the Git repo. 
- Commit this to the master branch in Github desktop. 
- Create a new branch in Github Desktop and call it “customizations.” 
- Now drag the extracted files from YOUR Woodford project files into same folder where you initialized the Git repo and placed the files before. 
- Now open Github desktop, click refresh, and ensure you are on the “customizations” branch. You should then see the diff of YOUR project compared to OUR project. 
- Now in Woodford import the latest Field Service Mobile project(download from https://aka.ms/fsmobile-project). Create a child project off of our project by clicking Derive in Woordford. Export the derived child project, rename the downloaded project extension from .Woodford to .zip and extract it as above. 
- For any files that are called out as being a diff from our original, you will need to copy those files/folders into the NEW derived child project.
- Zip the NEW derived child project and rename the project extension from .zip to .woodford.
- Go into Woodford and highlight the New derived child project that was exported a few steps ago. Click the Import button and upload your NEW child project that contains the diff customizations. When prompted to ‘Overwrite’ the derived child project, click yes.
- Now publish your new child project and being testing 


## Prerequisites
> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Configuration considerations
## Additional Notes
