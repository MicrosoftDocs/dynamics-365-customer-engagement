---
title: "Publish request schema | MicrosoftDocs"
description: "The following is the schema definition for the PublishXmlRequest message."
ms.custom: 
ms.date: 12/22/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 53eeb95f-ed92-4a4b-9198-fbec3c855ee6
caps.latest.revision: 15
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Publish request schema

The following is the schema definition for the <xref:Microsoft.Crm.Sdk.Messages.PublishXmlRequest> message. For more information, see [Publish Customizations](publish-customizations.md). [!INCLUDE[schema_download](../../includes/schema-download.md)].  
  
## Schema  
  
```xml  
<?xml version="1.0" encoding="utf-8"?>  
<xs:schema attributeFormDefault="unqualified"  
           elementFormDefault="qualified"  
           xmlns:xs="https://www.w3.org/2001/XMLSchema">  
 <xs:element name="importexportxml">  
  <xs:complexType>  
   <xs:sequence>  
    <xs:element name="entities"  
                minOccurs="0">  
     <xs:complexType>  
      <xs:sequence minOccurs="0"  
                   maxOccurs="unbounded">  
       <!-- Name of the entity to publish-->  
       <xs:element maxOccurs="unbounded"  
                   name="entity"  
                   type="xs:string" />  
      </xs:sequence>  
     </xs:complexType>  
    </xs:element>  
    <xs:element name="ribbons"  
                minOccurs="0">  
     <xs:complexType>  
      <xs:sequence minOccurs="0"  
                   maxOccurs="unbounded">  
       <!-- Application ribbon. : This value is not used. We publish the application ribbon if there is at least one <ribbon> node present -->  
       <xs:element maxOccurs="unbounded"  
                   name="ribbon"  
                   type="xs:string" />  
      </xs:sequence>  
     </xs:complexType>  
    </xs:element>  
    <xs:element name="dashboards"  
                minOccurs="0">  
     <xs:complexType>  
      <xs:sequence minOccurs="0"  
                   maxOccurs="unbounded">  
       <!-- Guid of the systemform to publish-->  
       <xs:element maxOccurs="unbounded"  
                   name="dashboard"  
                   type="xs:string" />  
      </xs:sequence>  
     </xs:complexType>  
    </xs:element>  
    <xs:element name="optionsets"  
                minOccurs="0">  
     <xs:complexType>  
      <xs:sequence minOccurs="0"  
                   maxOccurs="unbounded">  
       <!-- Name of the optionset to publish-->  
       <xs:element maxOccurs="unbounded"  
                   name="optionset"  
                   type="xs:string" />  
      </xs:sequence>  
     </xs:complexType>  
    </xs:element>  
    <xs:element name="sitemaps"  
                minOccurs="0">  
     <xs:complexType>  
      <xs:sequence minOccurs="0"  
                   maxOccurs="unbounded">  
       <!-- Guid of the sitemap to publish : This value is not used. We publish the sitemap if there is at least one <sitemap> node present-->  
       <xs:element maxOccurs="unbounded"  
                   name="sitemap"  
                   type="xs:string" />  
      </xs:sequence>  
     </xs:complexType>  
    </xs:element>  
    <xs:element name="webresources"  
                minOccurs="0">  
     <xs:complexType>  
      <xs:sequence minOccurs="0"  
                   maxOccurs="unbounded">  
       <!-- Guid of the web resource to publish -->  
       <xs:element maxOccurs="unbounded"  
                   name="webresource"  
                   type="xs:string" />  
      </xs:sequence>  
     </xs:complexType>  
    </xs:element>  
   </xs:sequence>  
  </xs:complexType>  
 </xs:element>  
</xs:schema>  
  
```  
  
### See also  
 <xref:Microsoft.Crm.Sdk.Messages.PublishXmlRequest>   
 [Publish Customizations](publish-customizations.md)   
 [Schemas Used in Microsoft Dynamics 365 Customer Engagement](../schemas-used-dynamics-365.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]