# CellStore.Api.DataApi

All URIs are relative to *http://fcavalieri.com:28080/secxbrl/v1/_queries/public*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddArchives**](DataApi.md#addarchives) | **POST** /api/archives | Add or update archives. The archives are identified with Archive IDs (AIDs).  A new empty archive can be created by submitting a JSON object containing general information about the archive. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive | | Entity   | string | optional | The EID to which the archive belongs | | Entities  | array of strings (at least one) | required if Entity is absent | Used if the archive reports information on more than one entity. | | InstanceURL  | string | optional | The URL of the original XBRL instance | | Namespaces  | object with string values | optional | Maps prefixes to namespaces for the archive (common bindings are automatically added) | | Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |  Additionally, the following fields are allowed for the purpose of feeding back the output of the archives endpoint as input:  - Components (string) - Sections (string) - NumSections (integer) - NumFacts (integer) - NumFootnotes (integer) - NumReportElements (integer) - NumHypercubes (integer) - NumDimensions (integer) - NumMembers (integer) - NumLineItems (integer) - NumAbstracts (integer) - NumConcepts (integer)  Several empty archives can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
[**AddEntities**](DataApi.md#addentities) | **POST** /api/entities | Add or update entity. The entities are identified with Entity IDs (EIDs).  An entity must be specified as a JSON object that must be valid against a JSound schema.  It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | EIDs  | array of strings (at least one) | required | The EIDs for this entity. | | Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |  Additionally, the following field is allowed for the purpose of feeding back the output of the entities endpoint as input:  - Archives (string)  Several entities can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
[**AddFacts**](DataApi.md#addfacts) | **POST** /api/facts | Add a fact to a archive.
[**AddLabels**](DataApi.md#addlabels) | **POST** /api/labels | Add or update labels. A label is identified with an Archive ID (AID), a section URI, a report element, a language and a label role.  A label can be created by submitting a JSON object containing general information about the label. This JSON object must be valid against a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field         | Type   | Presence | Content                          | |- -- -- -- -- -- -- --|- -- -- -- -|- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | AID           | string | required | The AID of the archive to which the section belongs | | SectionURI    | string | required | The URI of the section           | | ReportElement | string | required | The name of a report element     | | Language      | string | required | A language code, e.g., en-US or de | | Role          | string | required | A label role                     | | Value         | string | required | The label itself                 |  Several labels can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
[**AddModelStructureForComponent**](DataApi.md#addmodelstructureforcomponent) | **POST** /api/modelstructure-for-component | Add or update components by providing their model structures. The components are identified with an AID, a section URI and the qualified name of a hypercube.  A new component can be created by submitting a JSON object containing the model structure of the component. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive to which the component belongs | | SectionURI   | string (URI) | optional | The URI of the section to which the component belongs | | HypercubeName  | string (QName lexical space) | required | The name of the hypercube that this component involves | | ModelStructure  | array of model structure node objects | required | The hierarchical model structure, as a tree of nodes that reference report elements (see below) |  Additionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:  - Section (string) - Hypercube (string)  #### Model structure node properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | Name | string | required | The qualified name of a report element that exists in the component&#39;s section | | Children   | array | optional | An array of model structure node objects that reference further children report elements |  Additionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:  - Depth (integer) - Label (string) - BaseType (string) - Kind (string) - Order (integer) - DataType (string) - BaseDataType (string) - Balance (string) - Abstract (boolean) - PeriodType (string)  The hierarchy of the model structure must fulfill the constraints described in the documentation of model structures. We repeat it here for convenience:  | Kind of report element |  Allowed children                           | |- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Abstract               | Hypercube (if top-level), Abstract, Concept | | Hypercube              | Dimension, LineItems                        | | Dimension              | Member                                      | | Member                 | Member                                      | | LineItems              | Abstract, Concept                           | | Concept                | none                                        |  The model structure MUST involve the hypercube referred to in the top-level HypercubeName field, only this one, and only once, either top-level or below a top-level abstract. Its children are the dimensions with their members, as well as the line items hierarchy.  The only exception to the requirement of the hypercube report element is the special xbrl28:ImpliedTable hypercube. If HypercubeName is xbrl28:ImpliedTable, then the model structure can only involve Abstracts and Concepts, and has no dimensionality.  Several components can be created at the same time by posting a sequence of non-comma-separated JSON model structure objects as above. 
[**AddReportElements**](DataApi.md#addreportelements) | **POST** /api/report-elements | Add or update report elements. The report elements are identified with an AID, a section URI and a qualified name.  A new report element can be created by submitting a JSON object containing general information about the report element. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive to which the report element belongs | | SectionURI   | string (URI) | required | The URI of the section to which the report element belongs | | Name  | string (QName lexical space) | required | The name of the report element (of the form foo:Bar) | | Kind  | One of: Concept, Abstract, LineItems, Hypercube, Dimension, Member | optional | One of the six kinds of report element | | PeriodType  | One of: instant, duration | optional | Only allowed for the Concept kind. Indicates the period type (whether facts against this concept must have instant or duration periods). | | DataType | string (QName lexical space) | optional | Only allowed for the Concept kind. Indicates the data type (value facts against this concept must have). | | Balance | One of: credit, debit | optional | Only allowed for the Concept kind, and if the data type is monetary. Indicates the balance. | | IsNillable | boolean | optional | Only allowed for the Concept kind. Specifies whether null is accepted as a fact value. |  Additionally, the following fields are allowed for the purpose of feeding back the output of the report-elements endpoint as input:  - Components (string) - IsAbstract (boolean) - BaseType (string) - ClosestSchemaBuiltinType (string) - IsTextBlock (boolean) - Labels (string) - Facts (string) - Labels (string) - Label (string) - Section (string) - CIK (string) - EntityRegistrantName (string) - FiscalYear (integer) - FiscalPeriod (string)  For report elements with the kind Concept, the data type must be one of the following:  - xbrli:decimalItemType - xbrli:floatItemType - xbrli:doubleItemType - xbrli:integerItemType - xbrli:positiveIntegerItemType - xbrli:nonPositiveIntegerItemType - xbrli:nonNegativeIntegerItemType - xbrli:negativeIntegershortItemType - xbrli:byteItemType - xbrli:intItemType - xbrli:longItemType - xbrli:unsignedShorItemType - xbrli:unsignedByteItemType - xbrli:unsignedIntItemType - xbrli:unsignedLongItemType - xbrli:stringItemType (implied/only one allowed for Hypercube, Dimension, LineItems and Abstract kinds) - xbrli:booleanItemType - xbrli:hexBinaryItemType - xbrli:base64BinaryItemType - xbrli:anyURIItemType - xbrli:QNameItemType - xbrli:durationItemType - xbrli:timeItemType - xbrli:dateItemType - xbrli:gYearMonthItemType - xbrli:gYearItemType - xbrli:gMonthItemType - xbrli:gMonthDayItemType - xbrli:gDayItemType - xbrli:normalizedStringItemType - xbrli:tokenItemType - xbrli:languageItemType - xbrli:NameItemType - xbrli:NCNameItemType - xbrli:monetaryItemType (allows Balance) - xbrli:pureItemType - xbrli:sharesItemType - xbrli:fractionItemType - nonnum:domainItemType (implied/only one allowed for Member kind) - nonnum:escapedItemType - nonnum:xmlNodesItemType - nonnum:xmlItemType - nonnum:textBlockItemType - num:percentItemType - num:perShareItemType - num:areaItemType - num:volumeItemType - num:massItemType - num:weightItemType - num:energyItemType - num:powerItemType - num:lengthItemType - num:noDecimalsMonetaryItemType (allows Balance) - num:nonNegativeMonetaryItemType (allows Balance) - num:nonNegativeNoDecimalsMonetaryItemType (allows Balance) - num:enumerationItemType  Several report elements can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
[**AddRules**](DataApi.md#addrules) | **POST** /api/rules | 
[**AddSections**](DataApi.md#addsections) | **POST** /api/sections | Add or update sections. A section is identified with an Archive ID (AID) and a section URI.  A section can be created by submitting a JSON object containing general information about the section. This JSON object must be valid against a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive to which the section belongs | | SectionURI   | string | required | The URI of the section | | Section  | string | required | A user-friendly label for the section (preferably in English). | | Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |  Additionally, the following fields are allowed for the purpose of feeding back the output of the sections endpoint as input:  - Components (string) - ReportElements (string) - FactTable (string) - Spreadsheet (string) - Category (string) - SubCategory (string) - Disclosure (string) - NumRules (integer) - NumReportElements (integer) - NumHypercubes (integer) - NumDimensions (integer) - NumMembers (integer) - NumLineItems (integer) - NumAbstracts (integer) - NumConcepts (integer) - EntityRegistrantName (string) - CIK (string) - FiscalYear (integer) - FiscalPeriod (string) - AcceptanceDatetime (string) - FormType (string)  Several empty sections can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
[**AddTaxonomy**](DataApi.md#addtaxonomy) | **POST** /api/taxonomies | Adds a new taxonomy archive given one or more entrypoints. The taxonomy archive is identified with an Archive ID (AID). 
[**CopyArchive**](DataApi.md#copyarchive) | **POST** /api/archives/copy | Copies an existing archive. The new archive copy will retain all the data (components, report-elements, facts, footnotes) of the copied archive and will have a new Archive ID. Optionally a new Entity ID for the copied archive can be specified. 
[**DeleteArchive**](DataApi.md#deletearchive) | **DELETE** /api/archives | Deletes an archive.
[**DeleteEntity**](DataApi.md#deleteentity) | **DELETE** /api/entities | Deletes an entity.
[**DeleteLabel**](DataApi.md#deletelabel) | **DELETE** /api/labels | Deletes a label.
[**DeleteModelStructureForComponent**](DataApi.md#deletemodelstructureforcomponent) | **DELETE** /api/modelstructure-for-component | Deletes a component including its model structure.
[**DeleteReportElement**](DataApi.md#deletereportelement) | **DELETE** /api/report-elements | Deletes a report element.
[**DeleteSection**](DataApi.md#deletesection) | **DELETE** /api/sections | Deletes a section.
[**EditArchives**](DataApi.md#editarchives) | **PATCH** /api/archives | Update one or more archives with partial information
[**EditEntities**](DataApi.md#editentities) | **PATCH** /api/entities | Update one or more entities with partial information
[**EditFacts**](DataApi.md#editfacts) | **PATCH** /api/facts | Patch one or more facts
[**GetArchives**](DataApi.md#getarchives) | **GET** /api/archives | Retrieve metadata about the archives, also called archives. The archives are identified with Archive IDs (AIDs). Facts can be bound with archives with the xbrl28:Archive aspect, whose values are AIDs.
[**GetComponents**](DataApi.md#getcomponents) | **GET** /api/components | Retrieve a summary for all components of a given archive
[**GetDataPointsForComponent**](DataApi.md#getdatapointsforcomponent) | **GET** /api/data-points-for-component | Retrieve the data points for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
[**GetEntities**](DataApi.md#getentities) | **GET** /api/entities | Retrieve metadata about the entities that submit archives. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs.
[**GetFactTableForComponent**](DataApi.md#getfacttableforcomponent) | **GET** /api/facttable-for-component | Retrieve the fact table for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
[**GetFactTableForReport**](DataApi.md#getfacttableforreport) | **GET** /api/facttable-for-report | Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering.
[**GetFacts**](DataApi.md#getfacts) | **GET** /api/facts | Retrieve one or more facts for a combination of archives.
[**GetLabels**](DataApi.md#getlabels) | **GET** /api/labels | Retrieve labels for the supplied components and report elements
[**GetModelStructureForComponent**](DataApi.md#getmodelstructureforcomponent) | **GET** /api/modelstructure-for-component | Retrieve the model structure for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
[**GetPeriods**](DataApi.md#getperiods) | **GET** /api/periods | Retrieve the periods of the archives filed by a particular entity
[**GetReportElements**](DataApi.md#getreportelements) | **GET** /api/report-elements | Retrieve the report elements contained in a set of archives.
[**GetRules**](DataApi.md#getrules) | **GET** /api/rules | Retrieve a summary for all rules of a given section
[**GetSections**](DataApi.md#getsections) | **GET** /api/sections | Retrieve a summary for all sections of a given archive
[**GetSpreadsheetForComponent**](DataApi.md#getspreadsheetforcomponent) | **GET** /api/spreadsheet-for-component | Retrieve the business-friendly spreadsheet for a given component.  A component can be selected in several ways, for example with an Archive ID (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc. 
[**GetSpreadsheetForReport**](DataApi.md#getspreadsheetforreport) | **GET** /api/spreadsheet-for-report | Retrieve the business-friendly spreadsheet for a report.  Filters can be overriden. Filters MUST be overriden if the report is not already filtering. 
[**GetTables**](DataApi.md#gettables) | **GET** /api/tables | Retrieve tables metadata
[**ImportArchive**](DataApi.md#importarchive) | **POST** /api/archives/import | Imports an archive.   A full import is performed by provided, in the body of the request, a ZIP Deflate-compressed archive. This will import all the facts from the instance, as well as the taxonomy schema and linkbases. 
[**RemoveRule**](DataApi.md#removerule) | **DELETE** /api/rules | Delete a rule for a given section


<a name="addarchives"></a>
# **AddArchives**
> Object AddArchives (string token, Object archive, string profileName = null, string format = null)

Add or update archives. The archives are identified with Archive IDs (AIDs).  A new empty archive can be created by submitting a JSON object containing general information about the archive. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive | | Entity   | string | optional | The EID to which the archive belongs | | Entities  | array of strings (at least one) | required if Entity is absent | Used if the archive reports information on more than one entity. | | InstanceURL  | string | optional | The URL of the original XBRL instance | | Namespaces  | object with string values | optional | Maps prefixes to namespaces for the archive (common bindings are automatically added) | | Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |  Additionally, the following fields are allowed for the purpose of feeding back the output of the archives endpoint as input:  - Components (string) - Sections (string) - NumSections (integer) - NumFacts (integer) - NumFootnotes (integer) - NumReportElements (integer) - NumHypercubes (integer) - NumDimensions (integer) - NumMembers (integer) - NumLineItems (integer) - NumAbstracts (integer) - NumConcepts (integer)  Several empty archives can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class AddArchivesExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var archive = ;  // Object | The body of the request. The archive JSON objects, which must satisfy the constraints described in the field table. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)

            try
            {
                // Add or update archives. The archives are identified with Archive IDs (AIDs).  A new empty archive can be created by submitting a JSON object containing general information about the archive. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive | | Entity   | string | optional | The EID to which the archive belongs | | Entities  | array of strings (at least one) | required if Entity is absent | Used if the archive reports information on more than one entity. | | InstanceURL  | string | optional | The URL of the original XBRL instance | | Namespaces  | object with string values | optional | Maps prefixes to namespaces for the archive (common bindings are automatically added) | | Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |  Additionally, the following fields are allowed for the purpose of feeding back the output of the archives endpoint as input:  - Components (string) - Sections (string) - NumSections (integer) - NumFacts (integer) - NumFootnotes (integer) - NumReportElements (integer) - NumHypercubes (integer) - NumDimensions (integer) - NumMembers (integer) - NumLineItems (integer) - NumAbstracts (integer) - NumConcepts (integer)  Several empty archives can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
                Object result = apiInstance.AddArchives(token, archive, profileName, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.AddArchives: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **archive** | **Object**| The body of the request. The archive JSON objects, which must satisfy the constraints described in the field table. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addentities"></a>
# **AddEntities**
> Object AddEntities (string token, Object entity, string format = null)

Add or update entity. The entities are identified with Entity IDs (EIDs).  An entity must be specified as a JSON object that must be valid against a JSound schema.  It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | EIDs  | array of strings (at least one) | required | The EIDs for this entity. | | Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |  Additionally, the following field is allowed for the purpose of feeding back the output of the entities endpoint as input:  - Archives (string)  Several entities can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class AddEntitiesExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var entity = ;  // Object | The entity objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table. (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)

            try
            {
                // Add or update entity. The entities are identified with Entity IDs (EIDs).  An entity must be specified as a JSON object that must be valid against a JSound schema.  It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | EIDs  | array of strings (at least one) | required | The EIDs for this entity. | | Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |  Additionally, the following field is allowed for the purpose of feeding back the output of the entities endpoint as input:  - Archives (string)  Several entities can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
                Object result = apiInstance.AddEntities(token, entity, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.AddEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **entity** | **Object**| The entity objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table. | [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfacts"></a>
# **AddFacts**
> Object AddFacts (string token, Object fact, string format = null)

Add a fact to a archive.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class AddFactsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var fact = ;  // Object | The fact objects (they must be valid, and have an archive aspect that points to an existing archive). To logically delete a fact, omit the Value field. (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)

            try
            {
                // Add a fact to a archive.
                Object result = apiInstance.AddFacts(token, fact, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.AddFacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **fact** | **Object**| The fact objects (they must be valid, and have an archive aspect that points to an existing archive). To logically delete a fact, omit the Value field. | [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlabels"></a>
# **AddLabels**
> Object AddLabels (string token, Object label, string format = null)

Add or update labels. A label is identified with an Archive ID (AID), a section URI, a report element, a language and a label role.  A label can be created by submitting a JSON object containing general information about the label. This JSON object must be valid against a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field         | Type   | Presence | Content                          | |- -- -- -- -- -- -- --|- -- -- -- -|- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | AID           | string | required | The AID of the archive to which the section belongs | | SectionURI    | string | required | The URI of the section           | | ReportElement | string | required | The name of a report element     | | Language      | string | required | A language code, e.g., en-US or de | | Role          | string | required | A label role                     | | Value         | string | required | The label itself                 |  Several labels can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class AddLabelsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var label = ;  // Object | The label objects (they must be valid). (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)

            try
            {
                // Add or update labels. A label is identified with an Archive ID (AID), a section URI, a report element, a language and a label role.  A label can be created by submitting a JSON object containing general information about the label. This JSON object must be valid against a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field         | Type   | Presence | Content                          | |- -- -- -- -- -- -- --|- -- -- -- -|- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | AID           | string | required | The AID of the archive to which the section belongs | | SectionURI    | string | required | The URI of the section           | | ReportElement | string | required | The name of a report element     | | Language      | string | required | A language code, e.g., en-US or de | | Role          | string | required | A label role                     | | Value         | string | required | The label itself                 |  Several labels can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
                Object result = apiInstance.AddLabels(token, label, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.AddLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **label** | **Object**| The label objects (they must be valid). | [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmodelstructureforcomponent"></a>
# **AddModelStructureForComponent**
> Object AddModelStructureForComponent (string token, Object modelStructure, string profileName = null, string format = null)

Add or update components by providing their model structures. The components are identified with an AID, a section URI and the qualified name of a hypercube.  A new component can be created by submitting a JSON object containing the model structure of the component. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive to which the component belongs | | SectionURI   | string (URI) | optional | The URI of the section to which the component belongs | | HypercubeName  | string (QName lexical space) | required | The name of the hypercube that this component involves | | ModelStructure  | array of model structure node objects | required | The hierarchical model structure, as a tree of nodes that reference report elements (see below) |  Additionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:  - Section (string) - Hypercube (string)  #### Model structure node properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | Name | string | required | The qualified name of a report element that exists in the component's section | | Children   | array | optional | An array of model structure node objects that reference further children report elements |  Additionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:  - Depth (integer) - Label (string) - BaseType (string) - Kind (string) - Order (integer) - DataType (string) - BaseDataType (string) - Balance (string) - Abstract (boolean) - PeriodType (string)  The hierarchy of the model structure must fulfill the constraints described in the documentation of model structures. We repeat it here for convenience:  | Kind of report element |  Allowed children                           | |- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Abstract               | Hypercube (if top-level), Abstract, Concept | | Hypercube              | Dimension, LineItems                        | | Dimension              | Member                                      | | Member                 | Member                                      | | LineItems              | Abstract, Concept                           | | Concept                | none                                        |  The model structure MUST involve the hypercube referred to in the top-level HypercubeName field, only this one, and only once, either top-level or below a top-level abstract. Its children are the dimensions with their members, as well as the line items hierarchy.  The only exception to the requirement of the hypercube report element is the special xbrl28:ImpliedTable hypercube. If HypercubeName is xbrl28:ImpliedTable, then the model structure can only involve Abstracts and Concepts, and has no dimensionality.  Several components can be created at the same time by posting a sequence of non-comma-separated JSON model structure objects as above. 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class AddModelStructureForComponentExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var modelStructure = ;  // Object | The model structures, which must satisfy the constraints described in the properties table. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)

            try
            {
                // Add or update components by providing their model structures. The components are identified with an AID, a section URI and the qualified name of a hypercube.  A new component can be created by submitting a JSON object containing the model structure of the component. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive to which the component belongs | | SectionURI   | string (URI) | optional | The URI of the section to which the component belongs | | HypercubeName  | string (QName lexical space) | required | The name of the hypercube that this component involves | | ModelStructure  | array of model structure node objects | required | The hierarchical model structure, as a tree of nodes that reference report elements (see below) |  Additionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:  - Section (string) - Hypercube (string)  #### Model structure node properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | Name | string | required | The qualified name of a report element that exists in the component's section | | Children   | array | optional | An array of model structure node objects that reference further children report elements |  Additionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:  - Depth (integer) - Label (string) - BaseType (string) - Kind (string) - Order (integer) - DataType (string) - BaseDataType (string) - Balance (string) - Abstract (boolean) - PeriodType (string)  The hierarchy of the model structure must fulfill the constraints described in the documentation of model structures. We repeat it here for convenience:  | Kind of report element |  Allowed children                           | |- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Abstract               | Hypercube (if top-level), Abstract, Concept | | Hypercube              | Dimension, LineItems                        | | Dimension              | Member                                      | | Member                 | Member                                      | | LineItems              | Abstract, Concept                           | | Concept                | none                                        |  The model structure MUST involve the hypercube referred to in the top-level HypercubeName field, only this one, and only once, either top-level or below a top-level abstract. Its children are the dimensions with their members, as well as the line items hierarchy.  The only exception to the requirement of the hypercube report element is the special xbrl28:ImpliedTable hypercube. If HypercubeName is xbrl28:ImpliedTable, then the model structure can only involve Abstracts and Concepts, and has no dimensionality.  Several components can be created at the same time by posting a sequence of non-comma-separated JSON model structure objects as above. 
                Object result = apiInstance.AddModelStructureForComponent(token, modelStructure, profileName, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.AddModelStructureForComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **modelStructure** | **Object**| The model structures, which must satisfy the constraints described in the properties table. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreportelements"></a>
# **AddReportElements**
> Object AddReportElements (string token, Object reportElement, string format = null)

Add or update report elements. The report elements are identified with an AID, a section URI and a qualified name.  A new report element can be created by submitting a JSON object containing general information about the report element. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive to which the report element belongs | | SectionURI   | string (URI) | required | The URI of the section to which the report element belongs | | Name  | string (QName lexical space) | required | The name of the report element (of the form foo:Bar) | | Kind  | One of: Concept, Abstract, LineItems, Hypercube, Dimension, Member | optional | One of the six kinds of report element | | PeriodType  | One of: instant, duration | optional | Only allowed for the Concept kind. Indicates the period type (whether facts against this concept must have instant or duration periods). | | DataType | string (QName lexical space) | optional | Only allowed for the Concept kind. Indicates the data type (value facts against this concept must have). | | Balance | One of: credit, debit | optional | Only allowed for the Concept kind, and if the data type is monetary. Indicates the balance. | | IsNillable | boolean | optional | Only allowed for the Concept kind. Specifies whether null is accepted as a fact value. |  Additionally, the following fields are allowed for the purpose of feeding back the output of the report-elements endpoint as input:  - Components (string) - IsAbstract (boolean) - BaseType (string) - ClosestSchemaBuiltinType (string) - IsTextBlock (boolean) - Labels (string) - Facts (string) - Labels (string) - Label (string) - Section (string) - CIK (string) - EntityRegistrantName (string) - FiscalYear (integer) - FiscalPeriod (string)  For report elements with the kind Concept, the data type must be one of the following:  - xbrli:decimalItemType - xbrli:floatItemType - xbrli:doubleItemType - xbrli:integerItemType - xbrli:positiveIntegerItemType - xbrli:nonPositiveIntegerItemType - xbrli:nonNegativeIntegerItemType - xbrli:negativeIntegershortItemType - xbrli:byteItemType - xbrli:intItemType - xbrli:longItemType - xbrli:unsignedShorItemType - xbrli:unsignedByteItemType - xbrli:unsignedIntItemType - xbrli:unsignedLongItemType - xbrli:stringItemType (implied/only one allowed for Hypercube, Dimension, LineItems and Abstract kinds) - xbrli:booleanItemType - xbrli:hexBinaryItemType - xbrli:base64BinaryItemType - xbrli:anyURIItemType - xbrli:QNameItemType - xbrli:durationItemType - xbrli:timeItemType - xbrli:dateItemType - xbrli:gYearMonthItemType - xbrli:gYearItemType - xbrli:gMonthItemType - xbrli:gMonthDayItemType - xbrli:gDayItemType - xbrli:normalizedStringItemType - xbrli:tokenItemType - xbrli:languageItemType - xbrli:NameItemType - xbrli:NCNameItemType - xbrli:monetaryItemType (allows Balance) - xbrli:pureItemType - xbrli:sharesItemType - xbrli:fractionItemType - nonnum:domainItemType (implied/only one allowed for Member kind) - nonnum:escapedItemType - nonnum:xmlNodesItemType - nonnum:xmlItemType - nonnum:textBlockItemType - num:percentItemType - num:perShareItemType - num:areaItemType - num:volumeItemType - num:massItemType - num:weightItemType - num:energyItemType - num:powerItemType - num:lengthItemType - num:noDecimalsMonetaryItemType (allows Balance) - num:nonNegativeMonetaryItemType (allows Balance) - num:nonNegativeNoDecimalsMonetaryItemType (allows Balance) - num:enumerationItemType  Several report elements can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class AddReportElementsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var reportElement = ;  // Object | The report element objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table. (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)

            try
            {
                // Add or update report elements. The report elements are identified with an AID, a section URI and a qualified name.  A new report element can be created by submitting a JSON object containing general information about the report element. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive to which the report element belongs | | SectionURI   | string (URI) | required | The URI of the section to which the report element belongs | | Name  | string (QName lexical space) | required | The name of the report element (of the form foo:Bar) | | Kind  | One of: Concept, Abstract, LineItems, Hypercube, Dimension, Member | optional | One of the six kinds of report element | | PeriodType  | One of: instant, duration | optional | Only allowed for the Concept kind. Indicates the period type (whether facts against this concept must have instant or duration periods). | | DataType | string (QName lexical space) | optional | Only allowed for the Concept kind. Indicates the data type (value facts against this concept must have). | | Balance | One of: credit, debit | optional | Only allowed for the Concept kind, and if the data type is monetary. Indicates the balance. | | IsNillable | boolean | optional | Only allowed for the Concept kind. Specifies whether null is accepted as a fact value. |  Additionally, the following fields are allowed for the purpose of feeding back the output of the report-elements endpoint as input:  - Components (string) - IsAbstract (boolean) - BaseType (string) - ClosestSchemaBuiltinType (string) - IsTextBlock (boolean) - Labels (string) - Facts (string) - Labels (string) - Label (string) - Section (string) - CIK (string) - EntityRegistrantName (string) - FiscalYear (integer) - FiscalPeriod (string)  For report elements with the kind Concept, the data type must be one of the following:  - xbrli:decimalItemType - xbrli:floatItemType - xbrli:doubleItemType - xbrli:integerItemType - xbrli:positiveIntegerItemType - xbrli:nonPositiveIntegerItemType - xbrli:nonNegativeIntegerItemType - xbrli:negativeIntegershortItemType - xbrli:byteItemType - xbrli:intItemType - xbrli:longItemType - xbrli:unsignedShorItemType - xbrli:unsignedByteItemType - xbrli:unsignedIntItemType - xbrli:unsignedLongItemType - xbrli:stringItemType (implied/only one allowed for Hypercube, Dimension, LineItems and Abstract kinds) - xbrli:booleanItemType - xbrli:hexBinaryItemType - xbrli:base64BinaryItemType - xbrli:anyURIItemType - xbrli:QNameItemType - xbrli:durationItemType - xbrli:timeItemType - xbrli:dateItemType - xbrli:gYearMonthItemType - xbrli:gYearItemType - xbrli:gMonthItemType - xbrli:gMonthDayItemType - xbrli:gDayItemType - xbrli:normalizedStringItemType - xbrli:tokenItemType - xbrli:languageItemType - xbrli:NameItemType - xbrli:NCNameItemType - xbrli:monetaryItemType (allows Balance) - xbrli:pureItemType - xbrli:sharesItemType - xbrli:fractionItemType - nonnum:domainItemType (implied/only one allowed for Member kind) - nonnum:escapedItemType - nonnum:xmlNodesItemType - nonnum:xmlItemType - nonnum:textBlockItemType - num:percentItemType - num:perShareItemType - num:areaItemType - num:volumeItemType - num:massItemType - num:weightItemType - num:energyItemType - num:powerItemType - num:lengthItemType - num:noDecimalsMonetaryItemType (allows Balance) - num:nonNegativeMonetaryItemType (allows Balance) - num:nonNegativeNoDecimalsMonetaryItemType (allows Balance) - num:enumerationItemType  Several report elements can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
                Object result = apiInstance.AddReportElements(token, reportElement, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.AddReportElements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **reportElement** | **Object**| The report element objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table. | [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addrules"></a>
# **AddRules**
> Object AddRules (string token, Object rules)



### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class AddRulesExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var rules = ;  // Object | The rule objects. (default to null)

            try
            {
                // 
                Object result = apiInstance.AddRules(token, rules);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.AddRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **rules** | **Object**| The rule objects. | [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsections"></a>
# **AddSections**
> Object AddSections (string token, Object section, string profileName = null, string format = null)

Add or update sections. A section is identified with an Archive ID (AID) and a section URI.  A section can be created by submitting a JSON object containing general information about the section. This JSON object must be valid against a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive to which the section belongs | | SectionURI   | string | required | The URI of the section | | Section  | string | required | A user-friendly label for the section (preferably in English). | | Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |  Additionally, the following fields are allowed for the purpose of feeding back the output of the sections endpoint as input:  - Components (string) - ReportElements (string) - FactTable (string) - Spreadsheet (string) - Category (string) - SubCategory (string) - Disclosure (string) - NumRules (integer) - NumReportElements (integer) - NumHypercubes (integer) - NumDimensions (integer) - NumMembers (integer) - NumLineItems (integer) - NumAbstracts (integer) - NumConcepts (integer) - EntityRegistrantName (string) - CIK (string) - FiscalYear (integer) - FiscalPeriod (string) - AcceptanceDatetime (string) - FormType (string)  Several empty sections can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class AddSectionsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var section = ;  // Object | The section objects (they must be valid). (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)

            try
            {
                // Add or update sections. A section is identified with an Archive ID (AID) and a section URI.  A section can be created by submitting a JSON object containing general information about the section. This JSON object must be valid against a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.  For convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.  #### Body properties  | Field | Type | Presence | Content | |- -- -- --|- -- -- -|- -- -- -- -- -|- -- -- -- --| | AID | string | required | The AID of the archive to which the section belongs | | SectionURI   | string | required | The URI of the section | | Section  | string | required | A user-friendly label for the section (preferably in English). | | Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |  Additionally, the following fields are allowed for the purpose of feeding back the output of the sections endpoint as input:  - Components (string) - ReportElements (string) - FactTable (string) - Spreadsheet (string) - Category (string) - SubCategory (string) - Disclosure (string) - NumRules (integer) - NumReportElements (integer) - NumHypercubes (integer) - NumDimensions (integer) - NumMembers (integer) - NumLineItems (integer) - NumAbstracts (integer) - NumConcepts (integer) - EntityRegistrantName (string) - CIK (string) - FiscalYear (integer) - FiscalPeriod (string) - AcceptanceDatetime (string) - FormType (string)  Several empty sections can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
                Object result = apiInstance.AddSections(token, section, profileName, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.AddSections: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **section** | **Object**| The section objects (they must be valid). | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtaxonomy"></a>
# **AddTaxonomy**
> Object AddTaxonomy (string token, string eid, List<string> entrypoint, string profileName = null, string format = null, string aid = null, int? timeout = null, bool? insertEntity = null)

Adds a new taxonomy archive given one or more entrypoints. The taxonomy archive is identified with an Archive ID (AID). 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class AddTaxonomyExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var eid = eid_example;  // string | The EID (scheme + local name) of a company, to add a new taxonomy. (default to null)
            var entrypoint = new List<string>(); // List<string> | The URI of a taxonomy entrypoint. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = aid_example;  // string | Archive ID of the archive or taxonomy. (optional)  (default to null)
            var timeout = 56;  // int? | Timeout for the operation. (optional)  (default to null)
            var insertEntity = true;  // bool? | If false, and one or more of the archive entities are not present in the repository an error is raised. If true, the missing entity is inserted. (Default is true) (optional)  (default to true)

            try
            {
                // Adds a new taxonomy archive given one or more entrypoints. The taxonomy archive is identified with an Archive ID (AID). 
                Object result = apiInstance.AddTaxonomy(token, eid, entrypoint, profileName, format, aid, timeout, insertEntity);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.AddTaxonomy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **eid** | **string**| The EID (scheme + local name) of a company, to add a new taxonomy. | [default to null]
 **entrypoint** | [**List<string>**](string.md)| The URI of a taxonomy entrypoint. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | **string**| Archive ID of the archive or taxonomy. | [optional] [default to null]
 **timeout** | **int?**| Timeout for the operation. | [optional] [default to null]
 **insertEntity** | **bool?**| If false, and one or more of the archive entities are not present in the repository an error is raised. If true, the missing entity is inserted. (Default is true) | [optional] [default to true]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copyarchive"></a>
# **CopyArchive**
> Object CopyArchive (string token, string fromAid, string format = null, string aid = null, string eid = null, bool? insertEntity = null, bool? copyFacts = null)

Copies an existing archive. The new archive copy will retain all the data (components, report-elements, facts, footnotes) of the copied archive and will have a new Archive ID. Optionally a new Entity ID for the copied archive can be specified. 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class CopyArchiveExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var fromAid = fromAid_example;  // string | Archive ID of the archive or taxonomy to copy. (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = aid_example;  // string | Archive ID of the archive or taxonomy. (optional)  (default to null)
            var eid = eid_example;  // string | The EID (scheme + local name) of a company. (optional)  (default to null)
            var insertEntity = true;  // bool? | If false, and the specified new Entity ID is not present in the Cellstore an error is raised. If true, the missing entity is inserted. (Default is true) (optional)  (default to true)
            var copyFacts = true;  // bool? | Whether to copy the archive facts or not. (optional)  (default to true)

            try
            {
                // Copies an existing archive. The new archive copy will retain all the data (components, report-elements, facts, footnotes) of the copied archive and will have a new Archive ID. Optionally a new Entity ID for the copied archive can be specified. 
                Object result = apiInstance.CopyArchive(token, fromAid, format, aid, eid, insertEntity, copyFacts);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.CopyArchive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **fromAid** | **string**| Archive ID of the archive or taxonomy to copy. | [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | **string**| Archive ID of the archive or taxonomy. | [optional] [default to null]
 **eid** | **string**| The EID (scheme + local name) of a company. | [optional] [default to null]
 **insertEntity** | **bool?**| If false, and the specified new Entity ID is not present in the Cellstore an error is raised. If true, the missing entity is inserted. (Default is true) | [optional] [default to true]
 **copyFacts** | **bool?**| Whether to copy the archive facts or not. | [optional] [default to true]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletearchive"></a>
# **DeleteArchive**
> Object DeleteArchive (string token, string profileName = null, string format = null, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null)

Deletes an archive.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class DeleteArchiveExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = aid_example;  // string | Archive ID of the archive or taxonomy. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)

            try
            {
                // Deletes an archive.
                Object result = apiInstance.DeleteArchive(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, archiveFiscalYear, archiveFiscalPeriod, archiveTag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.DeleteArchive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | **string**| Archive ID of the archive or taxonomy. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteentity"></a>
# **DeleteEntity**
> Object DeleteEntity (string token, string profileName = null, string format = null, string eid = null, List<string> cik = null, List<string> edinetcode = null, List<string> ticker = null)

Deletes an entity.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class DeleteEntityExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var eid = eid_example;  // string | The EID (scheme + local name) of a company. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)

            try
            {
                // Deletes an entity.
                Object result = apiInstance.DeleteEntity(token, profileName, format, eid, cik, edinetcode, ticker);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.DeleteEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **eid** | **string**| The EID (scheme + local name) of a company. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelabel"></a>
# **DeleteLabel**
> Object DeleteLabel (string token, string profileName = null, string format = null, string aid = null, string section = null, string reportElement = null, string language = null, List<string> labelRole = null)

Deletes a label.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class DeleteLabelExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = aid_example;  // string | Archive ID of the archive or taxonomy. (optional)  (default to null)
            var section = section_example;  // string | The URI of a particular section. (optional)  (default to null)
            var reportElement = reportElement_example;  // string | The name of the report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var labelRole = new List<string>(); // List<string> | A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values). (optional)  (default to null)

            try
            {
                // Deletes a label.
                Object result = apiInstance.DeleteLabel(token, profileName, format, aid, section, reportElement, language, labelRole);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.DeleteLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | **string**| Archive ID of the archive or taxonomy. | [optional] [default to null]
 **section** | **string**| The URI of a particular section. | [optional] [default to null]
 **reportElement** | **string**| The name of the report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **labelRole** | [**List<string>**](string.md)| A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values). | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemodelstructureforcomponent"></a>
# **DeleteModelStructureForComponent**
> Object DeleteModelStructureForComponent (string token, List<string> aid = null, List<string> section = null, List<string> hypercube = null)

Deletes a component including its model structure.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class DeleteModelStructureForComponentExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var hypercube = new List<string>(); // List<string> | The name of a hypercube report element, to retrieve components / sections. (optional)  (default to null)

            try
            {
                // Deletes a component including its model structure.
                Object result = apiInstance.DeleteModelStructureForComponent(token, aid, section, hypercube);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.DeleteModelStructureForComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **hypercube** | [**List<string>**](string.md)| The name of a hypercube report element, to retrieve components / sections. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereportelement"></a>
# **DeleteReportElement**
> Object DeleteReportElement (string token, string profileName = null, string format = null, string aid = null, string section = null, string reportElement = null)

Deletes a report element.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class DeleteReportElementExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = aid_example;  // string | Archive ID of the archive or taxonomy. (optional)  (default to null)
            var section = section_example;  // string | The URI of a particular section. (optional)  (default to null)
            var reportElement = reportElement_example;  // string | The name of the report element (e.g. us-gaap:Goodwill). (optional)  (default to null)

            try
            {
                // Deletes a report element.
                Object result = apiInstance.DeleteReportElement(token, profileName, format, aid, section, reportElement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.DeleteReportElement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | **string**| Archive ID of the archive or taxonomy. | [optional] [default to null]
 **section** | **string**| The URI of a particular section. | [optional] [default to null]
 **reportElement** | **string**| The name of the report element (e.g. us-gaap:Goodwill). | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesection"></a>
# **DeleteSection**
> Object DeleteSection (string token, string profileName = null, string format = null, string aid = null, string section = null)

Deletes a section.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class DeleteSectionExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = aid_example;  // string | Archive ID of the archive or taxonomy. (optional)  (default to null)
            var section = section_example;  // string | The URI of a particular section. (optional)  (default to null)

            try
            {
                // Deletes a section.
                Object result = apiInstance.DeleteSection(token, profileName, format, aid, section);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.DeleteSection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | **string**| Archive ID of the archive or taxonomy. | [optional] [default to null]
 **section** | **string**| The URI of a particular section. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editarchives"></a>
# **EditArchives**
> Object EditArchives (string token, Object patch, string profileName = null, string format = null, List<string> aid = null, List<string> entityTag = null, List<string> eid = null, List<string> cik = null, List<string> edinetcode = null, List<string> sic = null, List<string> ticker = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null)

Update one or more archives with partial information

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class EditArchivesExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var patch = ;  // Object | The patch object, which will be merged into each archive (the archive objects must be valid after applying it).  Updating the AID of an archive is not allowed.  (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)

            try
            {
                // Update one or more archives with partial information
                Object result = apiInstance.EditArchives(token, patch, profileName, format, aid, entityTag, eid, cik, edinetcode, sic, ticker, archiveFiscalYear, archiveFiscalPeriod, archiveTag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.EditArchives: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **patch** | **Object**| The patch object, which will be merged into each archive (the archive objects must be valid after applying it).  Updating the AID of an archive is not allowed.  | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editentities"></a>
# **EditEntities**
> Object EditEntities (string token, Object patch, string profileName = null, string format = null, List<string> entityTag = null, List<string> eid = null, List<string> cik = null, List<string> edinetcode = null, List<string> sic = null, List<string> ticker = null)

Update one or more entities with partial information

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class EditEntitiesExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var patch = ;  // Object | The patch object, which will be merged into each entity (the entities must be valid after applying it).  Updating the EID of an entity is not allowed.  (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)

            try
            {
                // Update one or more entities with partial information
                Object result = apiInstance.EditEntities(token, patch, profileName, format, entityTag, eid, cik, edinetcode, sic, ticker);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.EditEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **patch** | **Object**| The patch object, which will be merged into each entity (the entities must be valid after applying it).  Updating the EID of an entity is not allowed.  | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editfacts"></a>
# **EditFacts**
> Object EditFacts (string token, Object patch, string profileName = null, string format = null, List<string> entityTag = null, List<string> eid = null, List<string> cik = null, List<string> edinetcode = null, List<string> sic = null, List<string> ticker = null, List<string> aid = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string map = null, string rule = null, string report = null, string additionalRules = null, bool? open = null, Dictionary<string, List<string>> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, Dictionary<string, string> dimensionAggregation = null, string aggregationFunction = null, bool? validate = null, bool? count = null)

Patch one or more facts

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class EditFactsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var patch = ;  // Object | The patch object, which will be merged into each facts (the facts must be valid after applying it). (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var concept = new List<string>(); // List<string> | The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). (optional)  (default to null)
            var fiscalYear = new List<string>(); // List<string> | A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). (optional)  (default to null)
            var fiscalPeriod = new List<string>(); // List<string> | A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). (optional)  (default to null)
            var fiscalPeriodType = new List<string>(); // List<string> | A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var map = map_example;  // string | [Deprecated, use report] The concept map that should be used to resolve the concept (default: none). (optional)  (default to null)
            var rule = rule_example;  // string | [Deprecated, use report] The rules that should be used to resolve the concept (default: none). (optional)  (default to null)
            var report = report_example;  // string | The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none). (optional)  (default to null)
            var additionalRules = additionalRules_example;  // string | The name of a report from which to use rules in addition to a report's rules (e.g. FundamentalAccountingConcepts). (optional)  (default to null)
            var open = true;  // bool? | Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). (optional)  (default to false)
            var dimensions = new Dictionary<string, List<string>>(); // Dictionary<string, List<string>> | A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. (optional)  (default to null)
            var dimensionTypes = prefixdimensiontype_example;  // Dictionary<string, string> | Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string. (optional)  (default to null)
            var defaultDimensionValues = prefixdimensiondefault_example;  // Dictionary<string, string> | Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string. (optional)  (default to null)
            var dimensionsCategory = prefixdimensioncategory_example;  // Dictionary<string, string> | Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). (optional)  (default to null)
            var dimensionsVisible = true;  // Dictionary<string, bool?> | Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. (optional)  (default to null)
            var dimensionSlicers = true;  // Dictionary<string, bool?> | [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). (optional)  (default to null)
            var dimensionColumns = 56;  // Dictionary<string, int?> | If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order). (optional)  (default to null)
            var dimensionAggregation = prefixdimensionaggregation_example;  // Dictionary<string, string> | [Deprecated] Specifies whether this dimension is a dicer ('group') or not ('no'). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers ('group') and non-key aspects are not ('no'). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer. (optional)  (default to null)
            var aggregationFunction = aggregationFunction_example;  // string | Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. (optional)  (default to null)
            var validate = true;  // bool? | Whether or not to stamp facts for validity (default is false). (optional)  (default to false)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)

            try
            {
                // Patch one or more facts
                Object result = apiInstance.EditFacts(token, patch, profileName, format, entityTag, eid, cik, edinetcode, sic, ticker, aid, concept, fiscalYear, fiscalPeriod, fiscalPeriodType, archiveFiscalYear, archiveFiscalPeriod, map, rule, report, additionalRules, open, dimensions, dimensionTypes, defaultDimensionValues, dimensionsCategory, dimensionsVisible, dimensionSlicers, dimensionColumns, dimensionAggregation, aggregationFunction, validate, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.EditFacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **patch** | **Object**| The patch object, which will be merged into each facts (the facts must be valid after applying it). | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **concept** | [**List<string>**](string.md)| The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). | [optional] [default to null]
 **fiscalYear** | [**List<string>**](string.md)| A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). | [optional] [default to null]
 **fiscalPeriod** | [**List<string>**](string.md)| A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). | [optional] [default to null]
 **fiscalPeriodType** | [**List<string>**](string.md)| A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **map** | **string**| [Deprecated, use report] The concept map that should be used to resolve the concept (default: none). | [optional] [default to null]
 **rule** | **string**| [Deprecated, use report] The rules that should be used to resolve the concept (default: none). | [optional] [default to null]
 **report** | **string**| The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none). | [optional] [default to null]
 **additionalRules** | **string**| The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts). | [optional] [default to null]
 **open** | **bool?**| Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). | [optional] [default to false]
 **dimensions** | [**Dictionary<string, List<string>>**](List&lt;string&gt;.md)| A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. | [optional] [default to null]
 **dimensionTypes** | **Dictionary<string, string>**| Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string. | [optional] [default to null]
 **defaultDimensionValues** | **Dictionary<string, string>**| Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string. | [optional] [default to null]
 **dimensionsCategory** | **Dictionary<string, string>**| Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). | [optional] [default to null]
 **dimensionsVisible** | **Dictionary<string, bool?>**| Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. | [optional] [default to null]
 **dimensionSlicers** | **Dictionary<string, bool?>**| [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). | [optional] [default to null]
 **dimensionColumns** | **Dictionary<string, int?>**| If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order). | [optional] [default to null]
 **dimensionAggregation** | **Dictionary<string, string>**| [Deprecated] Specifies whether this dimension is a dicer (&#39;group&#39;) or not (&#39;no&#39;). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers (&#39;group&#39;) and non-key aspects are not (&#39;no&#39;). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer. | [optional] [default to null]
 **aggregationFunction** | **string**| Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. | [optional] [default to null]
 **validate** | **bool?**| Whether or not to stamp facts for validity (default is false). | [optional] [default to false]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getarchives"></a>
# **GetArchives**
> Object GetArchives (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null, string language = null, bool? dts = null, bool? count = null, int? top = null, int? skip = null)

Retrieve metadata about the archives, also called archives. The archives are identified with Archive IDs (AIDs). Facts can be bound with archives with the xbrl28:Archive aspect, whose values are AIDs.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetArchivesExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var dts = true;  // bool? | Whether DTS and entrypoint information should be included for each archive (default: false). (optional)  (default to false)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve metadata about the archives, also called archives. The archives are identified with Archive IDs (AIDs). Facts can be bound with archives with the xbrl28:Archive aspect, whose values are AIDs.
                Object result = apiInstance.GetArchives(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, archiveFiscalYear, archiveFiscalPeriod, archiveTag, language, dts, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetArchives: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **dts** | **bool?**| Whether DTS and entrypoint information should be included for each archive (default: false). | [optional] [default to false]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomponents"></a>
# **GetComponents**
> Object GetComponents (string token, string profileName = null, string format = null, List<string> eid = null, List<string> ticker = null, List<string> entityTag = null, List<string> sic = null, List<string> cik = null, List<string> edinetcode = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null, List<string> aid = null, List<string> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, List<string> label = null, bool? count = null, int? top = null, int? skip = null, bool? validate = null, string language = null, List<string> concept = null, Dictionary<string, List<string>> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null)

Retrieve a summary for all components of a given archive

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetComponentsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var hypercube = new List<string>(); // List<string> | The name of a hypercube report element, to retrieve labels. (optional)  (default to null)
            var disclosure = new List<string>(); // List<string> | A disclosure, to identify sections or components (e.g. BalanceSheet). (optional)  (default to null)
            var reportElement = new List<string>(); // List<string> | The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var label = new List<string>(); // List<string> | A search term to search in the labels of components, to retrieve components (e.g. stock). (optional)  (default to null)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)
            var validate = true;  // bool? | Whether to run validation on the output components (default: false). Adds a column ValidationErrors (optional)  (default to false)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var concept = new List<string>(); // List<string> | The name of a concept to specify a data point to restrict components. (optional)  (default to null)
            var dimensions = new Dictionary<string, List<string>>(); // Dictionary<string, List<string>> | A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. (optional)  (default to null)
            var dimensionTypes = prefixdimensiontype_example;  // Dictionary<string, string> | Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string. (optional)  (default to null)
            var defaultDimensionValues = prefixdimensiondefault_example;  // Dictionary<string, string> | Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string. (optional)  (default to null)

            try
            {
                // Retrieve a summary for all components of a given archive
                Object result = apiInstance.GetComponents(token, profileName, format, eid, ticker, entityTag, sic, cik, edinetcode, archiveFiscalYear, archiveFiscalPeriod, archiveTag, aid, section, hypercube, disclosure, reportElement, label, count, top, skip, validate, language, concept, dimensions, dimensionTypes, defaultDimensionValues);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **hypercube** | [**List<string>**](string.md)| The name of a hypercube report element, to retrieve labels. | [optional] [default to null]
 **disclosure** | [**List<string>**](string.md)| A disclosure, to identify sections or components (e.g. BalanceSheet). | [optional] [default to null]
 **reportElement** | [**List<string>**](string.md)| The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **label** | [**List<string>**](string.md)| A search term to search in the labels of components, to retrieve components (e.g. stock). | [optional] [default to null]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]
 **validate** | **bool?**| Whether to run validation on the output components (default: false). Adds a column ValidationErrors | [optional] [default to false]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **concept** | [**List<string>**](string.md)| The name of a concept to specify a data point to restrict components. | [optional] [default to null]
 **dimensions** | [**Dictionary<string, List<string>>**](List&lt;string&gt;.md)| A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. | [optional] [default to null]
 **dimensionTypes** | **Dictionary<string, string>**| Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string. | [optional] [default to null]
 **defaultDimensionValues** | **Dictionary<string, string>**| Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatapointsforcomponent"></a>
# **GetDataPointsForComponent**
> Object GetDataPointsForComponent (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, bool? labels = null, bool? metadata = null, bool? open = null, Dictionary<string, List<string>> dimensions = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, List<string> archiveTag = null, List<string> disclosure = null, List<string> reportElement = null, List<string> label = null, bool? merge = null, string language = null, bool? _override = null, bool? count = null, int? top = null, int? skip = null)

Retrieve the data points for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetDataPointsForComponentExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var hypercube = new List<string>(); // List<string> | The name of a hypercube report element, to retrieve components / sections. (optional)  (default to null)
            var concept = new List<string>(); // List<string> | The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). (optional)  (default to null)
            var fiscalYear = new List<string>(); // List<string> | A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). (optional)  (default to null)
            var fiscalPeriod = new List<string>(); // List<string> | A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). (optional)  (default to null)
            var fiscalPeriodType = new List<string>(); // List<string> | A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var labels = true;  // bool? | Whether human-readable labels should be included for concepts in each fact (default: false). (optional)  (default to false)
            var metadata = true;  // bool? | Whether metadata about the facts concept and dimensions should be included in each fact (default: false). (optional)  (default to false)
            var open = true;  // bool? | Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). (optional)  (default to false)
            var dimensions = new Dictionary<string, List<string>>(); // Dictionary<string, List<string>> | A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. (optional)  (default to null)
            var dimensionsCategory = prefixdimensioncategory_example;  // Dictionary<string, string> | Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). (optional)  (default to null)
            var dimensionsVisible = true;  // Dictionary<string, bool?> | Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. (optional)  (default to null)
            var dimensionSlicers = true;  // Dictionary<string, bool?> | [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). (optional)  (default to null)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var disclosure = new List<string>(); // List<string> | A disclosure, to identify sections or components (e.g. BalanceSheet). (optional)  (default to null)
            var reportElement = new List<string>(); // List<string> | The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var label = new List<string>(); // List<string> | A search term to search in the labels of components, to retrieve components (e.g. stock). (optional)  (default to null)
            var merge = true;  // bool? | Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true). (optional)  (default to true)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var _override = true;  // bool? | Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: true if a profile is active, otherwise automatically activated). (optional)  (default to null)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve the data points for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
                Object result = apiInstance.GetDataPointsForComponent(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, section, hypercube, concept, fiscalYear, fiscalPeriod, fiscalPeriodType, archiveFiscalYear, archiveFiscalPeriod, labels, metadata, open, dimensions, dimensionsCategory, dimensionsVisible, dimensionSlicers, archiveTag, disclosure, reportElement, label, merge, language, _override, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetDataPointsForComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **hypercube** | [**List<string>**](string.md)| The name of a hypercube report element, to retrieve components / sections. | [optional] [default to null]
 **concept** | [**List<string>**](string.md)| The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). | [optional] [default to null]
 **fiscalYear** | [**List<string>**](string.md)| A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). | [optional] [default to null]
 **fiscalPeriod** | [**List<string>**](string.md)| A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). | [optional] [default to null]
 **fiscalPeriodType** | [**List<string>**](string.md)| A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **labels** | **bool?**| Whether human-readable labels should be included for concepts in each fact (default: false). | [optional] [default to false]
 **metadata** | **bool?**| Whether metadata about the facts concept and dimensions should be included in each fact (default: false). | [optional] [default to false]
 **open** | **bool?**| Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). | [optional] [default to false]
 **dimensions** | [**Dictionary<string, List<string>>**](List&lt;string&gt;.md)| A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. | [optional] [default to null]
 **dimensionsCategory** | **Dictionary<string, string>**| Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). | [optional] [default to null]
 **dimensionsVisible** | **Dictionary<string, bool?>**| Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. | [optional] [default to null]
 **dimensionSlicers** | **Dictionary<string, bool?>**| [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). | [optional] [default to null]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **disclosure** | [**List<string>**](string.md)| A disclosure, to identify sections or components (e.g. BalanceSheet). | [optional] [default to null]
 **reportElement** | [**List<string>**](string.md)| The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **label** | [**List<string>**](string.md)| A search term to search in the labels of components, to retrieve components (e.g. stock). | [optional] [default to null]
 **merge** | **bool?**| Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true). | [optional] [default to true]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **_override** | **bool?**| Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: true if a profile is active, otherwise automatically activated). | [optional] [default to null]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentities"></a>
# **GetEntities**
> Object GetEntities (string token, string profileName = null, string format = null, List<string> entityTag = null, List<string> eid = null, List<string> cik = null, List<string> edinetcode = null, List<string> sic = null, List<string> ticker = null, string entitySearch = null, int? entitySearchOffset = null, int? entitySearchLimit = null, string language = null, bool? count = null, int? top = null, int? skip = null)

Retrieve metadata about the entities that submit archives. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetEntitiesExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entitySearch = entitySearch_example;  // string | Includes in the results the entities whose name match this full-text query (optional)  (default to null)
            var entitySearchOffset = 56;  // int? | Includes in the results the entities whose name match the entity-search parameter skipping the first entity-search-offset results (default: 0) (optional)  (default to null)
            var entitySearchLimit = 56;  // int? | Includes in the results the entities whose name match the entity-search parameter limited to a maximum of entity-search-limit results (default: 100) (optional)  (default to null)
            var language = language_example;  // string | Specifies in which language to perform the entity-search query (default: en-US) (optional)  (default to en-US)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve metadata about the entities that submit archives. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs.
                Object result = apiInstance.GetEntities(token, profileName, format, entityTag, eid, cik, edinetcode, sic, ticker, entitySearch, entitySearchOffset, entitySearchLimit, language, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entitySearch** | **string**| Includes in the results the entities whose name match this full-text query | [optional] [default to null]
 **entitySearchOffset** | **int?**| Includes in the results the entities whose name match the entity-search parameter skipping the first entity-search-offset results (default: 0) | [optional] [default to null]
 **entitySearchLimit** | **int?**| Includes in the results the entities whose name match the entity-search parameter limited to a maximum of entity-search-limit results (default: 100) | [optional] [default to null]
 **language** | **string**| Specifies in which language to perform the entity-search query (default: en-US) | [optional] [default to en-US]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfacttableforcomponent"></a>
# **GetFactTableForComponent**
> Object GetFactTableForComponent (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string additionalRules = null, bool? labels = null, bool? metadata = null, string auditTrails = null, bool? open = null, Dictionary<string, List<string>> dimensions = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, List<string> archiveTag = null, List<string> disclosure = null, List<string> reportElement = null, List<string> label = null, string aggregationFunction = null, bool? validate = null, bool? merge = null, string language = null, bool? _override = null, bool? count = null, int? top = null, int? skip = null)

Retrieve the fact table for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetFactTableForComponentExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var hypercube = new List<string>(); // List<string> | The name of a hypercube report element, to retrieve components / sections. (optional)  (default to null)
            var concept = new List<string>(); // List<string> | The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). (optional)  (default to null)
            var fiscalYear = new List<string>(); // List<string> | A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). (optional)  (default to null)
            var fiscalPeriod = new List<string>(); // List<string> | A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). (optional)  (default to null)
            var fiscalPeriodType = new List<string>(); // List<string> | A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var additionalRules = additionalRules_example;  // string | The name of a report from which to use rules in addition to a report's rules (e.g. FundamentalAccountingConcepts). (optional)  (default to null)
            var labels = true;  // bool? | Whether human-readable labels should be included for concepts in each fact (default: false). (optional)  (default to false)
            var metadata = true;  // bool? | Whether metadata about the facts concept and dimensions should be included in each fact (default: false). (optional)  (default to false)
            var auditTrails = auditTrails_example;  // string | Whether audit trails should be included in each fact (default: no). (optional)  (default to no)
            var open = true;  // bool? | Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). (optional)  (default to false)
            var dimensions = new Dictionary<string, List<string>>(); // Dictionary<string, List<string>> | A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. (optional)  (default to null)
            var dimensionsCategory = prefixdimensioncategory_example;  // Dictionary<string, string> | Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). (optional)  (default to null)
            var dimensionsVisible = true;  // Dictionary<string, bool?> | Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. (optional)  (default to null)
            var dimensionSlicers = true;  // Dictionary<string, bool?> | [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). (optional)  (default to null)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var disclosure = new List<string>(); // List<string> | A disclosure, to identify sections or components (e.g. BalanceSheet). (optional)  (default to null)
            var reportElement = new List<string>(); // List<string> | The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var label = new List<string>(); // List<string> | A search term to search in the labels of components, to retrieve components (e.g. stock). (optional)  (default to null)
            var aggregationFunction = aggregationFunction_example;  // string | Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. (optional)  (default to null)
            var validate = true;  // bool? | Whether or not to stamp facts for validity (default is false). (optional)  (default to false)
            var merge = true;  // bool? | Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true). (optional)  (default to true)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var _override = true;  // bool? | Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: true if a profile is active, otherwise automatically activated). (optional)  (default to null)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve the fact table for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
                Object result = apiInstance.GetFactTableForComponent(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, section, hypercube, concept, fiscalYear, fiscalPeriod, fiscalPeriodType, archiveFiscalYear, archiveFiscalPeriod, additionalRules, labels, metadata, auditTrails, open, dimensions, dimensionsCategory, dimensionsVisible, dimensionSlicers, archiveTag, disclosure, reportElement, label, aggregationFunction, validate, merge, language, _override, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetFactTableForComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **hypercube** | [**List<string>**](string.md)| The name of a hypercube report element, to retrieve components / sections. | [optional] [default to null]
 **concept** | [**List<string>**](string.md)| The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). | [optional] [default to null]
 **fiscalYear** | [**List<string>**](string.md)| A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). | [optional] [default to null]
 **fiscalPeriod** | [**List<string>**](string.md)| A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). | [optional] [default to null]
 **fiscalPeriodType** | [**List<string>**](string.md)| A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **additionalRules** | **string**| The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts). | [optional] [default to null]
 **labels** | **bool?**| Whether human-readable labels should be included for concepts in each fact (default: false). | [optional] [default to false]
 **metadata** | **bool?**| Whether metadata about the facts concept and dimensions should be included in each fact (default: false). | [optional] [default to false]
 **auditTrails** | **string**| Whether audit trails should be included in each fact (default: no). | [optional] [default to no]
 **open** | **bool?**| Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). | [optional] [default to false]
 **dimensions** | [**Dictionary<string, List<string>>**](List&lt;string&gt;.md)| A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. | [optional] [default to null]
 **dimensionsCategory** | **Dictionary<string, string>**| Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). | [optional] [default to null]
 **dimensionsVisible** | **Dictionary<string, bool?>**| Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. | [optional] [default to null]
 **dimensionSlicers** | **Dictionary<string, bool?>**| [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). | [optional] [default to null]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **disclosure** | [**List<string>**](string.md)| A disclosure, to identify sections or components (e.g. BalanceSheet). | [optional] [default to null]
 **reportElement** | [**List<string>**](string.md)| The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **label** | [**List<string>**](string.md)| A search term to search in the labels of components, to retrieve components (e.g. stock). | [optional] [default to null]
 **aggregationFunction** | **string**| Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. | [optional] [default to null]
 **validate** | **bool?**| Whether or not to stamp facts for validity (default is false). | [optional] [default to false]
 **merge** | **bool?**| Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true). | [optional] [default to true]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **_override** | **bool?**| Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: true if a profile is active, otherwise automatically activated). | [optional] [default to null]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfacttableforreport"></a>
# **GetFactTableForReport**
> Object GetFactTableForReport (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, bool? open = null, string report = null, bool? labels = null, bool? metadata = null, string auditTrails = null, string language = null, string aggregationFunction = null, bool? validate = null, bool? _override = null, bool? count = null, int? top = null, int? skip = null)

Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetFactTableForReportExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var concept = new List<string>(); // List<string> | The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). (optional)  (default to null)
            var fiscalYear = new List<string>(); // List<string> | A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). (optional)  (default to null)
            var fiscalPeriod = new List<string>(); // List<string> | A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). (optional)  (default to null)
            var fiscalPeriodType = new List<string>(); // List<string> | A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var open = true;  // bool? | Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). (optional)  (default to false)
            var report = report_example;  // string | The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none). (optional)  (default to null)
            var labels = true;  // bool? | Whether human-readable labels should be included for concepts in each fact (default: false). (optional)  (default to false)
            var metadata = true;  // bool? | Whether metadata about the facts concept and dimensions should be included in each fact (default: false). (optional)  (default to false)
            var auditTrails = auditTrails_example;  // string | Whether audit trails should be included in each fact (default: no). (optional)  (default to no)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var aggregationFunction = aggregationFunction_example;  // string | Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. (optional)  (default to null)
            var validate = true;  // bool? | Whether or not to stamp facts for validity (default is false). (optional)  (default to false)
            var _override = true;  // bool? | Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: true if a profile is active, otherwise automatically activated). (optional)  (default to null)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering.
                Object result = apiInstance.GetFactTableForReport(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, concept, fiscalYear, fiscalPeriod, fiscalPeriodType, archiveFiscalYear, archiveFiscalPeriod, open, report, labels, metadata, auditTrails, language, aggregationFunction, validate, _override, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetFactTableForReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **concept** | [**List<string>**](string.md)| The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). | [optional] [default to null]
 **fiscalYear** | [**List<string>**](string.md)| A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). | [optional] [default to null]
 **fiscalPeriod** | [**List<string>**](string.md)| A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). | [optional] [default to null]
 **fiscalPeriodType** | [**List<string>**](string.md)| A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **open** | **bool?**| Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). | [optional] [default to false]
 **report** | **string**| The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none). | [optional] [default to null]
 **labels** | **bool?**| Whether human-readable labels should be included for concepts in each fact (default: false). | [optional] [default to false]
 **metadata** | **bool?**| Whether metadata about the facts concept and dimensions should be included in each fact (default: false). | [optional] [default to false]
 **auditTrails** | **string**| Whether audit trails should be included in each fact (default: no). | [optional] [default to no]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **aggregationFunction** | **string**| Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. | [optional] [default to null]
 **validate** | **bool?**| Whether or not to stamp facts for validity (default is false). | [optional] [default to false]
 **_override** | **bool?**| Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: true if a profile is active, otherwise automatically activated). | [optional] [default to null]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfacts"></a>
# **GetFacts**
> Object GetFacts (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string map = null, string rule = null, string report = null, string additionalRules = null, bool? labels = null, bool? metadata = null, string auditTrails = null, bool? open = null, Dictionary<string, List<string>> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, Dictionary<string, string> dimensionAggregation = null, string aggregationFunction = null, bool? validate = null, bool? count = null, int? top = null, int? skip = null)

Retrieve one or more facts for a combination of archives.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetFactsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var concept = new List<string>(); // List<string> | The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). (optional)  (default to null)
            var fiscalYear = new List<string>(); // List<string> | A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). (optional)  (default to null)
            var fiscalPeriod = new List<string>(); // List<string> | A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). (optional)  (default to null)
            var fiscalPeriodType = new List<string>(); // List<string> | A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var map = map_example;  // string | [Deprecated, use report] The concept map that should be used to resolve the concept (default: none). (optional)  (default to null)
            var rule = rule_example;  // string | [Deprecated, use report] The rules that should be used to resolve the concept (default: none). (optional)  (default to null)
            var report = report_example;  // string | The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none). (optional)  (default to null)
            var additionalRules = additionalRules_example;  // string | The name of a report from which to use rules in addition to a report's rules (e.g. FundamentalAccountingConcepts). (optional)  (default to null)
            var labels = true;  // bool? | Whether human-readable labels should be included for concepts in each fact (default: false). (optional)  (default to false)
            var metadata = true;  // bool? | Whether metadata about the facts concept and dimensions should be included in each fact (default: false). (optional)  (default to false)
            var auditTrails = auditTrails_example;  // string | Whether audit trails should be included in each fact (default: no). (optional)  (default to no)
            var open = true;  // bool? | Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). (optional)  (default to false)
            var dimensions = new Dictionary<string, List<string>>(); // Dictionary<string, List<string>> | A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. (optional)  (default to null)
            var dimensionTypes = prefixdimensiontype_example;  // Dictionary<string, string> | Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string. (optional)  (default to null)
            var defaultDimensionValues = prefixdimensiondefault_example;  // Dictionary<string, string> | Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string. (optional)  (default to null)
            var dimensionsCategory = prefixdimensioncategory_example;  // Dictionary<string, string> | Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). (optional)  (default to null)
            var dimensionsVisible = true;  // Dictionary<string, bool?> | Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. (optional)  (default to null)
            var dimensionSlicers = true;  // Dictionary<string, bool?> | [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). (optional)  (default to null)
            var dimensionColumns = 56;  // Dictionary<string, int?> | If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order). (optional)  (default to null)
            var dimensionAggregation = prefixdimensionaggregation_example;  // Dictionary<string, string> | [Deprecated] Specifies whether this dimension is a dicer ('group') or not ('no'). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers ('group') and non-key aspects are not ('no'). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer. (optional)  (default to null)
            var aggregationFunction = aggregationFunction_example;  // string | Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. (optional)  (default to null)
            var validate = true;  // bool? | Whether or not to stamp facts for validity (default is false). (optional)  (default to false)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve one or more facts for a combination of archives.
                Object result = apiInstance.GetFacts(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, concept, fiscalYear, fiscalPeriod, fiscalPeriodType, archiveFiscalYear, archiveFiscalPeriod, map, rule, report, additionalRules, labels, metadata, auditTrails, open, dimensions, dimensionTypes, defaultDimensionValues, dimensionsCategory, dimensionsVisible, dimensionSlicers, dimensionColumns, dimensionAggregation, aggregationFunction, validate, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetFacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **concept** | [**List<string>**](string.md)| The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). | [optional] [default to null]
 **fiscalYear** | [**List<string>**](string.md)| A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). | [optional] [default to null]
 **fiscalPeriod** | [**List<string>**](string.md)| A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). | [optional] [default to null]
 **fiscalPeriodType** | [**List<string>**](string.md)| A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **map** | **string**| [Deprecated, use report] The concept map that should be used to resolve the concept (default: none). | [optional] [default to null]
 **rule** | **string**| [Deprecated, use report] The rules that should be used to resolve the concept (default: none). | [optional] [default to null]
 **report** | **string**| The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none). | [optional] [default to null]
 **additionalRules** | **string**| The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts). | [optional] [default to null]
 **labels** | **bool?**| Whether human-readable labels should be included for concepts in each fact (default: false). | [optional] [default to false]
 **metadata** | **bool?**| Whether metadata about the facts concept and dimensions should be included in each fact (default: false). | [optional] [default to false]
 **auditTrails** | **string**| Whether audit trails should be included in each fact (default: no). | [optional] [default to no]
 **open** | **bool?**| Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). | [optional] [default to false]
 **dimensions** | [**Dictionary<string, List<string>>**](List&lt;string&gt;.md)| A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. | [optional] [default to null]
 **dimensionTypes** | **Dictionary<string, string>**| Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string. | [optional] [default to null]
 **defaultDimensionValues** | **Dictionary<string, string>**| Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string. | [optional] [default to null]
 **dimensionsCategory** | **Dictionary<string, string>**| Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). | [optional] [default to null]
 **dimensionsVisible** | **Dictionary<string, bool?>**| Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. | [optional] [default to null]
 **dimensionSlicers** | **Dictionary<string, bool?>**| [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). | [optional] [default to null]
 **dimensionColumns** | **Dictionary<string, int?>**| If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order). | [optional] [default to null]
 **dimensionAggregation** | **Dictionary<string, string>**| [Deprecated] Specifies whether this dimension is a dicer (&#39;group&#39;) or not (&#39;no&#39;). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers (&#39;group&#39;) and non-key aspects are not (&#39;no&#39;). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer. | [optional] [default to null]
 **aggregationFunction** | **string**| Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. | [optional] [default to null]
 **validate** | **bool?**| Whether or not to stamp facts for validity (default is false). | [optional] [default to false]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlabels"></a>
# **GetLabels**
> Object GetLabels (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null, List<string> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, List<string> label = null, string language = null, List<string> labelRole = null, bool? onlyTextBlocks = null, List<string> kind = null, bool? eliminateReportElementDuplicates = null, bool? count = null, int? top = null, int? skip = null)

Retrieve labels for the supplied components and report elements

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetLabelsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var hypercube = new List<string>(); // List<string> | The name of a hypercube report element, to retrieve labels. (optional)  (default to null)
            var disclosure = new List<string>(); // List<string> | A disclosure, to identify sections or components (e.g. BalanceSheet). (optional)  (default to null)
            var reportElement = new List<string>(); // List<string> | The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var label = new List<string>(); // List<string> | A search term to search in the labels of components, to retrieve components (e.g. stock). (optional)  (default to null)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var labelRole = new List<string>(); // List<string> | A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values). (optional)  (default to null)
            var onlyTextBlocks = true;  // bool? | If set to true only labels for concepts defined as textBlockItemType are returned (default: false). (optional)  (default to false)
            var kind = new List<string>(); // List<string> | Filters by concept kind (default: no filtering) (optional)  (default to null)
            var eliminateReportElementDuplicates = true;  // bool? | Whether to eliminate (concept name, language, label role) duplicates. By default no duplicate elimination (optional)  (default to true)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve labels for the supplied components and report elements
                Object result = apiInstance.GetLabels(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, archiveFiscalYear, archiveFiscalPeriod, archiveTag, section, hypercube, disclosure, reportElement, label, language, labelRole, onlyTextBlocks, kind, eliminateReportElementDuplicates, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **hypercube** | [**List<string>**](string.md)| The name of a hypercube report element, to retrieve labels. | [optional] [default to null]
 **disclosure** | [**List<string>**](string.md)| A disclosure, to identify sections or components (e.g. BalanceSheet). | [optional] [default to null]
 **reportElement** | [**List<string>**](string.md)| The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **label** | [**List<string>**](string.md)| A search term to search in the labels of components, to retrieve components (e.g. stock). | [optional] [default to null]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **labelRole** | [**List<string>**](string.md)| A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values). | [optional] [default to null]
 **onlyTextBlocks** | **bool?**| If set to true only labels for concepts defined as textBlockItemType are returned (default: false). | [optional] [default to false]
 **kind** | [**List<string>**](string.md)| Filters by concept kind (default: no filtering) | [optional] [default to null]
 **eliminateReportElementDuplicates** | **bool?**| Whether to eliminate (concept name, language, label role) duplicates. By default no duplicate elimination | [optional] [default to true]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmodelstructureforcomponent"></a>
# **GetModelStructureForComponent**
> Object GetModelStructureForComponent (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null, List<string> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, List<string> label = null, string language = null, bool? indent = null, bool? count = null, int? top = null, int? skip = null)

Retrieve the model structure for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetModelStructureForComponentExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var hypercube = new List<string>(); // List<string> | The name of a hypercube report element, to retrieve components / sections. (optional)  (default to null)
            var disclosure = new List<string>(); // List<string> | A disclosure, to identify sections or components (e.g. BalanceSheet). (optional)  (default to null)
            var reportElement = new List<string>(); // List<string> | The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var label = new List<string>(); // List<string> | A search term to search in the labels of components, to retrieve components (e.g. stock). (optional)  (default to null)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var indent = true;  // bool? | If set to true all labels will be prepended with 8 space characters for each level of depth within the model structure (default: false). (optional)  (default to false)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve the model structure for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
                Object result = apiInstance.GetModelStructureForComponent(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, archiveFiscalYear, archiveFiscalPeriod, archiveTag, section, hypercube, disclosure, reportElement, label, language, indent, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetModelStructureForComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **hypercube** | [**List<string>**](string.md)| The name of a hypercube report element, to retrieve components / sections. | [optional] [default to null]
 **disclosure** | [**List<string>**](string.md)| A disclosure, to identify sections or components (e.g. BalanceSheet). | [optional] [default to null]
 **reportElement** | [**List<string>**](string.md)| The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **label** | [**List<string>**](string.md)| A search term to search in the labels of components, to retrieve components (e.g. stock). | [optional] [default to null]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **indent** | **bool?**| If set to true all labels will be prepended with 8 space characters for each level of depth within the model structure (default: false). | [optional] [default to false]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getperiods"></a>
# **GetPeriods**
> Object GetPeriods (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null, bool? count = null, int? top = null, int? skip = null)

Retrieve the periods of the archives filed by a particular entity

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetPeriodsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve the periods of the archives filed by a particular entity
                Object result = apiInstance.GetPeriods(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, archiveFiscalYear, archiveFiscalPeriod, archiveTag, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetPeriods: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportelements"></a>
# **GetReportElements**
> Object GetReportElements (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null, List<string> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, bool? builtin = null, bool? onlyNames = null, string report = null, List<string> label = null, bool? onlyTextBlocks = null, List<string> kind = null, string reportElementSearch = null, int? reportElementSearchOffset = null, int? reportElementSearchLimit = null, string language = null, string contentType = null, bool? count = null, int? top = null, int? skip = null)

Retrieve the report elements contained in a set of archives.

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetReportElementsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var hypercube = new List<string>(); // List<string> | The name of a hypercube report element, to retrieve labels. (optional)  (default to null)
            var disclosure = new List<string>(); // List<string> | A disclosure, to identify sections or components (e.g. BalanceSheet). (optional)  (default to null)
            var reportElement = new List<string>(); // List<string> | The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var builtin = true;  // bool? | Whether to include built-in report elements (false by default). (optional)  (default to false)
            var onlyNames = true;  // bool? | Whether only the names of the report elements should be returned. If so, the values don't contain duplicates. (default: false) (optional)  (default to false)
            var report = report_example;  // string | The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none). (optional)  (default to null)
            var label = new List<string>(); // List<string> | A search term to search in the labels of report elements (e.g. stock) (optional)  (default to null)
            var onlyTextBlocks = true;  // bool? | Filters by text block/not text block (default: no filtering) (optional)  (default to null)
            var kind = new List<string>(); // List<string> | Filters by concept kind (default: no filtering) (optional)  (default to null)
            var reportElementSearch = reportElementSearch_example;  // string | Includes in the results the report elements that have a label matching this full-text query (optional)  (default to null)
            var reportElementSearchOffset = 56;  // int? | Includes in the results the report elements that have a label matching the report-element-search parameter skipping the first report-element-search-offset results (default: 0) (optional)  (default to null)
            var reportElementSearchLimit = 56;  // int? | Includes in the results the report elements that have a label matching the report-element-search parameter limited to a maximum of report-element-search-limit results (default: 100) (optional)  (default to null)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var contentType = contentType_example;  // string | Content-Type of the request (optional)  (default to null)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve the report elements contained in a set of archives.
                Object result = apiInstance.GetReportElements(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, archiveFiscalYear, archiveFiscalPeriod, archiveTag, section, hypercube, disclosure, reportElement, builtin, onlyNames, report, label, onlyTextBlocks, kind, reportElementSearch, reportElementSearchOffset, reportElementSearchLimit, language, contentType, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetReportElements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **hypercube** | [**List<string>**](string.md)| The name of a hypercube report element, to retrieve labels. | [optional] [default to null]
 **disclosure** | [**List<string>**](string.md)| A disclosure, to identify sections or components (e.g. BalanceSheet). | [optional] [default to null]
 **reportElement** | [**List<string>**](string.md)| The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **builtin** | **bool?**| Whether to include built-in report elements (false by default). | [optional] [default to false]
 **onlyNames** | **bool?**| Whether only the names of the report elements should be returned. If so, the values don&#39;t contain duplicates. (default: false) | [optional] [default to false]
 **report** | **string**| The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none). | [optional] [default to null]
 **label** | [**List<string>**](string.md)| A search term to search in the labels of report elements (e.g. stock) | [optional] [default to null]
 **onlyTextBlocks** | **bool?**| Filters by text block/not text block (default: no filtering) | [optional] [default to null]
 **kind** | [**List<string>**](string.md)| Filters by concept kind (default: no filtering) | [optional] [default to null]
 **reportElementSearch** | **string**| Includes in the results the report elements that have a label matching this full-text query | [optional] [default to null]
 **reportElementSearchOffset** | **int?**| Includes in the results the report elements that have a label matching the report-element-search parameter skipping the first report-element-search-offset results (default: 0) | [optional] [default to null]
 **reportElementSearchLimit** | **int?**| Includes in the results the report elements that have a label matching the report-element-search parameter limited to a maximum of report-element-search-limit results (default: 100) | [optional] [default to null]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **contentType** | **string**| Content-Type of the request | [optional] [default to null]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrules"></a>
# **GetRules**
> Object GetRules (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null, List<string> section = null, List<string> disclosure = null, List<string> reportElement = null, List<string> label = null, bool? count = null, int? top = null, int? skip = null)

Retrieve a summary for all rules of a given section

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetRulesExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var disclosure = new List<string>(); // List<string> | A disclosure, to identify sections or components (e.g. BalanceSheet). (optional)  (default to null)
            var reportElement = new List<string>(); // List<string> | The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var label = new List<string>(); // List<string> | A search term to search in the labels of components, to retrieve components (e.g. stock). (optional)  (default to null)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve a summary for all rules of a given section
                Object result = apiInstance.GetRules(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, archiveFiscalYear, archiveFiscalPeriod, archiveTag, section, disclosure, reportElement, label, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **disclosure** | [**List<string>**](string.md)| A disclosure, to identify sections or components (e.g. BalanceSheet). | [optional] [default to null]
 **reportElement** | [**List<string>**](string.md)| The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **label** | [**List<string>**](string.md)| A search term to search in the labels of components, to retrieve components (e.g. stock). | [optional] [default to null]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsections"></a>
# **GetSections**
> Object GetSections (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null, List<string> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, List<string> label = null, bool? validate = null, string language = null, bool? count = null, int? top = null, int? skip = null)

Retrieve a summary for all sections of a given archive

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetSectionsExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var hypercube = new List<string>(); // List<string> | The name of a hypercube report element, to retrieve components / sections. (optional)  (default to null)
            var disclosure = new List<string>(); // List<string> | A disclosure, to identify sections or components (e.g. BalanceSheet). (optional)  (default to null)
            var reportElement = new List<string>(); // List<string> | The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var label = new List<string>(); // List<string> | A search term to search in the labels of components, to retrieve components (e.g. stock). (optional)  (default to null)
            var validate = true;  // bool? | Whether to run validation on the output components (default: false). Adds a column ValidationErrors (optional)  (default to false)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)

            try
            {
                // Retrieve a summary for all sections of a given archive
                Object result = apiInstance.GetSections(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, archiveFiscalYear, archiveFiscalPeriod, archiveTag, section, hypercube, disclosure, reportElement, label, validate, language, count, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSections: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **hypercube** | [**List<string>**](string.md)| The name of a hypercube report element, to retrieve components / sections. | [optional] [default to null]
 **disclosure** | [**List<string>**](string.md)| A disclosure, to identify sections or components (e.g. BalanceSheet). | [optional] [default to null]
 **reportElement** | [**List<string>**](string.md)| The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **label** | [**List<string>**](string.md)| A search term to search in the labels of components, to retrieve components (e.g. stock). | [optional] [default to null]
 **validate** | **bool?**| Whether to run validation on the output components (default: false). Adds a column ValidationErrors | [optional] [default to false]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspreadsheetforcomponent"></a>
# **GetSpreadsheetForComponent**
> Object GetSpreadsheetForComponent (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string additionalRules = null, string auditTrails = null, bool? open = null, List<string> archiveTag = null, Dictionary<string, List<string>> dimensions = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, List<string> disclosure = null, List<string> reportElement = null, List<string> label = null, string aggregationFunction = null, bool? validate = null, bool? merge = null, string language = null, bool? _override = null, bool? eliminate = null, int? eliminationThreshold = null, bool? populate = null, bool? autoSlice = null, List<int?> row = null, List<int?> column = null, bool? flattenRowHeaders = null, bool? metadata = null)

Retrieve the business-friendly spreadsheet for a given component.  A component can be selected in several ways, for example with an Archive ID (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc. 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetSpreadsheetForComponentExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var hypercube = new List<string>(); // List<string> | The name of a hypercube report element, to retrieve components / sections. (optional)  (default to null)
            var concept = new List<string>(); // List<string> | The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). (optional)  (default to null)
            var fiscalYear = new List<string>(); // List<string> | A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). (optional)  (default to null)
            var fiscalPeriod = new List<string>(); // List<string> | A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). (optional)  (default to null)
            var fiscalPeriodType = new List<string>(); // List<string> | A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var additionalRules = additionalRules_example;  // string | The name of a report from which to use rules in addition to a report's rules (e.g. FundamentalAccountingConcepts). (optional)  (default to null)
            var auditTrails = auditTrails_example;  // string | Whether audit trails should be included in each fact (default: no). (optional)  (default to no)
            var open = true;  // bool? | Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). (optional)  (default to false)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var dimensions = new Dictionary<string, List<string>>(); // Dictionary<string, List<string>> | A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. (optional)  (default to null)
            var dimensionsCategory = prefixdimensioncategory_example;  // Dictionary<string, string> | Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). (optional)  (default to null)
            var dimensionsVisible = true;  // Dictionary<string, bool?> | Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. (optional)  (default to null)
            var dimensionSlicers = true;  // Dictionary<string, bool?> | [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). (optional)  (default to null)
            var disclosure = new List<string>(); // List<string> | A disclosure, to identify sections or components (e.g. BalanceSheet). (optional)  (default to null)
            var reportElement = new List<string>(); // List<string> | The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var label = new List<string>(); // List<string> | A search term to search in the labels of components, to retrieve components (e.g. stock). (optional)  (default to null)
            var aggregationFunction = aggregationFunction_example;  // string | Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. (optional)  (default to null)
            var validate = true;  // bool? | Whether or not to stamp facts for validity (default is false). (optional)  (default to false)
            var merge = true;  // bool? | Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true). (optional)  (default to true)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var _override = true;  // bool? | Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: true if a profile is active, but false if a definition model is defined in the component). (optional)  (default to null)
            var eliminate = true;  // bool? | Whether to eliminate empty rows / columns (Default: false). (optional)  (default to false)
            var eliminationThreshold = 56;  // int? | When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0). (optional)  (default to 0)
            var populate = true;  // bool? | Whether to populate cells with facts (Default: true). If false, populate with metadata, that is, aspects and concept data type, period type, balance. (optional)  (default to true)
            var autoSlice = true;  // bool? | If set to true then slicers are automatically defined (default: true). (optional)  (default to true)
            var row = new List<int?>(); // List<int?> | Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination. (optional)  (default to null)
            var column = new List<int?>(); // List<int?> | Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination. (optional)  (default to null)
            var flattenRowHeaders = true;  // bool? | Whether to flatten row headers to single columns (Default: false). (optional)  (default to false)
            var metadata = true;  // bool? | Whether metadata about the facts concept and dimensions should be included in each fact (default: false). (optional)  (default to false)

            try
            {
                // Retrieve the business-friendly spreadsheet for a given component.  A component can be selected in several ways, for example with an Archive ID (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc. 
                Object result = apiInstance.GetSpreadsheetForComponent(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, section, hypercube, concept, fiscalYear, fiscalPeriod, fiscalPeriodType, archiveFiscalYear, archiveFiscalPeriod, additionalRules, auditTrails, open, archiveTag, dimensions, dimensionsCategory, dimensionsVisible, dimensionSlicers, disclosure, reportElement, label, aggregationFunction, validate, merge, language, _override, eliminate, eliminationThreshold, populate, autoSlice, row, column, flattenRowHeaders, metadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSpreadsheetForComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **hypercube** | [**List<string>**](string.md)| The name of a hypercube report element, to retrieve components / sections. | [optional] [default to null]
 **concept** | [**List<string>**](string.md)| The name of a concept to dice facts (a synonym for the dimension xbrl:Concept). | [optional] [default to null]
 **fiscalYear** | [**List<string>**](string.md)| A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). | [optional] [default to null]
 **fiscalPeriod** | [**List<string>**](string.md)| A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). | [optional] [default to null]
 **fiscalPeriodType** | [**List<string>**](string.md)| A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **additionalRules** | **string**| The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts). | [optional] [default to null]
 **auditTrails** | **string**| Whether audit trails should be included in each fact (default: no). | [optional] [default to no]
 **open** | **bool?**| Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). | [optional] [default to false]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **dimensions** | [**Dictionary<string, List<string>>**](List&lt;string&gt;.md)| A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. | [optional] [default to null]
 **dimensionsCategory** | **Dictionary<string, string>**| Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). | [optional] [default to null]
 **dimensionsVisible** | **Dictionary<string, bool?>**| Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. | [optional] [default to null]
 **dimensionSlicers** | **Dictionary<string, bool?>**| [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). | [optional] [default to null]
 **disclosure** | [**List<string>**](string.md)| A disclosure, to identify sections or components (e.g. BalanceSheet). | [optional] [default to null]
 **reportElement** | [**List<string>**](string.md)| The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **label** | [**List<string>**](string.md)| A search term to search in the labels of components, to retrieve components (e.g. stock). | [optional] [default to null]
 **aggregationFunction** | **string**| Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. | [optional] [default to null]
 **validate** | **bool?**| Whether or not to stamp facts for validity (default is false). | [optional] [default to false]
 **merge** | **bool?**| Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true). | [optional] [default to true]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **_override** | **bool?**| Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: true if a profile is active, but false if a definition model is defined in the component). | [optional] [default to null]
 **eliminate** | **bool?**| Whether to eliminate empty rows / columns (Default: false). | [optional] [default to false]
 **eliminationThreshold** | **int?**| When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0). | [optional] [default to 0]
 **populate** | **bool?**| Whether to populate cells with facts (Default: true). If false, populate with metadata, that is, aspects and concept data type, period type, balance. | [optional] [default to true]
 **autoSlice** | **bool?**| If set to true then slicers are automatically defined (default: true). | [optional] [default to true]
 **row** | [**List<int?>**](int?.md)| Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination. | [optional] [default to null]
 **column** | [**List<int?>**](int?.md)| Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination. | [optional] [default to null]
 **flattenRowHeaders** | **bool?**| Whether to flatten row headers to single columns (Default: false). | [optional] [default to false]
 **metadata** | **bool?**| Whether metadata about the facts concept and dimensions should be included in each fact (default: false). | [optional] [default to false]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspreadsheetforreport"></a>
# **GetSpreadsheetForReport**
> Object GetSpreadsheetForReport (string token, string profileName = null, string format = null, List<string> aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<string> edinetcode = null, List<string> entityTag = null, List<string> sic = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string report = null, bool? validate = null, string auditTrails = null, string language = null, bool? eliminate = null, int? eliminationThreshold = null, bool? populate = null, List<int?> row = null, List<int?> column = null, bool? flattenRowHeaders = null, List<string> archiveTag = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, bool? _override = null, bool? open = null, Dictionary<string, List<string>> dimensions = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, string aggregationFunction = null)

Retrieve the business-friendly spreadsheet for a report.  Filters can be overriden. Filters MUST be overriden if the report is not already filtering. 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetSpreadsheetForReportExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var fiscalYear = new List<string>(); // List<string> | A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). (optional)  (default to null)
            var fiscalPeriod = new List<string>(); // List<string> | A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). (optional)  (default to null)
            var fiscalPeriodType = new List<string>(); // List<string> | A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). (optional)  (default to null)
            var report = report_example;  // string | The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none). (optional)  (default to null)
            var validate = true;  // bool? | Whether or not to stamp facts for validity (default is false). (optional)  (default to false)
            var auditTrails = auditTrails_example;  // string | Whether audit trails should be included in each fact (default: no). (optional)  (default to no)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var eliminate = true;  // bool? | Whether to eliminate empty rows / columns (Default: false). (optional)  (default to false)
            var eliminationThreshold = 56;  // int? | When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0). (optional)  (default to 0)
            var populate = true;  // bool? | Whether to populate cells with facts (Default: true). If false, populate with metadata, that is, aspects and concept data type, period type, balance. (optional)  (default to true)
            var row = new List<int?>(); // List<int?> | Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination. (optional)  (default to null)
            var column = new List<int?>(); // List<int?> | Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination. (optional)  (default to null)
            var flattenRowHeaders = true;  // bool? | Whether to flatten row headers to single columns (Default: false). (optional)  (default to false)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var _override = true;  // bool? | Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: true if a profile is active, otherwise automatically activated). (optional)  (default to null)
            var open = true;  // bool? | Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). (optional)  (default to false)
            var dimensions = new Dictionary<string, List<string>>(); // Dictionary<string, List<string>> | A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. (optional)  (default to null)
            var dimensionsCategory = prefixdimensioncategory_example;  // Dictionary<string, string> | Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). (optional)  (default to null)
            var dimensionsVisible = true;  // Dictionary<string, bool?> | Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. (optional)  (default to null)
            var dimensionSlicers = true;  // Dictionary<string, bool?> | [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). (optional)  (default to null)
            var aggregationFunction = aggregationFunction_example;  // string | Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. (optional)  (default to null)

            try
            {
                // Retrieve the business-friendly spreadsheet for a report.  Filters can be overriden. Filters MUST be overriden if the report is not already filtering. 
                Object result = apiInstance.GetSpreadsheetForReport(token, profileName, format, aid, eid, cik, ticker, edinetcode, entityTag, sic, fiscalYear, fiscalPeriod, fiscalPeriodType, report, validate, auditTrails, language, eliminate, eliminationThreshold, populate, row, column, flattenRowHeaders, archiveTag, archiveFiscalYear, archiveFiscalPeriod, _override, open, dimensions, dimensionsCategory, dimensionsVisible, dimensionSlicers, aggregationFunction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetSpreadsheetForReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **fiscalYear** | [**List<string>**](string.md)| A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering). | [optional] [default to null]
 **fiscalPeriod** | [**List<string>**](string.md)| A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering). | [optional] [default to null]
 **fiscalPeriodType** | [**List<string>**](string.md)| A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering). | [optional] [default to null]
 **report** | **string**| The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none). | [optional] [default to null]
 **validate** | **bool?**| Whether or not to stamp facts for validity (default is false). | [optional] [default to false]
 **auditTrails** | **string**| Whether audit trails should be included in each fact (default: no). | [optional] [default to no]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **eliminate** | **bool?**| Whether to eliminate empty rows / columns (Default: false). | [optional] [default to false]
 **eliminationThreshold** | **int?**| When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0). | [optional] [default to 0]
 **populate** | **bool?**| Whether to populate cells with facts (Default: true). If false, populate with metadata, that is, aspects and concept data type, period type, balance. | [optional] [default to true]
 **row** | [**List<int?>**](int?.md)| Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination. | [optional] [default to null]
 **column** | [**List<int?>**](int?.md)| Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination. | [optional] [default to null]
 **flattenRowHeaders** | **bool?**| Whether to flatten row headers to single columns (Default: false). | [optional] [default to false]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **_override** | **bool?**| Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: true if a profile is active, otherwise automatically activated). | [optional] [default to null]
 **open** | **bool?**| Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false). | [optional] [default to false]
 **dimensions** | [**Dictionary<string, List<string>>**](List&lt;string&gt;.md)| A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string. | [optional] [default to null]
 **dimensionsCategory** | **Dictionary<string, string>**| Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged). | [optional] [default to null]
 **dimensionsVisible** | **Dictionary<string, bool?>**| Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers. | [optional] [default to null]
 **dimensionSlicers** | **Dictionary<string, bool?>**| [Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false). | [optional] [default to null]
 **aggregationFunction** | **string**| Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettables"></a>
# **GetTables**
> Object GetTables (string token, string profileName = null, string format = null, List<string> eid = null, List<string> ticker = null, List<string> entityTag = null, List<string> sic = null, List<string> cik = null, List<string> edinetcode = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, List<string> archiveTag = null, List<string> aid = null, List<string> section = null, List<string> reportElement = null, List<string> label = null, bool? count = null, int? top = null, int? skip = null, string language = null, List<string> table = null, string tableLabelSearch = null, string tableColumnSearch = null, string tableRowSearch = null, int? tableSearchOffset = null, int? tableSearchLimit = null)

Retrieve tables metadata

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class GetTablesExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var eid = new List<string>(); // List<string> | The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var ticker = new List<string>(); // List<string> | The ticker of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var entityTag = new List<string>(); // List<string> | The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var sic = new List<string>(); // List<string> | The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var cik = new List<string>(); // List<string> | The CIK of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var edinetcode = new List<string>(); // List<string> | The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. (optional)  (default to null)
            var archiveFiscalYear = new List<string>(); // List<string> | The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveFiscalPeriod = new List<string>(); // List<string> | The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). (optional)  (default to ALL)
            var archiveTag = new List<string>(); // List<string> | The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). (optional)  (default to null)
            var aid = new List<string>(); // List<string> | Archive IDs, to retrieve archives, sections, components or slice facts. (optional)  (default to null)
            var section = new List<string>(); // List<string> | The URI of a particular section, to retrieve a section, component or report element. (optional)  (default to null)
            var reportElement = new List<string>(); // List<string> | The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). (optional)  (default to null)
            var label = new List<string>(); // List<string> | A search term to search in the labels of components, to retrieve components (e.g. stock). (optional)  (default to null)
            var count = true;  // bool? | If true, only outputs statistics (default: false). (optional)  (default to false)
            var top = 56;  // int? | Output only the first [top] results (default: no limit). (optional)  (default to null)
            var skip = 56;  // int? | Skip the first [skip] results. (optional)  (default to null)
            var language = language_example;  // string | A language code (default: en-US) for displaying labels. (optional)  (default to null)
            var table = new List<string>(); // List<string> | Table names, to retrieve tables. (optional)  (default to null)
            var tableLabelSearch = tableLabelSearch_example;  // string | Includes in the results the tables whose label matches this full-text query (optional)  (default to null)
            var tableColumnSearch = tableColumnSearch_example;  // string | Includes in the results the tables that have a column label matching this full-text query (optional)  (default to null)
            var tableRowSearch = tableRowSearch_example;  // string | Includes in the results the tables that have a row label matching this full-text query (optional)  (default to null)
            var tableSearchOffset = 56;  // int? | Includes in the results the tables matching one of the required full-text searches skipping the first table-search-offset results (default: 0) (optional)  (default to null)
            var tableSearchLimit = 56;  // int? | Includes in the results the tables matching one of the required full-text searches limited to a maximum of table-search-limit results (default: 100) (optional)  (default to null)

            try
            {
                // Retrieve tables metadata
                Object result = apiInstance.GetTables(token, profileName, format, eid, ticker, entityTag, sic, cik, edinetcode, archiveFiscalYear, archiveFiscalPeriod, archiveTag, aid, section, reportElement, label, count, top, skip, language, table, tableLabelSearch, tableColumnSearch, tableRowSearch, tableSearchOffset, tableSearchLimit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetTables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **eid** | [**List<string>**](string.md)| The EIDs (scheme + local name) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **ticker** | [**List<string>**](string.md)| The ticker of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **entityTag** | [**List<string>**](string.md)| The tag of an entity (such as an index), to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **sic** | [**List<string>**](string.md)| The SIC (industry group) of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **cik** | [**List<string>**](string.md)| The CIK of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **edinetcode** | [**List<string>**](string.md)| The EDINET code of a company, to retrieve entities, archives, sections, components or dice facts. | [optional] [default to null]
 **archiveFiscalYear** | [**List<string>**](string.md)| The fiscal year focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveFiscalPeriod** | [**List<string>**](string.md)| The fiscal period focus of the archive, to retrieve archives, sections, components or slice facts (default: ALL). | [optional] [default to ALL]
 **archiveTag** | [**List<string>**](string.md)| The tag of the archive, to retrieve archives, sections, components or slice facts (default: no filtering). | [optional] [default to null]
 **aid** | [**List<string>**](string.md)| Archive IDs, to retrieve archives, sections, components or slice facts. | [optional] [default to null]
 **section** | [**List<string>**](string.md)| The URI of a particular section, to retrieve a section, component or report element. | [optional] [default to null]
 **reportElement** | [**List<string>**](string.md)| The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill). | [optional] [default to null]
 **label** | [**List<string>**](string.md)| A search term to search in the labels of components, to retrieve components (e.g. stock). | [optional] [default to null]
 **count** | **bool?**| If true, only outputs statistics (default: false). | [optional] [default to false]
 **top** | **int?**| Output only the first [top] results (default: no limit). | [optional] [default to null]
 **skip** | **int?**| Skip the first [skip] results. | [optional] [default to null]
 **language** | **string**| A language code (default: en-US) for displaying labels. | [optional] [default to null]
 **table** | [**List<string>**](string.md)| Table names, to retrieve tables. | [optional] [default to null]
 **tableLabelSearch** | **string**| Includes in the results the tables whose label matches this full-text query | [optional] [default to null]
 **tableColumnSearch** | **string**| Includes in the results the tables that have a column label matching this full-text query | [optional] [default to null]
 **tableRowSearch** | **string**| Includes in the results the tables that have a row label matching this full-text query | [optional] [default to null]
 **tableSearchOffset** | **int?**| Includes in the results the tables matching one of the required full-text searches skipping the first table-search-offset results (default: 0) | [optional] [default to null]
 **tableSearchLimit** | **int?**| Includes in the results the tables matching one of the required full-text searches limited to a maximum of table-search-limit results (default: 100) | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importarchive"></a>
# **ImportArchive**
> Object ImportArchive (string token, Object archive, string profileName = null, string format = null, string aid = null, int? timeout = null, string archiveDetectionProfileName = null, bool? taxonomy = null, bool? insertEntity = null)

Imports an archive.   A full import is performed by provided, in the body of the request, a ZIP Deflate-compressed archive. This will import all the facts from the instance, as well as the taxonomy schema and linkbases. 

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class ImportArchiveExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var archive = ;  // Object | The body of the request, a single ZIP-Deflate-compressed XBRL archive. (default to null)
            var profileName = profileName_example;  // string | Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository (optional)  (default to null)
            var format = format_example;  // string | Returns the results in the supplied format (optional)  (default to json)
            var aid = aid_example;  // string | Archive ID of the archive or taxonomy. (optional)  (default to null)
            var timeout = 56;  // int? | Timeout for the operation. (optional)  (default to null)
            var archiveDetectionProfileName = archiveDetectionProfileName_example;  // string | This parameter can be used to override the algorithm used to identify which files are the archive entrypoint. Allowed values are: AUTO (automatic detection) and FSA (automatic detection, with identification of Audit and Public documents). (optional)  (default to AUTO)
            var taxonomy = true;  // bool? | Whether to import the XBRL taxonomy of the specified archive or the archive itself. (optional)  (default to false)
            var insertEntity = true;  // bool? | If false, and one or more of the archive entities are not present in the repository an error is raised. If true, the missing entity is inserted. (Default is true, only used when providing compressed XBRL archives) (optional)  (default to true)

            try
            {
                // Imports an archive.   A full import is performed by provided, in the body of the request, a ZIP Deflate-compressed archive. This will import all the facts from the instance, as well as the taxonomy schema and linkbases. 
                Object result = apiInstance.ImportArchive(token, archive, profileName, format, aid, timeout, archiveDetectionProfileName, taxonomy, insertEntity);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.ImportArchive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **archive** | **Object**| The body of the request, a single ZIP-Deflate-compressed XBRL archive. | [default to null]
 **profileName** | **string**| Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository | [optional] [default to null]
 **format** | **string**| Returns the results in the supplied format | [optional] [default to json]
 **aid** | **string**| Archive ID of the archive or taxonomy. | [optional] [default to null]
 **timeout** | **int?**| Timeout for the operation. | [optional] [default to null]
 **archiveDetectionProfileName** | **string**| This parameter can be used to override the algorithm used to identify which files are the archive entrypoint. Allowed values are: AUTO (automatic detection) and FSA (automatic detection, with identification of Audit and Public documents). | [optional] [default to AUTO]
 **taxonomy** | **bool?**| Whether to import the XBRL taxonomy of the specified archive or the archive itself. | [optional] [default to false]
 **insertEntity** | **bool?**| If false, and one or more of the archive entities are not present in the repository an error is raised. If true, the missing entity is inserted. (Default is true, only used when providing compressed XBRL archives) | [optional] [default to true]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removerule"></a>
# **RemoveRule**
> Object RemoveRule (string token, string id, string aid = null, string section = null)

Delete a rule for a given section

### Example
```csharp
using System;
using System.Diagnostics;
using CellStore.Api;
using CellStore.Client;
using CellStore.Model;

namespace Example
{
    public class RemoveRuleExample
    {
        public void main()
        {
            
            var apiInstance = new DataApi();
            var token = token_example;  // string | The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. (default to null)
            var id = id_example;  // string | Rule id. (default to null)
            var aid = aid_example;  // string | Archive ID of the archive or taxonomy. (optional)  (default to null)
            var section = section_example;  // string | The URI of a particular section. (optional)  (default to null)

            try
            {
                // Delete a rule for a given section
                Object result = apiInstance.RemoveRule(token, id, aid, section);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.RemoveRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials. | [default to null]
 **id** | **string**| Rule id. | [default to null]
 **aid** | **string**| Archive ID of the archive or taxonomy. | [optional] [default to null]
 **section** | **string**| The URI of a particular section. | [optional] [default to null]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

