---
title: "SLA table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the SLA table/entity with Microsoft Dynamics 365."
ms.date: 08.01.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# SLA table/entity reference

Contains information about the tracked service-level KPIs for cases that belong to different customers.

> [!NOTE]
> The Microsoft Dynamics 365 SLA table extends the [Microsoft Dataverse SLA table](/power-apps/developer/data-platform/reference/entities/sla).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

Changes from [ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sla#BKMK_ObjectTypeCode)

#### ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|3|**Opportunity**|
|4|**Lead**|
|16|**AccountLeads**|
|17|**ContactInvoices**|
|18|**ContactQuotes**|
|19|**ContactOrders**|
|20|**Service Contract Contact**|
|21|**ProductSalesLiterature**|
|22|**ContactLeads**|
|24|**LeadCompetitors**|
|25|**OpportunityCompetitors**|
|26|**CompetitorSalesLiterature**|
|27|**LeadProduct**|
|32|**Sales Process Instance**|
|112|**Case**|
|113|**Child Incident Count**|
|123|**Competitor**|
|952|**Phone To Case Process**|
|953|**Opportunity Sales Process**|
|954|**Lead To Opportunity Sales Process**|
|1004|**Competitor Address**|
|1006|**Competitor Product**|
|1010|**Contract**|
|1011|**Contract Line**|
|1013|**Discount**|
|1017|**Lead Address**|
|1022|**Price List**|
|1024|**Product**|
|1025|**Product Association**|
|1026|**Price List Item**|
|1028|**Product Relationship**|
|1038|**Sales Literature**|
|1048|**Property**|
|1049|**Property Option Set Item**|
|1055|**Unit**|
|1056|**Unit Group**|
|1070|**Sales Attachment**|
|1080|**Discount List**|
|1083|**Opportunity Product**|
|1084|**Quote**|
|1085|**Quote Product**|
|1088|**Order**|
|1089|**Order Product**|
|1090|**Invoice**|
|1091|**Invoice Product**|
|1141|**Characteristic**|
|1142|**Rating Value**|
|1144|**Rating Model**|
|1145|**Bookable Resource Booking**|
|1146|**Bookable Resource Booking Header**|
|1147|**Bookable Resource Category**|
|1148|**Bookable Resource Characteristic**|
|1149|**Bookable Resource Category Assn**|
|1150|**Bookable Resource**|
|1151|**Bookable Resource Group**|
|1152|**Booking Status**|
|1235|**Property Association**|
|1333|**Property Instance**|
|2011|**Contract Template**|
|4000|**Facility/Equipment**|
|4001|**Service**|
|4002|**Resource**|
|4005|**Scheduling Group**|
|4006|**Resource Specification**|
|4007|**Resource Group**|
|4009|**Site**|
|4010|**Resource Expansion**|
|4206|**Case Resolution**|
|4208|**Opportunity Close**|
|4209|**Order Close**|
|4211|**Quote Close**|
|4214|**Service Activity**|
|4215|**Commitment**|
|4300|**Marketing List**|
|4301|**Marketing List Member**|
|4400|**Campaign**|
|4401|**Campaign Response**|
|4402|**Campaign Activity**|
|4403|**Campaign Item**|
|4404|**Campaign Activity Item**|
|4405|**Bulk Operation Log**|
|4406|**Quick Campaign**|
|4421|**Bookable Resource Booking to Exchange Id Mapping**|
|4503|**Opportunity Relationship**|
|4545|**Entitlement Template Product**|
|6363|**Entitlement Product**|
|7272|**Entitlement Contact**|
|9700|**Entitlement**|
|9701|**Entitlement Channel**|
|9702|**Entitlement Template**|
|9703|**Entitlement Template Channel**|
|9704|**Entitlement Entity Allocation Type Mapping**|
|9931|**Incident KnowledgeBaseRecord**|
|9942|**Topic Model Configuration**|
|9943|**Topic Model Execution History**|
|9944|**Topic Model**|
|9946|**Topic History**|
|9948|**Text Analytics Topic**|
|9954|**Knowledge Article Incident**|
|10360|**List Operation**|
|10361|**Marketing Form Display Attributes**|
|10362|**Database Version**|
|10363|**Upgrade Run**|
|10364|**Upgrade Step**|
|10365|**Upgrade Version**|
|10366|**Activity monitor**|
|10367|**Originating Queue Mapping**|
|10368|**Unified Routing Setup Tracker**|
|10369|**Available Times**|
|10370|**Available Times Data Source**|
|10371|**resource group data source**|
|10372|**Virtual Resource Group Resource**|
|10373|**Migration tracker**|
|10374|**BgJobLedger**|
|10375|**Intent**|
|10376|**JobsState**|
|10377|**Asset Category Template Association**|
|10378|**Asset Template Association**|
|10379|**Customer Asset**|
|10382|**Customer Asset Attachment**|
|10383|**Customer Asset Category**|
|10384|**Functional Location**|
|10385|**Functional Location Type**|
|10386|**Location Template Association**|
|10387|**Functional Location Type Template Association**|
|10388|**Property Definition**|
|10389|**Property Asset Association**|
|10390|**Property Location Association**|
|10391|**Property Log**|
|10392|**Property Template Association**|
|10393|**Template For Properties**|
|10394|**Warranty**|
|10401|**IoT Alert**|
|10402|**IoT Device**|
|10403|**IoT Device Category**|
|10404|**IoT Device Command**|
|10405|**IoT Device Command Definition**|
|10406|**IoT Device Data History**|
|10407|**IoT Device Property**|
|10408|**IoT Device Registration History**|
|10409|**IoT Device Visualization Configuration**|
|10410|**IoT Field Mapping**|
|10411|**IoT Property Definition**|
|10412|**IoT Provider**|
|10413|**IoT Provider Instance**|
|10414|**IoT Settings**|
|10417|**IoT Alert to Case Process**|
|10419|**Playbook Callable Context**|
|10420|**Playbook activity**|
|10421|**Playbook activity attribute**|
|10422|**[DEPRECATED] Playbook category**|
|10423|**Playbook**|
|10424|**[DEPRECATED] Playbook template**|
|10426|**admin_settings_entity**|
|10427|**Collab Space Team Association**|
|10428|**CRM Connection**|
|10429|**Tagged Record**|
|10430|**Copilot for Sales customer list**|
|10431|**msdyn_vivaentitysetting**|
|10432|**msdyn_vivaorgextensioncred**|
|10433|**msdyn_vivaorgsetting**|
|10434|**msdyn_vivausersetting**|
|10435|**Sales Copilot Insight**|
|10436|**Org level settings for Sales Copilot apps**|
|10437|**Sales Copilot User Setting**|
|10438|**App profile**|
|10439|**Application Extension**|
|10440|**Application Tab Template**|
|10441|**App profile role mapping**|
|10442|**Notification Field**|
|10443|**Notification Template**|
|10444|**Session Template**|
|10445|**Template Parameter**|
|10451|**Channel Integration Framework v1.0 Provider**|
|10452|**Notification Field (Deprecated)**|
|10453|**Notification Template (Deprecated)**|
|10454|**App Parameter Definition (Deprecated)**|
|10455|**Session Templates (Deprecated)**|
|10456|**Application Tab Template (Deprecated)**|
|10457|**Parameter (Deprecated)**|
|10458|**Template Tag (Deprecated)**|
|10459|**Application Type (Deprecated)**|
|10468|**Channel Integration Framework v2.0 Provider**|
|10470|**Conversation Data (Deprecated)**|
|10471|**KPI Event Data**|
|10472|**KPI Event Definition**|
|10473|**Session Data (Deprecated)**|
|10474|**Session Participant Data (Deprecated)**|
|10475|**Channel Definition**|
|10476|**Channel Definition Consent**|
|10477|**Channel Definition Locale**|
|10478|**Channel Instance**|
|10479|**Channel Instance Account**|
|10480|**Channel Message Attachment**|
|10481|**Channel Message Context Part**|
|10482|**Channel Message Part**|
|10483|**Consuming Application**|
|10484|**msdyn_DefExtendedChannelInstance**|
|10485|**msdyn_DefExtendedChannelInstanceAccount**|
|10486|**Productivity pane configuration**|
|10487|**Pane tab configuration**|
|10488|**Pane tool configuration**|
|10490|**Agent script**|
|10491|**Agent script step**|
|10493|**Action Input Parameter**|
|10494|**Action Output Parameter**|
|10495|**Macro Action Template**|
|10496|**Macro Solution Configuration**|
|10497|**Macro Connector**|
|10498|**Macro Run History**|
|10499|**Parameter definition**|
|10502|**Adaptive Card Configuration**|
|10503|**Smartassist configuration**|
|10505|**Read Tracker**|
|10506|**Read tracking enabled information**|
|10507|**Microsoft Teams Graph resource Entity**|
|10508|**msdyn_msteamssetting**|
|10509|**msdyn_msteamssettingsv2**|
|10510|**Microsoft Teams Collaboration entity**|
|10511|**Teams Dialer Admin settings**|
|10512|**Teams Contact Suggestion by AI**|
|10513|**Contact suggestion rule**|
|10514|**Contact suggestion ruleset**|
|10515|**Microsoft Teams chat association entity**|
|10516|**Microsoft Teams chat suggestion**|
|10517|**Microsoft Orgchart node entity**|
|10518|**Forecast Manual Adjustment History**|
|10519|**Distributed Lock**|
|10520|**Entity Delta Change**|
|10521|**File Upload Status Tracker**|
|10522|**Forecast**|
|10523|**Forecast Configuration**|
|10524|**Forecast definition**|
|10525|**Forecasting Cache**|
|10526|**Forecast Insights**|
|10527|**Forecast**|
|10528|**Forecast Prediction Data**|
|10529|**Forecast Prediction Status**|
|10530|**Forecast recurrence**|
|10531|**Recompute Tracker**|
|10532|**Forecast Recurrence**|
|10533|**ShareAs Configuration**|
|10534|**Customer email communication**|
|10535|**GDPRData**|
|10536|**ODOSFeatureMetadata**|
|10537|**ODOSMetadata**|
|10538|**Recurring Sales Action**|
|10539|**Recurring Sales Action V2**|
|10540|**msdyn_relationshipinsightsunifiedconfig**|
|10541|**siconfig**|
|10542|**SI Key Value Config**|
|10543|**Usage Metric**|
|10544|**Action Card Regarding**|
|10545|**Action Card Role Setting**|
|10546|**EntityRankingRule**|
|10547|**flowcardtype**|
|10548|**salesinsightssettings**|
|10549|**Action Card Usage**|
|10550|**Action Card Usage Aggregation**|
|10551|**Auto Capture Rule**|
|10552|**Auto Capture Settings**|
|10553|**UntrackedAppointment**|
|10554|**Suggested Activity**|
|10555|**Suggested Activity Data Source**|
|10556|**Suggested Contact**|
|10557|**Suggested Contacts Data Source**|
|10558|**Notes analysis Config**|
|10559|**icebreakersconfig**|
|10560|**dealmanageraccess**|
|10561|**Deal manager settings**|
|10562|**Account KPI Item**|
|10563|**Activity Analysis CleanUp State**|
|10564|**Relationship Analytics Config**|
|10565|**Contact KPI Item**|
|10566|**Daily Kpis for account**|
|10567|**Daily kpis for contact**|
|10568|**Daily kpis for lead**|
|10569|**Daily kpis for Opportunity**|
|10570|**Lead KPI Item**|
|10571|**Most Contacted**|
|10572|**Most Contacted By**|
|10573|**Opportunity KPI Item**|
|10574|**Relationship Analytics Metadata**|
|10575|**Similar entities feature importance**|
|10576|**wkwcolleaguesforcompany**|
|10577|**wkwcolleaguesforcontact**|
|10578|**wkwconfig**|
|10579|**Attribute Influence Statistics**|
|10580|**Prediction Computation Operation**|
|10581|**Prediction Model Status**|
|10582|**Prediction Scheduled Operation**|
|10583|**Predictive Model Score**|
|10584|**Predictive Score**|
|10585|**Predictive Scoring Sync Status**|
|10586|**Real Time Scoring**|
|10587|**Real Time Scoring Operation**|
|10588|**Submodel Definition**|
|10589|**Time spent in BPF**|
|10590|**Training Result**|
|10591|**OpportunityModelConfig**|
|10592|**LeadModelConfig**|
|10593|**ModelPreviewStatus**|
|10594|**Profile Album**|
|10595|**Post Configuration**|
|10596|**Post Rule Configuration**|
|10597|**Wall View**|
|10598|**Filter**|
|10599|**Customer Voice alert**|
|10600|**Customer Voice alert rule**|
|10601|**Customer Voice survey email template**|
|10602|**Customer Voice file response**|
|10603|**Customer Voice localized survey email template**|
|10604|**Customer Voice project**|
|10605|**Customer Voice survey question**|
|10606|**Customer Voice survey question response**|
|10607|**Customer Voice satisfaction metric**|
|10608|**Customer Voice survey**|
|10609|**Customer Voice survey invite**|
|10610|**Customer Voice survey reminder**|
|10611|**Customer Voice survey response**|
|10612|**Customer Voice unsubscribed recipient**|
|10613|**Customer Service Key Value Configuration**|
|10614|**AddToCalendar style**|
|10615|**basestyle**|
|10616|**Button style**|
|10617|**Code style**|
|10618|**Column style**|
|10619|**Content Block**|
|10620|**Divider style**|
|10621|**General styles**|
|10622|**imagestyle**|
|10623|**Layout Style**|
|10624|**QR code style**|
|10625|**Text style**|
|10626|**Video style**|
|10627|**App state**|
|10628|**CSAdminConfig**|
|10629|**Custom API Ruleset Configuration**|
|10630|**Decision contract**|
|10631|**Decision rule set**|
|10632|**Rulesetentitymapping**|
|10633|**Routing diagnostic item**|
|10634|**Routing diagnostic**|
|10635|**Inbox card configuration**|
|10636|**Inbox Configuration**|
|10637|**Inbox Entity Configuration**|
|10638|**App Profile Copilot Configuration**|
|10639|**Swarm**|
|10640|**Swarm participant**|
|10641|**Swarm participant rule**|
|10642|**Swarm role**|
|10643|**Swarm skill**|
|10644|**Swarm template**|
|10645|**Autonomous case creation and enrichment rules**|
|10646|**Entity Attachment**|
|10647|**Survey setting**|
|10648|**Master Entity Routing Configuration**|
|10649|**Routing Rule Set Setting**|
|10650|**Assignment Configuration**|
|10651|**Assignment Configuration Step**|
|10652|**Capacity Profile**|
|10653|**Overflow Action Config**|
|10654|**Preferred Agent**|
|10655|**Preferred Agent Customer Identity**|
|10656|**Preferred Agent Routed Entity**|
|10657|**Routing configuration**|
|10658|**Routing configuration step**|
|10659|**Bot Channel Registration**|
|10660|**Channel Configuration**|
|10661|**Channel State Configuration**|
|10662|**Provisioning State**|
|10663|**AdminAppState**|
|10664|**Agent Status history**|
|10665|**Power BI Configuration**|
|10666|**Authentication Settings**|
|10667|**Auth Settings Entry**|
|10668|**Quick reply**|
|10669|**Entity Routing Context**|
|10670|**Channel Capability**|
|10671|**Conversation Action**|
|10672|**Conversation Action Locale**|
|10673|**Conversation Message Block**|
|10674|**DeletedConversation**|
|10675|**Deprecated Workstream Entity Configuration**|
|10676|**Entity**|
|10677|**Ongoing conversation (Deprecated)**|
|10678|**Live work item event**|
|10679|**Work Stream**|
|10680|**Masking Rule**|
|10681|**Auto block rule**|
|10682|**Bot Channel Registration Secret**|
|10683|**Omnichannel channel api conversation privilege**|
|10684|**Omnichannel channel api message privilege**|
|10685|**Channel api method mapping**|
|10686|**External context**|
|10687|**Flagged spam**|
|10688|**Language**|
|10689|**Conversation**|
|10692|**Context item value**|
|10693|**Live Work Item Participant (Deprecated)**|
|10694|**Conversation Sentiment**|
|10695|**Context variable**|
|10696|**Localization**|
|10697|**OC Payment Profile**|
|10698|**Recording**|
|10699|**Omnichannel Request**|
|10700|**Rich message**|
|10701|**Rich message map**|
|10702|**Rule Item**|
|10703|**Sentiment daily topic**|
|10704|**Sentiment daily topic keyword**|
|10705|**Sentiment daily topic trending**|
|10706|**Session**|
|10707|**Session Participant Event**|
|10708|**Session Sentiment**|
|10709|**Message**|
|10710|**Tag**|
|10711|**Geo Location Provider**|
|10712|**Omnichannel Configuration**|
|10713|**Omnichannel Personalization**|
|10714|**Omnichannel Queue (Deprecated)**|
|10715|**Omnichannel Sync Config**|
|10716|**Operating Hour**|
|10717|**Personal quick reply**|
|10718|**Personal sound setting**|
|10719|**Persona Security Role Mapping**|
|10720|**Presence**|
|10721|**Provider**|
|10722|**RoutingRequest**|
|10723|**Search Configuration**|
|10724|**Sentiment analysis**|
|10725|**Session event**|
|10726|**Session participant**|
|10727|**Audio File**|
|10728|**Sound notification setting**|
|10729|**Transcript**|
|10730|**UR notification template**|
|10731|**UR Notification Template Mapping**|
|10732|**User settings**|
|10733|**Self service**|
|10740|**Agent capacity update history**|
|10741|**Bookable Resource Capacity Profile**|
|10742|**Work stream capacity profile**|
|10743|**Conversation Capacity profile**|
|10744|**Agent Capacity Profile Unit**|
|10745|**Agent Channel State**|
|10746|**Agent Status**|
|10747|**Conversation Characteristic**|
|10748|**Session Characteristic**|
|10749|**Skill Attachment Rule**|
|10750|**Attach Skill**|
|10751|**Model training details**|
|10752|**Training data import configuration**|
|10753|**Characteristic mapping**|
|10754|**Training record**|
|10755|**Skill finder model**|
|10756|**Effort estimate**|
|10757|**Effort estimation model**|
|10758|**Effort model training details**|
|10759|**ConversationInsight**|
|10760|**Active ICD Extension**|
|10761|**Entity-Workstream Map**|
|10762|**ICD Extension**|
|10763|**Lock Status**|
|10764|**Omnichannel agent assignment custom api privilege**|
|10765|**Conversation Action Item**|
|10766|**Conversation Aggregated Insights**|
|10767|**Comment**|
|10768|**Conversation Participant Insights**|
|10769|**Conversation Participant Sentiment**|
|10770|**Conversation Question**|
|10771|**Conversation Segment Sentiment**|
|10772|**Conversation Sentiment**|
|10773|**Conversation Signal**|
|10774|**Conversation Subject**|
|10775|**Conversation Summary Suggestion**|
|10776|**Conversation System Tag**|
|10777|**Conversation Tag**|
|10778|**Recording**|
|10779|**SCI Conversation**|
|10780|**Custom Email Highlight**|
|10781|**Custom Highlight**|
|10782|**Custom Publisher**|
|10783|**EnvironmentSettings**|
|10784|**UserSettings**|
|10785|**CatalogEventStatusConfiguration**|
|10786|**Configuration**|
|10787|**Trigger**|
|10788|**Triggers To Sdk Message Processing Steps**|
|10789|**EventParameterMetadata**|
|10790|**TrackingContext**|
|10791|**Marketing feature configuration**|
|10792|**msdynmkt_experimentv2**|
|10793|**ACS channel instance**|
|10794|**ACS channel instance account**|
|10795|**Infobip channel instance**|
|10796|**Infobip channel instance account**|
|10797|**Link mobility channel instance**|
|10798|**Link mobility channel instance account**|
|10799|**MockSmsProvider channel instance**|
|10800|**MockSmsProvider channel instance account**|
|10801|**TeleSign channel instance**|
|10802|**TeleSign channel instance account**|
|10803|**Twilio channel instance**|
|10804|**Twilio channel instance account**|
|10805|**Vibes channel instance**|
|10806|**Vibes channel instance account**|
|10807|**Predefined Placeholder**|
|10808|**Metadata Entity Relationship**|
|10809|**Metadata Item**|
|10810|**Metadata Store State**|
|10811|**DigitalSellingActiveTask**|
|10812|**DigitalSellingCompletedTask**|
|10813|**Sales Tag**|
|10814|**Sequence**|
|10815|**Sequence Stat**|
|10816|**Sequence Target**|
|10817|**Sequence Target Step**|
|10818|**Sequence Template**|
|10820|**sabackupdiagnostic**|
|10821|**SABatchRunInstance**|
|10822|**salesroutingdiagnostic**|
|10823|**SARunInstance**|
|10824|**Segment**|
|10825|**segmentsetting**|
|10826|**Segment property**|
|10827|**SegmentsUtil**|
|10828|**Assignment Rule**|
|10829|**Seller attribute**|
|10830|**Seller attribute value**|
|10831|**Assignment Map**|
|10832|**Sales Assignment Setting**|
|10833|**Sales routing run**|
|10835|**Extended User Setting**|
|10836|**Sales acceleration insights**|
|10837|**Sales Acceleration settings**|
|10838|**Insight**|
|10839|**Work List Suggestion**|
|10840|**Work list suggestion source**|
|10841|**Work List View Configuration**|
|10842|**Work Queue Record**|
|10843|**Work Queue Record State**|
|10844|**Work list user setting**|
|10845|**WQDataSource**|
|10846|**Suggestion Assignment Rule**|
|10847|**Suggestion Principal Object Access**|
|10848|**Suggestion Seller Priority**|
|10849|**Data Hygiene Setting Info**|
|10850|**Duplicate Detection Plugin Run**|
|10851|**Duplicate Lead Mapping**|
|10852|**Lead Hygiene Setting**|
|10853|**Linked Entity Attribute Validity**|
|10854|**Sales provisioning request**|
|10855|**SalesOmnichannel Message**|
|10856|**Text message template**|
|10857|**Data Analytics Admin Settings (Deprecated)**|
|10858|**Data Analytics Report**|
|10859|**Insights**|
|10860|**Sales acceleration reports**|
|10862|**Bot Session**|
|10863|**Agent Copilot Setting**|
|10864|**Copilot Summarization Setting**|
|10865|**Case Enrichment**|
|10866|**Case Suggestion**|
|10867|**Case Suggestion Request Payload**|
|10868|**Case Suggestions Data Souce**|
|10869|**Agent Preference For Copilot**|
|10870|**Copilot Interaction**|
|10871|**Copilot Interaction Data**|
|10872|**Copilot Transcript**|
|10873|**Copilot Transcript Data**|
|10874|**KB Enrichment**|
|10875|**Knowledge Article Suggestion**|
|10876|**Knowledge Article Suggestion Data Source**|
|10877|**Service Copilot Plugin**|
|10878|**Service Copilot Plugin Role**|
|10879|**Suggestion Interaction**|
|10880|**Suggestion request payload**|
|10881|**Suggestions Model Summary**|
|10882|**Suggestions Setting**|
|10883|**Data Analytics User Customized Report**|
|10884|**Data Analytics Dataset**|
|10885|**Data Analytics Workspace**|
|10886|**Report Bookmark**|
|10887|**Agent Resource Forecasting**|
|10888|**[Deprecated] Dynamics Customer Service Analytics**|
|10889|**Case Topic**|
|10890|**Case Topic Setting**|
|10891|**Case Topic Summary**|
|10892|**Case topic Incident mapping**|
|10893|**Customer Service historical analytics**|
|10894|**Forecast**|
|10895|**Knowledge analytics**|
|10896|**Forecast Summary and Setting**|
|10897|**Keywords Description Suggestion Setting**|
|10898|**Conversation Summary Interaction**|
|10899|**Conversation Summary Setting**|
|10900|**Conversation Topic**|
|10901|**Conversation Topic Setting**|
|10902|**Conversation Topic Summary**|
|10903|**Conversation topic Conversation mapping**|
|10904|**Omnichannel historical analytics**|
|10905|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|10906|**Omnichannel Realtime analytics**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [bulkoperation_sla_slaid](#BKMK_bulkoperation_sla_slaid)
- [bulkoperation_sla_slainvokedid](#BKMK_bulkoperation_sla_slainvokedid)
- [campaignactivity_sla_slaid](#BKMK_campaignactivity_sla_slaid)
- [campaignactivity_sla_slainvokedid](#BKMK_campaignactivity_sla_slainvokedid)
- [campaignresponse_sla_slaid](#BKMK_campaignresponse_sla_slaid)
- [campaignresponse_sla_slainvokedid](#BKMK_campaignresponse_sla_slainvokedid)
- [incidentresolution_sla_slaid](#BKMK_incidentresolution_sla_slaid)
- [incidentresolution_sla_slainvokedid](#BKMK_incidentresolution_sla_slainvokedid)
- [manualsla_cases](#BKMK_manualsla_cases)
- [manualsla_invoice](#BKMK_manualsla_invoice)
- [manualsla_lead](#BKMK_manualsla_lead)
- [manualsla_opportunity](#BKMK_manualsla_opportunity)
- [manualsla_quote](#BKMK_manualsla_quote)
- [manualsla_salesorder](#BKMK_manualsla_salesorder)
- [manualsla_serviceappointment](#BKMK_manualsla_serviceappointment)
- [msdyn_copilottranscript_sla_slaid](#BKMK_msdyn_copilottranscript_sla_slaid)
- [msdyn_copilottranscript_sla_slainvokedid](#BKMK_msdyn_copilottranscript_sla_slainvokedid)
- [msdyn_migrationtracker_LegacySLA_sla](#BKMK_msdyn_migrationtracker_LegacySLA_sla)
- [msdyn_migrationtracker_ModernSLA_sla](#BKMK_msdyn_migrationtracker_ModernSLA_sla)
- [msdyn_ocliveworkitem_sla_slaid](#BKMK_msdyn_ocliveworkitem_sla_slaid)
- [msdyn_ocliveworkitem_sla_slainvokedid](#BKMK_msdyn_ocliveworkitem_sla_slainvokedid)
- [msdyn_ocsession_sla_slaid](#BKMK_msdyn_ocsession_sla_slaid)
- [msdyn_ocsession_sla_slainvokedid](#BKMK_msdyn_ocsession_sla_slainvokedid)
- [msfp_alert_sla_slaid](#BKMK_msfp_alert_sla_slaid)
- [msfp_alert_sla_slainvokedid](#BKMK_msfp_alert_sla_slainvokedid)
- [msfp_surveyinvite_sla_slaid](#BKMK_msfp_surveyinvite_sla_slaid)
- [msfp_surveyinvite_sla_slainvokedid](#BKMK_msfp_surveyinvite_sla_slainvokedid)
- [msfp_surveyresponse_sla_slaid](#BKMK_msfp_surveyresponse_sla_slaid)
- [msfp_surveyresponse_sla_slainvokedid](#BKMK_msfp_surveyresponse_sla_slainvokedid)
- [opportunityclose_sla_slaid](#BKMK_opportunityclose_sla_slaid)
- [opportunityclose_sla_slainvokedid](#BKMK_opportunityclose_sla_slainvokedid)
- [orderclose_sla_slaid](#BKMK_orderclose_sla_slaid)
- [orderclose_sla_slainvokedid](#BKMK_orderclose_sla_slainvokedid)
- [quoteclose_sla_slaid](#BKMK_quoteclose_sla_slaid)
- [quoteclose_sla_slainvokedid](#BKMK_quoteclose_sla_slainvokedid)
- [sla_cases](#BKMK_sla_cases)
- [sla_entitlement](#BKMK_sla_entitlement)
- [sla_entitlementtemplate](#BKMK_sla_entitlementtemplate)
- [sla_invoice](#BKMK_sla_invoice)
- [sla_lead](#BKMK_sla_lead)
- [sla_opportunity](#BKMK_sla_opportunity)
- [sla_quote](#BKMK_sla_quote)
- [sla_salesorder](#BKMK_sla_salesorder)
- [sla_serviceappointment](#BKMK_sla_serviceappointment)

### <a name="BKMK_bulkoperation_sla_slaid"></a> bulkoperation_sla_slaid

Many-To-One Relationship: [bulkoperation bulkoperation_sla_slaid](bulkoperation.md#BKMK_bulkoperation_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`bulkoperation_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_bulkoperation_sla_slainvokedid"></a> bulkoperation_sla_slainvokedid

Many-To-One Relationship: [bulkoperation bulkoperation_sla_slainvokedid](bulkoperation.md#BKMK_bulkoperation_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`bulkoperation_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_sla_slaid"></a> campaignactivity_sla_slaid

Many-To-One Relationship: [campaignactivity campaignactivity_sla_slaid](campaignactivity.md#BKMK_campaignactivity_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignactivity_sla_slainvokedid"></a> campaignactivity_sla_slainvokedid

Many-To-One Relationship: [campaignactivity campaignactivity_sla_slainvokedid](campaignactivity.md#BKMK_campaignactivity_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignresponse_sla_slaid"></a> campaignresponse_sla_slaid

Many-To-One Relationship: [campaignresponse campaignresponse_sla_slaid](campaignresponse.md#BKMK_campaignresponse_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`campaignresponse_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_campaignresponse_sla_slainvokedid"></a> campaignresponse_sla_slainvokedid

Many-To-One Relationship: [campaignresponse campaignresponse_sla_slainvokedid](campaignresponse.md#BKMK_campaignresponse_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`campaignresponse_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incidentresolution_sla_slaid"></a> incidentresolution_sla_slaid

Many-To-One Relationship: [incidentresolution incidentresolution_sla_slaid](incidentresolution.md#BKMK_incidentresolution_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`incidentresolution_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_incidentresolution_sla_slainvokedid"></a> incidentresolution_sla_slainvokedid

Many-To-One Relationship: [incidentresolution incidentresolution_sla_slainvokedid](incidentresolution.md#BKMK_incidentresolution_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`incidentresolution_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_manualsla_cases"></a> manualsla_cases

Many-To-One Relationship: [incident manualsla_cases](incident.md#BKMK_manualsla_cases)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_cases`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `72210bbb-d9d5-42df-8efd-39395a3cd7a7`|

### <a name="BKMK_manualsla_invoice"></a> manualsla_invoice

Many-To-One Relationship: [invoice manualsla_invoice](invoice.md#BKMK_manualsla_invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_invoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `a84eb3ff-6dc5-4f57-bbf0-7b664c11fb62`|

### <a name="BKMK_manualsla_lead"></a> manualsla_lead

Many-To-One Relationship: [lead manualsla_lead](lead.md#BKMK_manualsla_lead)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_lead`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `f7ba26ee-3f8e-4cf2-8e02-0b4bbcd16da8`|

### <a name="BKMK_manualsla_opportunity"></a> manualsla_opportunity

Many-To-One Relationship: [opportunity manualsla_opportunity](opportunity.md#BKMK_manualsla_opportunity)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_opportunity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-00aa-000010001203`|

### <a name="BKMK_manualsla_quote"></a> manualsla_quote

Many-To-One Relationship: [quote manualsla_quote](quote.md#BKMK_manualsla_quote)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_quote`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `642095db-91dd-4813-bb31-665a3a2bae61`|

### <a name="BKMK_manualsla_salesorder"></a> manualsla_salesorder

Many-To-One Relationship: [salesorder manualsla_salesorder](salesorder.md#BKMK_manualsla_salesorder)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_salesorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `71f7da6e-2772-4097-89d1-3670ff8348bb`|

### <a name="BKMK_manualsla_serviceappointment"></a> manualsla_serviceappointment

Many-To-One Relationship: [serviceappointment manualsla_serviceappointment](serviceappointment.md#BKMK_manualsla_serviceappointment)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`manualsla_serviceappointment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `70540b32-fc70-426e-a4b3-a92056ce4717`|

### <a name="BKMK_msdyn_copilottranscript_sla_slaid"></a> msdyn_copilottranscript_sla_slaid

Many-To-One Relationship: [msdyn_copilottranscript msdyn_copilottranscript_sla_slaid](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilottranscript_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_copilottranscript_sla_slainvokedid"></a> msdyn_copilottranscript_sla_slainvokedid

Many-To-One Relationship: [msdyn_copilottranscript msdyn_copilottranscript_sla_slainvokedid](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilottranscript_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_LegacySLA_sla"></a> msdyn_migrationtracker_LegacySLA_sla

Many-To-One Relationship: [msdyn_migrationtracker msdyn_migrationtracker_LegacySLA_sla](msdyn_migrationtracker.md#BKMK_msdyn_migrationtracker_LegacySLA_sla)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_migrationtracker`|
|ReferencingAttribute|`msdyn_legacyslaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_LegacySLA_sla`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_migrationtracker_ModernSLA_sla"></a> msdyn_migrationtracker_ModernSLA_sla

Many-To-One Relationship: [msdyn_migrationtracker msdyn_migrationtracker_ModernSLA_sla](msdyn_migrationtracker.md#BKMK_msdyn_migrationtracker_ModernSLA_sla)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_migrationtracker`|
|ReferencingAttribute|`msdyn_modernslaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_migrationtracker_ModernSLA_sla`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_sla_slaid"></a> msdyn_ocliveworkitem_sla_slaid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_sla_slaid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_ocliveworkitem_sla_slainvokedid"></a> msdyn_ocliveworkitem_sla_slainvokedid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_sla_slainvokedid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_sla_slaid"></a> msdyn_ocsession_sla_slaid

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_sla_slaid](msdyn_ocsession.md#BKMK_msdyn_ocsession_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_ocsession_sla_slainvokedid"></a> msdyn_ocsession_sla_slainvokedid

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_sla_slainvokedid](msdyn_ocsession.md#BKMK_msdyn_ocsession_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_alert_sla_slaid"></a> msfp_alert_sla_slaid

Many-To-One Relationship: [msfp_alert msfp_alert_sla_slaid](msfp_alert.md#BKMK_msfp_alert_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msfp_alert_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msfp_alert_sla_slainvokedid"></a> msfp_alert_sla_slainvokedid

Many-To-One Relationship: [msfp_alert msfp_alert_sla_slainvokedid](msfp_alert.md#BKMK_msfp_alert_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msfp_alert_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyinvite_sla_slaid"></a> msfp_surveyinvite_sla_slaid

Many-To-One Relationship: [msfp_surveyinvite msfp_surveyinvite_sla_slaid](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyinvite_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msfp_surveyinvite_sla_slainvokedid"></a> msfp_surveyinvite_sla_slainvokedid

Many-To-One Relationship: [msfp_surveyinvite msfp_surveyinvite_sla_slainvokedid](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyinvite_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyresponse_sla_slaid"></a> msfp_surveyresponse_sla_slaid

Many-To-One Relationship: [msfp_surveyresponse msfp_surveyresponse_sla_slaid](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyresponse_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msfp_surveyresponse_sla_slainvokedid"></a> msfp_surveyresponse_sla_slainvokedid

Many-To-One Relationship: [msfp_surveyresponse msfp_surveyresponse_sla_slainvokedid](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyresponse_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunityclose_sla_slaid"></a> opportunityclose_sla_slaid

Many-To-One Relationship: [opportunityclose opportunityclose_sla_slaid](opportunityclose.md#BKMK_opportunityclose_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`opportunityclose_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_opportunityclose_sla_slainvokedid"></a> opportunityclose_sla_slainvokedid

Many-To-One Relationship: [opportunityclose opportunityclose_sla_slainvokedid](opportunityclose.md#BKMK_opportunityclose_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`opportunityclose_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_orderclose_sla_slaid"></a> orderclose_sla_slaid

Many-To-One Relationship: [orderclose orderclose_sla_slaid](orderclose.md#BKMK_orderclose_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`orderclose_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_orderclose_sla_slainvokedid"></a> orderclose_sla_slainvokedid

Many-To-One Relationship: [orderclose orderclose_sla_slainvokedid](orderclose.md#BKMK_orderclose_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`orderclose_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quoteclose_sla_slaid"></a> quoteclose_sla_slaid

Many-To-One Relationship: [quoteclose quoteclose_sla_slaid](quoteclose.md#BKMK_quoteclose_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`quoteclose_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_quoteclose_sla_slainvokedid"></a> quoteclose_sla_slainvokedid

Many-To-One Relationship: [quoteclose quoteclose_sla_slainvokedid](quoteclose.md#BKMK_quoteclose_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`quoteclose_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_cases"></a> sla_cases

Many-To-One Relationship: [incident sla_cases](incident.md#BKMK_sla_cases)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_cases`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_entitlement"></a> sla_entitlement

Many-To-One Relationship: [entitlement sla_entitlement](entitlement.md#BKMK_sla_entitlement)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`sla_entitlement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `e800e964-32d6-4024-bcea-2df605b0e762`|

### <a name="BKMK_sla_entitlementtemplate"></a> sla_entitlementtemplate

Many-To-One Relationship: [entitlementtemplate sla_entitlementtemplate](entitlementtemplate.md#BKMK_sla_entitlementtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementtemplate`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`sla_entitlementtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_invoice"></a> sla_invoice

Many-To-One Relationship: [invoice sla_invoice](invoice.md#BKMK_sla_invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_invoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_lead"></a> sla_lead

Many-To-One Relationship: [lead sla_lead](lead.md#BKMK_sla_lead)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_lead`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_opportunity"></a> sla_opportunity

Many-To-One Relationship: [opportunity sla_opportunity](opportunity.md#BKMK_sla_opportunity)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_opportunity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_quote"></a> sla_quote

Many-To-One Relationship: [quote sla_quote](quote.md#BKMK_sla_quote)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_quote`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_salesorder"></a> sla_salesorder

Many-To-One Relationship: [salesorder sla_salesorder](salesorder.md#BKMK_sla_salesorder)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_salesorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_sla_serviceappointment"></a> sla_serviceappointment

Many-To-One Relationship: [serviceappointment sla_serviceappointment](serviceappointment.md#BKMK_sla_serviceappointment)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`sla_serviceappointment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sla?displayProperty=fullName>
