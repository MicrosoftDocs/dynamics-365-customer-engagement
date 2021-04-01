---
title: "exportPdf Action | MicrosoftDocs"
description: ""
ms.date: 09/08/2020
ms.service: crm-online
ms.topic: article
author: susikka
ms.author: susikka
manager: shujoshi
---
# exportPdf Action

This action generates a PDF document.

## Parameters

|Name|Type|Required|Description|
|----|----|----|----|
|EntityTypeCode|Integer|Yes|Entity type code.|
|SelectedTemplate|JSON object|Yes|Entity reference of the template to be used.|
|SelectedRecords|GUID|Yes|Unique identifier of the entity record that needs to be converted to PDF.|

## Example

**Request**

```html
POST [Organization URI]/api/data/v9.1/ExportPdfDocument

{
   "EntityTypeCode":1084,
   "SelectedTemplate":{
      "@odata.type":"Microsoft.Dynamics.CRM.documenttemplate",
      "documenttemplateid":"ce712e68-2a7e-4d57-966b-a1d695b9a6dd"
   },
   "SelectedRecords":"[\"{C4E2D03B-3BC5-EA11-A812-000D3A5475F7}\"]"
}
```
> [!NOTE]
> The property `SelectedRecords` in the above request body takes an array. It is not possible to generate PDFs for multiple records in one request. You should pass only one record ID in the `SelectRecords` property. If multiple record IDs are passed to this property, PDF for only one record ID will be generated.

**Response**

This method returns a byte array of contents of the PDF document file which is encoded in Base64 format.

```json
{
        "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.ExportPdfDocumentResponse",
        "PdfFile": "<Byte array of PDF document file contents encoded in Base64 format>"
}
```

## See also

[Developer guide for Dynamics 365 Sales](developer-guide.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
