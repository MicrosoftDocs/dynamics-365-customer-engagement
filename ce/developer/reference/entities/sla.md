---
title: "SLA table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the SLA table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# SLA table/entity reference (Microsoft Dynamics 365)

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
|10439|**List Operation**|
|10440|**Marketing Form Display Attributes**|
|10441|**Database Version**|
|10442|**Upgrade Run**|
|10443|**Upgrade Step**|
|10444|**Upgrade Version**|
|10445|**Activity monitor**|
|10446|**Originating Queue Mapping**|
|10448|**Unified Routing Setup Tracker**|
|10449|**Available Times**|
|10450|**Available Times Data Source**|
|10451|**resource group data source**|
|10452|**Virtual Resource Group Resource**|
|10453|**Migration tracker**|
|10454|**Asset Category Template Association**|
|10455|**Asset Template Association**|
|10456|**Customer Asset**|
|10459|**Customer Asset Attachment**|
|10460|**Customer Asset Category**|
|10461|**Functional Location**|
|10462|**Functional Location Type**|
|10463|**Location Template Association**|
|10464|**Functional Location Type Template Association**|
|10465|**Property Definition**|
|10466|**Property Asset Association**|
|10467|**Property Location Association**|
|10468|**Property Log**|
|10469|**Property Template Association**|
|10470|**Template For Properties**|
|10471|**Warranty**|
|10478|**IoT Alert**|
|10479|**IoT Device**|
|10480|**IoT Device Category**|
|10481|**IoT Device Command**|
|10482|**IoT Device Command Definition**|
|10483|**IoT Device Data History**|
|10484|**IoT Device Property**|
|10485|**IoT Device Registration History**|
|10486|**IoT Device Visualization Configuration**|
|10487|**IoT Field Mapping**|
|10488|**IoT Property Definition**|
|10489|**IoT Provider**|
|10490|**IoT Provider Instance**|
|10491|**IoT Settings**|
|10494|**IoT Alert to Case Process**|
|10496|**Playbook Callable Context**|
|10497|**Playbook activity**|
|10498|**Playbook activity attribute**|
|10499|**[DEPRECATED] Playbook category**|
|10500|**Playbook**|
|10501|**[DEPRECATED] Playbook template**|
|10503|**admin_settings_entity**|
|10504|**Collab Space Team Association**|
|10505|**CRM Connection**|
|10506|**Derived insights related entity**|
|10507|**Entity derived insights**|
|10508|**External CRM**|
|10509|**External Record**|
|10510|**Lead Intelligence Insight**|
|10511|**Lead Intelligence Insight Entity Link**|
|10512|**msdyn_rawinsight**|
|10513|**msdyn_rawinsightentitylink**|
|10514|**Tagged Record**|
|10515|**Copilot for Sales customer list**|
|10516|**msdyn_vivaentitysetting**|
|10517|**msdyn_vivaorgextensioncred**|
|10518|**msdyn_vivaorgsetting**|
|10519|**msdyn_vivausersetting**|
|10520|**Activity Mapping**|
|10521|**Sales Copilot Email Insight**|
|10522|**Sales Copilot Insight**|
|10523|**Sales Copilot Insight Card State**|
|10524|**Sales Copilot Job Status**|
|10525|**Sales Copilot Knowledge Base**|
|10526|**Org level settings for Sales Copilot apps**|
|10527|**Sales Copilot User Setting**|
|10528|**App profile**|
|10529|**Application Extension**|
|10530|**Application Tab Template**|
|10531|**App profile role mapping**|
|10532|**Notification Field**|
|10533|**Notification Template**|
|10534|**Session Template**|
|10535|**Template Parameter**|
|10541|**Channel Integration Framework v1.0 Provider**|
|10542|**Notification Field (Deprecated)**|
|10543|**Notification Template (Deprecated)**|
|10544|**App Parameter Definition (Deprecated)**|
|10545|**Session Templates (Deprecated)**|
|10546|**Application Tab Template (Deprecated)**|
|10547|**Parameter (Deprecated)**|
|10548|**Template Tag (Deprecated)**|
|10549|**Application Type (Deprecated)**|
|10558|**Channel Integration Framework v2.0 Provider**|
|10560|**Conversation Data (Deprecated)**|
|10561|**KPI Event Data**|
|10562|**KPI Event Definition**|
|10563|**Session Data (Deprecated)**|
|10564|**Session Participant Data (Deprecated)**|
|10565|**Channel Definition**|
|10566|**Channel Definition Consent**|
|10567|**Channel Definition Locale**|
|10568|**Channel Instance**|
|10569|**Channel Instance Account**|
|10570|**Channel Message Attachment**|
|10571|**Channel Message Context Part**|
|10572|**Channel Message Part**|
|10573|**Consuming Application**|
|10574|**msdyn_DefExtendedChannelInstance**|
|10575|**msdyn_DefExtendedChannelInstanceAccount**|
|10576|**Productivity pane configuration**|
|10577|**Pane tab configuration**|
|10578|**Pane tool configuration**|
|10580|**Script**|
|10581|**Script step**|
|10583|**Action Input Parameter**|
|10584|**Action Output Parameter**|
|10585|**Macro Action Template**|
|10586|**Macro Solution Configuration**|
|10587|**Macro Connector**|
|10588|**Macro Run History**|
|10589|**Parameter definition**|
|10592|**Adaptive Card Configuration**|
|10593|**Smartassist configuration**|
|10595|**Read Tracker**|
|10596|**Read tracking enabled information**|
|10597|**Microsoft Teams Graph resource Entity**|
|10598|**msdyn_msteamssetting**|
|10599|**msdyn_msteamssettingsv2**|
|10600|**Microsoft Teams Collaboration entity**|
|10601|**Teams Dialer Admin settings**|
|10602|**Teams Contact Suggestion by AI**|
|10603|**Contact suggestion rule**|
|10604|**Contact suggestion ruleset**|
|10605|**Microsoft Teams chat association entity**|
|10606|**Microsoft Teams chat suggestion**|
|10607|**Microsoft Orgchart node entity**|
|10608|**Forecast Manual Adjustment History**|
|10609|**Distributed Lock**|
|10610|**Entity Delta Change**|
|10611|**File Upload Status Tracker**|
|10612|**Forecast**|
|10613|**Forecast Configuration**|
|10614|**Forecast definition**|
|10615|**Forecasting Cache**|
|10616|**Forecast Insights**|
|10617|**Forecast**|
|10618|**Forecast Prediction Data**|
|10619|**Forecast Prediction Status**|
|10620|**Forecast recurrence**|
|10621|**Recompute Tracker**|
|10622|**Forecast Recurrence**|
|10623|**ShareAs Configuration**|
|10624|**Customer email communication**|
|10625|**GDPRData**|
|10626|**ODOSFeatureMetadata**|
|10627|**ODOSMetadata**|
|10628|**Recurring Sales Action**|
|10629|**Recurring Sales Action V2**|
|10630|**msdyn_relationshipinsightsunifiedconfig**|
|10631|**siconfig**|
|10632|**SI Key Value Config**|
|10633|**Usage Metric**|
|10634|**Action Card Regarding**|
|10635|**Action Card Role Setting**|
|10636|**EntityRankingRule**|
|10637|**flowcardtype**|
|10638|**salesinsightssettings**|
|10639|**Action Card Usage**|
|10640|**Action Card Usage Aggregation**|
|10641|**Auto Capture Rule**|
|10642|**Auto Capture Settings**|
|10643|**UntrackedAppointment**|
|10644|**Suggested Activity**|
|10645|**Suggested Activity Data Source**|
|10646|**Suggested Contact**|
|10647|**Suggested Contacts Data Source**|
|10648|**Notes analysis Config**|
|10649|**icebreakersconfig**|
|10650|**dealmanageraccess**|
|10651|**Deal manager settings**|
|10652|**Account KPI Item**|
|10653|**Activity Analysis CleanUp State**|
|10654|**Relationship Analytics Config**|
|10655|**Contact KPI Item**|
|10656|**Daily Kpis for account**|
|10657|**Daily kpis for contact**|
|10658|**Daily kpis for lead**|
|10659|**Daily kpis for Opportunity**|
|10660|**Lead KPI Item**|
|10661|**Most Contacted**|
|10662|**Most Contacted By**|
|10663|**Opportunity KPI Item**|
|10664|**Relationship Analytics Metadata**|
|10665|**Similar entities feature importance**|
|10666|**wkwcolleaguesforcompany**|
|10667|**wkwcolleaguesforcontact**|
|10668|**wkwconfig**|
|10669|**Attribute Influence Statistics**|
|10670|**Prediction Computation Operation**|
|10671|**Prediction Model Status**|
|10672|**Prediction Scheduled Operation**|
|10673|**Predictive Model Score**|
|10674|**Predictive Score**|
|10675|**Predictive Scoring Sync Status**|
|10676|**Real Time Scoring**|
|10677|**Real Time Scoring Operation**|
|10678|**Submodel Definition**|
|10679|**Time spent in BPF**|
|10680|**Training Result**|
|10681|**OpportunityModelConfig**|
|10682|**LeadModelConfig**|
|10683|**ModelPreviewStatus**|
|10684|**Profile Album**|
|10685|**Post Configuration**|
|10686|**Post Rule Configuration**|
|10687|**Wall View**|
|10688|**Filter**|
|10689|**Customer Voice alert**|
|10690|**Customer Voice alert rule**|
|10691|**Customer Voice survey email template**|
|10692|**Customer Voice file response**|
|10693|**Customer Voice localized survey email template**|
|10694|**Customer Voice project**|
|10695|**Customer Voice survey question**|
|10696|**Customer Voice survey question response**|
|10697|**Customer Voice satisfaction metric**|
|10698|**Customer Voice survey**|
|10699|**Customer Voice survey invite**|
|10700|**Customer Voice survey reminder**|
|10701|**Customer Voice survey response**|
|10702|**Customer Voice unsubscribed recipient**|
|10703|**Customer Service Key Value Configuration**|
|10704|**AddToCalendar style**|
|10705|**basestyle**|
|10706|**Button style**|
|10707|**Code style**|
|10708|**Column style**|
|10709|**Content Block**|
|10710|**Divider style**|
|10711|**General styles**|
|10712|**imagestyle**|
|10713|**Layout Style**|
|10714|**QR code style**|
|10715|**Text style**|
|10716|**Video style**|
|10717|**App state**|
|10718|**CSAdminConfig**|
|10719|**Product Map**|
|10720|**Custom API Ruleset Configuration**|
|10721|**Decision contract**|
|10722|**Decision rule set**|
|10723|**Rulesetentitymapping**|
|10724|**Routing diagnostic item**|
|10725|**Routing diagnostic**|
|10726|**Template Context Variable**|
|10727|**Template Rule Set**|
|10728|**Template Variable Batch Operation**|
|10730|**Inbox card configuration**|
|10731|**Inbox Configuration**|
|10732|**Inbox Entity Configuration**|
|10733|**Inbox Personalized Configuration**|
|10734|**App Profile Copilot Configuration**|
|10735|**Swarm**|
|10736|**Swarm participant**|
|10737|**Swarm participant rule**|
|10738|**Swarm role**|
|10739|**Swarm skill**|
|10740|**Swarm template**|
|10741|**Autonomous case creation and update rules**|
|10742|**CHT App Profile Configuration**|
|10743|**Entity Attachment**|
|10744|**Time Tracker**|
|10745|**Customer feedback survey**|
|10746|**Customer feedback survey invite**|
|10747|**Customer feedback survey response**|
|10748|**msdyn_surveyconfig**|
|10749|**Survey setting**|
|10750|**Entity Attribute Prediction Rule**|
|10751|**Email Sentiment**|
|10752|**Agent Configuration**|
|10753|**Autonomous Agent Entity Mapping**|
|10754|**Autonomous Profile**|
|10755|**Rollout Plan**|
|10756|**Master Entity Routing Configuration**|
|10757|**Routing Rule Set Setting**|
|10758|**Assignment Configuration**|
|10759|**Assignment Configuration Step**|
|10760|**Capacity Profile**|
|10761|**Last Agent**|
|10762|**Overflow Action Config**|
|10763|**Preferred Agent**|
|10764|**Preferred Agent Customer Identity**|
|10765|**Preferred Agent Routed Entity**|
|10766|**Routing configuration**|
|10767|**Routing configuration step**|
|10768|**Bot Channel Registration**|
|10769|**Channel Configuration**|
|10770|**Channel State Configuration**|
|10771|**Provisioning State**|
|10772|**AdminAppState**|
|10773|**Agent Status history**|
|10774|**Power BI Configuration**|
|10775|**Authentication Settings**|
|10776|**Auth Settings Entry**|
|10777|**Quick reply**|
|10778|**Entity Routing Context**|
|10779|**Channel Capability**|
|10780|**Conversation Action**|
|10781|**Conversation Action Locale**|
|10782|**Conversation Message Block**|
|10783|**DeletedConversation**|
|10784|**Deprecated Workstream Entity Configuration**|
|10785|**Entity**|
|10786|**Ongoing conversation (Deprecated)**|
|10787|**Live work item event**|
|10788|**Work Stream**|
|10789|**Masking Rule**|
|10790|**Auto block rule**|
|10791|**Bot Channel Registration Secret**|
|10792|**Omnichannel channel api conversation privilege**|
|10793|**Omnichannel channel api message privilege**|
|10794|**Channel api method mapping**|
|10795|**External context**|
|10796|**Flagged spam**|
|10797|**Language**|
|10798|**Conversation**|
|10801|**Context item value**|
|10802|**Live Work Item Participant (Deprecated)**|
|10803|**Conversation Sentiment**|
|10804|**Context variable**|
|10805|**Localization**|
|10806|**OC Payment Profile**|
|10807|**Recording**|
|10808|**Omnichannel Request**|
|10809|**Rich message**|
|10810|**Rich message map**|
|10811|**Rule Item**|
|10812|**Sentiment daily topic**|
|10813|**Sentiment daily topic keyword**|
|10814|**Sentiment daily topic trending**|
|10815|**Session**|
|10816|**Session Participant Event**|
|10817|**Session Sentiment**|
|10818|**Message**|
|10819|**Tag**|
|10820|**Geo Location Provider**|
|10821|**Omnichannel Configuration**|
|10822|**Omnichannel Personalization**|
|10823|**Omnichannel Queue (Deprecated)**|
|10824|**Omnichannel Sync Config**|
|10825|**Operating Hour**|
|10826|**Personal quick reply**|
|10827|**Personal sound setting**|
|10828|**Persona Security Role Mapping**|
|10829|**Presence**|
|10830|**Provider**|
|10831|**RoutingRequest**|
|10832|**Search Configuration**|
|10833|**Sentiment analysis**|
|10834|**Session event**|
|10835|**Session participant**|
|10836|**Audio File**|
|10837|**Sound notification setting**|
|10838|**Transcript**|
|10839|**UR notification template**|
|10840|**UR Notification Template Mapping**|
|10841|**User settings**|
|10842|**Self service**|
|10849|**Agent capacity update history**|
|10850|**Bookable Resource Capacity Profile**|
|10851|**Work stream capacity profile**|
|10852|**Conversation Capacity profile**|
|10853|**Agent Capacity Profile Unit**|
|10854|**Agent Channel State**|
|10855|**Agent Status**|
|10856|**Agent Group**|
|10857|**Agent Group Language**|
|10858|**Agent Group Matching Criteria**|
|10859|**Agent Group Membership**|
|10860|**Agent Group Region**|
|10861|**Agent Language**|
|10862|**Agent Matching Criteria**|
|10863|**Agent Region**|
|10864|**Language Hierarchy**|
|10865|**Matching Criteria**|
|10866|**Conversation Matching Criteria**|
|10867|**Region**|
|10868|**Conversation Characteristic**|
|10869|**Session Characteristic**|
|10870|**Skill Attachment Rule**|
|10871|**Attach Skill**|
|10872|**Model training details**|
|10873|**Training data import configuration**|
|10874|**Characteristic mapping**|
|10875|**Training record**|
|10876|**Skill finder model**|
|10877|**Effort estimate**|
|10878|**Effort estimation model**|
|10879|**Effort model training details**|
|10880|**ConversationInsight**|
|10881|**Active ICD Extension**|
|10882|**Entity-Workstream Map**|
|10883|**ICD Extension**|
|10884|**msdyn_broadcastmessagebulkactionapiprivilege**|
|10885|**msdyn_bulkassigntoqueueapiprivilege**|
|10886|**msdyn_bulkforcecloseapiprivilege**|
|10887|**Lock Status**|
|10888|**Omnichannel agent assignment custom api privilege**|
|10889|**OCBulkAction**|
|10890|**Conversation Action Item**|
|10891|**Conversation Aggregated Insights**|
|10892|**Comment**|
|10893|**Conversation Participant Insights**|
|10894|**Conversation Participant Sentiment**|
|10895|**Conversation Question**|
|10896|**Conversation Segment Sentiment**|
|10897|**Conversation Sentiment**|
|10898|**Conversation Signal**|
|10899|**Conversation Subject**|
|10900|**Conversation Summary Suggestion**|
|10901|**Conversation System Tag**|
|10902|**Conversation Tag**|
|10903|**Recording (Deprecated)**|
|10904|**SCI Conversation**|
|10905|**Custom Email Highlight**|
|10906|**Custom Highlight**|
|10907|**Custom Publisher**|
|10908|**EnvironmentSettings**|
|10909|**UserSettings**|
|10910|**CatalogEventStatusConfiguration**|
|10911|**Configuration**|
|10912|**Trigger**|
|10913|**Triggers To Sdk Message Processing Steps**|
|10914|**EventParameterMetadata**|
|10915|**TrackingContext**|
|10916|**Marketing feature configuration**|
|10917|**msdynmkt_experimentv2**|
|10918|**ACS channel instance**|
|10919|**ACS channel instance account**|
|10920|**Infobip channel instance**|
|10921|**Infobip channel instance account**|
|10922|**Link mobility channel instance**|
|10923|**Link mobility channel instance account**|
|10924|**MockSmsProvider channel instance**|
|10925|**MockSmsProvider channel instance account**|
|10926|**TeleSign channel instance**|
|10927|**TeleSign channel instance account**|
|10928|**Twilio channel instance**|
|10929|**Twilio channel instance account**|
|10930|**Vibes channel instance**|
|10931|**Vibes channel instance account**|
|10932|**Predefined Placeholder**|
|10933|**Metadata Entity Relationship**|
|10934|**Metadata Item**|
|10935|**Metadata Store State**|
|10936|**DigitalSellingActiveTask**|
|10937|**DigitalSellingCompletedTask**|
|10938|**Sales Tag**|
|10939|**Sequence**|
|10940|**Sequence Stat**|
|10941|**Sequence Target**|
|10942|**Sequence Target Step**|
|10943|**Sequence Template**|
|10945|**sabackupdiagnostic**|
|10946|**SABatchRunInstance**|
|10947|**salesroutingdiagnostic**|
|10948|**SARunInstance**|
|10949|**Segment**|
|10950|**segmentsetting**|
|10951|**Segment property**|
|10952|**SegmentsUtil**|
|10953|**Assignment Rule**|
|10954|**Seller attribute**|
|10955|**Seller attribute value**|
|10956|**Assignment Map**|
|10957|**Sales Assignment Setting**|
|10958|**Sales routing run**|
|10960|**Extended User Setting**|
|10961|**Sales acceleration insights**|
|10962|**Sales Acceleration settings**|
|10963|**Insight**|
|10964|**Work List Suggestion**|
|10965|**Work list suggestion source**|
|10966|**Work List View Configuration**|
|10967|**Work Queue Record**|
|10968|**Work Queue Record State**|
|10969|**Work list user setting**|
|10970|**WQDataSource**|
|10971|**Suggestion Assignment Rule**|
|10972|**Suggestion Principal Object Access**|
|10973|**Suggestion Seller Priority**|
|10974|**Data Hygiene Setting Info**|
|10975|**Duplicate Detection Plugin Run**|
|10976|**Duplicate Lead Mapping**|
|10977|**Lead Hygiene Setting**|
|10978|**Linked Entity Attribute Validity**|
|10979|**Sales provisioning request**|
|10980|**SalesOmnichannel Message**|
|10981|**Text message template**|
|10982|**Data Analytics Admin Settings (Deprecated)**|
|10983|**Data Analytics Report**|
|10984|**Insights**|
|10985|**Sales acceleration reports**|
|10986|**Bot user mapping**|
|10988|**Bot Session**|
|10989|**Automated action rule**|
|10990|**Automated action rules mapping**|
|10991|**Last message info**|
|10992|**Conversation disposition code map**|
|10993|**Disposition Code Category**|
|10994|**Live Conversation Counter Condition**|
|10995|**OC Disposition Code**|
|10996|**Work Stream Bot Mapping**|
|10998|**Representative Copilot Setting**|
|10999|**Copilot Summarization Setting**|
|11000|**msdyn_agentsetting**|
|11001|**msdyn_businessprofile**|
|11002|**intent**|
|11003|**intentattribute**|
|11004|**intentattributeset**|
|11005|**intentattribute_entity**|
|11006|**Intent Config**|
|11007|**Intent Context History**|
|11008|**intententity**|
|11009|**LOB Backfill Status**|
|11010|**Line of Business**|
|11011|**msdyn_intentfamily_harvestingconfiguration**|
|11012|**msdyn_intentfeature_configuration**|
|11013|**Intent Group Condition**|
|11014|**msdyn_intentharvesting_batchjobstatus**|
|11015|**msdyn_intentharvesting_batchjobstatusdetail**|
|11016|**msdyn_intentharvesting_provisioning_status**|
|11017|**msdyn_intentmetrics**|
|11018|**msdyn_intentmetrics_aggregate**|
|11019|**msdyn_intentmetrics_jobdata**|
|11020|**Intent Playbook**|
|11021|**Intent playbook map**|
|11022|**Intent Solution Map**|
|11023|**msdyn_intentsolution_mappingconfiguration**|
|11024|**msdyn_organizationsolutionmap**|
|11025|**Case Enrichment**|
|11026|**Case follow up and closure configuration**|
|11027|**Case sentiment settings**|
|11028|**Case Suggestion**|
|11029|**Case Suggestion Request Payload**|
|11030|**Case Suggestions Data Souce**|
|11031|**User Preference For Copilot**|
|11032|**Copilot assisted case form fill settings**|
|11033|**Copilot Event**|
|11034|**Copilot Interaction**|
|11035|**Copilot Interaction Data**|
|11036|**Copilot knowledge interaction**|
|11037|**Copilot Transcript**|
|11038|**Copilot Transcript Data**|
|11039|**KB Enrichment**|
|11040|**Knowledge Article Suggestion**|
|11041|**Knowledge Article Suggestion Data Source**|
|11042|**Next Action**|
|11043|**Service Copilot Plugin**|
|11044|**Service Copilot Plugin Action**|
|11045|**Service Copilot Plugin Role**|
|11046|**Suggestion Interaction**|
|11047|**Suggestion request payload**|
|11048|**Suggestions Model Summary**|
|11049|**Suggestions Setting**|
|11050|**msdyn_caseaiprediction**|
|11051|**Data Analytics User Customized Report**|
|11052|**Data Analytics Dataset**|
|11053|**Data Analytics Workspace**|
|11054|**Report Bookmark**|
|11055|**Agent Resource Forecasting**|
|11056|**[Deprecated] Dynamics Customer Service Analytics**|
|11057|**Case Topic**|
|11058|**Case Topic Setting**|
|11059|**Case Topic Summary**|
|11060|**Case topic Incident mapping**|
|11061|**Customer Service historical analytics**|
|11062|**Email analytics**|
|11063|**Forecast**|
|11064|**Knowledge analytics**|
|11065|**Model Customization analytics**|
|11066|**Real-time analytics for record routing**|
|11067|**Forecast Summary and Setting**|
|11068|**Keywords Description Suggestion Setting**|
|11069|**Conversation Summary Interaction**|
|11070|**Conversation Summary Setting**|
|11071|**Conversation Topic**|
|11072|**Conversation Topic Setting**|
|11073|**Conversation Topic Summary**|
|11074|**Conversation topic Conversation mapping**|
|11075|**Omnichannel historical analytics**|
|11076|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|11077|**Omnichannel Realtime analytics**|
|11078|**Copilot Analytics**|
|11079|**Conversation Analytic**|
|11080|**Session Analytics**|
|11081|**Evaluation**|
|11082|**Evaluation category**|
|11083|**Evaluation criteria**|
|11084|**Evaluation criteria version**|
|11085|**Evaluation Global Config**|
|11086|**Evaluation input config**|
|11087|**Evaluation localized content**|
|11088|**Evaluation Plan**|
|11089|**Evaluation Plan Batch**|
|11090|**Evaluation Plan Ontrigger Backlog**|
|11091|**Evaluation Plan Run**|
|11092|**Evaluation question**|
|11093|**PA Flow Run Tracker**|
|11094|**Engage And Readiness Agent Result V2**|
|11095|**SalesAgentConfigurationV2**|
|11096|**SalesAgentExecutionConfig**|
|11097|**Sales Agent Handover**|
|11098|**SalesAgentProfile**|
|11099|**Sales agent run**|
|11100|**Trigger Sales Agent**|
|11101|**Account Research Agent Trigger**|
|11102|**Account Research Result**|
|11103|**Competitor Research Agent Trigger**|
|11104|**Summary Synthesizer Input**|
|11105|**summarysynthesizeroutput**|
|11106|**Lead Agent Result**|
|11107|**Lead Delink Result**|
|11108|**Lead Email Extension**|
|11109|**Outreach Agent Result**|
|11110|**Outreach Trigger Agent**|
|11111|**Qualification Agent Trigger**|
|11112|**Sales Agent Configuration**|
|11113|**SalesAgentUsage**|
|11114|**Stakeholder Research Output**|
|11115|**Target Customer Profile Prefill Agent Result**|
|11116|**TargetCustomerProfilePrefillAgentTrigger**|
|11117|**Engage And Readiness Agent Result**|

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

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sla?displayProperty=fullName>
