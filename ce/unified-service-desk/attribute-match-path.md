---
title: "AttributeMatchPath in Unified Service Desk  | MicrosoftDocs"
description: "The topic explains about the <AttributeMatchPath> element that can be utilized by a web control configuration to find the desired control on the currently loaded HTML document using the controls attributes."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# AttributeMatchPath
The `<AttributeMatchPath>` element can be utilized by a web control configuration to find the desired control on the currently loaded `HTML` document using the controls attributes. The "match path" is an ordered list of key/value pairs that is applied by iterating through every element in the `HTML``Document Object Model (DOM)`, matching attributes along the nodes of the match path. Each key represents the name of the attribute to match, and the value is matched with the assigned attribute value in the `HTML` document. After a key/value is matched, the next key/value pair in the sequence is used to compare to each element in the `DOM`. Note that when **keyn+1 = keyn**, matching with the new key/value pair begins with the next element node in the `DOM`, not with the current node.  
  
<a name="syntax"></a>   
## \<AttributeMatchPath> syntax  
 The `<AttributeMatchPath>` element can be targeted at specific frames within an `HTML` application.  
  
```xml  
<AttributeMatchPath [framename=""|framesrc=""] [framematch="n"] [matchtype="equals|startswith|endswith|contains"]>  
  
<attributeName1 [matchtype= "equals|startswith|endswith|contains"]>  
attributeValueToMatch1  
</attributeName1>  
  
<attributeName2 [matchtype= "equals|startswith|endswith|contains"]>  
attributeValueToMatch2  
</attributeName2>  
  
…  
<attributeNamen [matchtype= "equals|startswith|endswith|contains"]>  
attributeValueToMatchn  
</attributeNamen>  
  
</AttributeMatchPath>  
  
```  
  
<a name="elements"></a>   
## \<AttributeMatchPath> elements  
 The following table describes the elements of `<AttributeMatchPath>`  
  
|Element|Description|  
|-------------|-----------------|  
|Framename|Matches the frame name of the IFrame.|  
|Framesrc|Matches the source of the IFrame.|  
|Framematch|Matches the nth one of the specified frame; default is `1`.|  
|Matchtype|Specifies how the caption should be matched. Possible values are `equals`, `startswith`, `endswith`, or `contains`; any other value will throw an exception.|  
  
 For example, if a web application has more than one frame with a given name, you can specify to search for the second or third frame of that name. The `framematch` attribute is not mandatory however is assumed to be 1 unless specified. If `framematch` is specified, `framename` or `framesrc` must be specified; otherwise, a "Frame not found" exception will be thrown.  
  
> [!NOTE]
>  If none of the `AttributeMatchPath` attributes are supplied, the operation will take place in the top-level window as if it were a frame. If both `framename` and `framesrc` are specified, `framesrc` has precedence.  
  
 In the following example, the `matchtype` is used on the `attributeValueToMatch`.  
  
```xml  
<AttributeMatchPath>  
<key1>val1</key1>  
<key2>val2</key2>  
<key3[matchtype="equals|startswith|endswith|contains"]>attributeValueToMatch</key3>  
  .  
<keyn>valn</keyn>  
</AttributeMatchPath>  
  
```  
  
 The following example shows a full attribute match path for a `Test` tag.  
  
```xml  
Page code:    
<Test FirstName='John' LastName='Smith'/>  
  
Match path used in control description:    
<AttributeMatchPath>  
<FirstName>John</FirstName>  
<LastName>Smith</LastName>  
</AttributeMatchPath>  
  
```  
  
> [!NOTE]
>  It is highly recommended that you use only ID and/or name as search attributes. The other attributes will have a negative impact on the performance.  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]