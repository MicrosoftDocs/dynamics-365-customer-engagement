---
title: "Upload and use images and files in online content (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to upload, tag, and find images and other files for use in emails and marketing pages in Dynamics 365 Marketing."
ms.date: 01/20/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Upload and use images and files in online content

Files are an important part of most marketing-page and marketing-email designs. The files you use must be available publicly on the internet so your emails and pages can access and display them. Though you could host your files anywhere, one convenient place to keep them is in the Dynamics 365 Marketing library, which stores the files, hosts them publicly, and provides a file browser that helps you find and place them while working in Dynamics 365 Marketing.

> [!NOTE]
> The following formats are supported:
>
> BMP, CSS, CSV, DOC, DOCX, GIF, HTM, HTML, JPEG, ODP, ODS, ODT, PDF, PNG, PPT, PPTX, RTF, TAR, TGZ, TXT, XLS, XLSX, XML, ZIP
>
> You will see an error message if you attempt to upload a file of an unsupported type.
>
> The maximum file size for uploaded images is 5 MB. The maximum file size for uploaded files other than images is 32 MB.

> [!TIP]
> Files will be stored in the user's Microsoft Dataverse storage and will count against their file storage capacity. For more information on Dataverse storage capacity, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).

## Upload files to Dynamics 365

Whenever you add an image element to a marketing page or email or link to a file to be downloaded, you can choose to add a file that already exists in your Dynamics 365 Marketing library or upload a new one. After you've uploaded a file in this way, the file will also be available for use in other designs.

![Upload a picture dialog.](media/upload-picture.png "Upload a picture by dragging it to the upload dialog box")

You can also add files for later use. You might do this to establish a collection of files that your marketers can use as needed. Go to **Marketing** > **Marketing content** > **Library** to see a list view of all files available to your organization, and then select **New** to upload a new file. You can also find and edit existing files here.

Note that you can apply keywords each time you upload a file. Keywords can make it much easier for other users to find and identify files in the future, so we recommend that you use them.

## Establish keywords

Keywords make it easier to find your images later when you want to use them in content. Each time you upload a new image, you're offered a chance to apply a keyword to it. You can also add or remove keywords from existing images by going to **Marketing** > **Marketing content** > **Library**.

To help keep your keywords under control, Dynamics 365 Marketing requires you to establish a list of specific keywords that users can apply to their files. Users must therefore select keywords from a list rather than enter free text. This helps prevent users from applying competing ontologies and also helps prevent typos.

To view and edit the keywords available to your organization, go to **Marketing** > **Marketing content** > **Keywords**. All existing keywords are listed here. Select any listed keyword to edit it, or select **New** to create a new one. You can also delete keywords here.

Be careful when editing or deleting keywords. If you edit an existing keyword, all existing files that use it will instead show the new value from now on. If you delete a keyword, it's removed from all files that use it.

## Use images in your content

To add an image to a marketing page or email, start by dragging an image element onto your design, which positions a placeholder. Then select the element with the placeholder image and open the **Properties** tab, where you can define the source, alt text, and link for the image. Select the browse button ![Browse for picture button.](media/browse-button.png "Browse for picture button") for **Source** to open an image browser where you can find any image already uploaded to Dynamics 365 Marketing.

![The picture library.](media/select-picture.png "Select a picture from the library")

To find an image more quickly, try using the **Filter Keyword** drop-down list to show only images that include the keyword you selected.

If the image you need isn't there, select **Upload a Picture** to add a new one. We recommend that you apply one or more keywords when uploading the image to make it easier for you and others to find later.

### See also

[Manage images](manage-images.md)  
[Link to documents stored in the asset library](real-time-marketing-email.md#link-to-documents-and-videos-stored-in-the-asset-library)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
