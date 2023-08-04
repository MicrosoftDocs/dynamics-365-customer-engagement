---
title: "Limitations on migrating files between environments (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn about limitations on migrating files between environments and possible workarounds."
ms.date: 09/27/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - developer
---

# Limitations on migrating files between environments

[!INCLUDE[consolidated-sku-rtm-only](../../includes/consolidated-sku-rtm-only.md)]

Out of the box, Dynamics 365 Marketing doesn't provide tools to migrate files between environments. Any such tool would need to be built by a customer or partner and would revolve around calling Microsoft Dataverse APIs.

On a high level, the tool would fetch files from the source environment, download the metadata and content for each file, and then create the file in the target environment. On the source environment, metadata for files are stored in the **msdyncrm_file** entity. The **msdyncrm_blobcdnuri** field contains a URL to the file content.

> [!WARNING]
> The Marketing app doesn't currently support migration between different tenant geographic locations (geo to geo).

## An example flow to clone files (digital assets) in Marketing

> [!IMPORTANT]
> The following steps are a guideline on manually creating a flow to clone files in Dynamics 365 Marketing. Implementation may vary based on the framework and language you are using.

The flow should start with a call to the **msdyncrm_UpsertFile** custom action using the following parameters:
- **InputFile**: String with a serialized JSON object with the following properties:
    - **msdyncrm_name**: Image (file) name
    - **msdyncrm_contenttype**: Content type
    - **msdyncrm_width**: Image width, in pixels
    - **msdyncrm_height**: Image height, in pixels

- **InputKeywords**: String with serialized JSON array with keywords. Each keyword is represented by the following JSON object:
    - **id**: Keyword record identifier (GUID)
    - **entityType**: Always "msdyncrm_keyword"
    - **name**: Value of the keyword

- The call returns properties required for uploading the file content. Of particular note:
    - **msdyncrm_bloburi**: URI to upload the content to
    - **msdyncrm_sastoken**: SAS token used for the upload (can be an empty string)
    - **msdyncrm_fileid**: ID of the newly created msdyncrm_file record

- A PUT call is made to an endpoint provided by **msdyncrm_bloburi** with the file content.

- After the upload is completed, an update to the **msdyncrm_file** record is performed to update **msdyncrm_rethumbnail** property to "true".

> [!NOTE]
> If you copy Marketing emails from one environment to another and have images from the old environment in the emails, the images will be point to old environment CDN. This means that if you decide to uninstall Marketing from the old environment or remove the files, the emails in the new environment will have broken images.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
