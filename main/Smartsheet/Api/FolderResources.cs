﻿//    #[license]
//    SmartsheetClient SDK for C#
//    %%
//    Copyright (C) 2014 SmartsheetClient
//    %%
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        
//            http://www.apache.org/licenses/LICENSE-2.0
//        
//    Unless required by applicable law or agreed To in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//    %[license]

using System.Collections.Generic;

namespace Smartsheet.Api
{


	using Folder = Api.Models.Folder;

	/// <summary>
	/// <para>This interface provides methods To access Folder resources.</para>
	/// 
	/// <para>Thread Safety: Implementation of this interface must be thread safe.</para>
	/// </summary>
	public interface FolderResources
	{

		/// <summary>
		/// <para>Get a folder.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method: GET /folder/{Id}</para>
		/// </summary>
		/// <param name="folderId"> the folder Id </param>
		/// <returns> the folder (note that if there is no such resource, this method will throw ResourceNotFoundException 
		/// rather than returning null) </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Folder GetFolder(long folderId);

		/// <summary>
		/// <para>Update a folder.</para>
		/// </summary>
		/// <param name="folder"> the folder To update </param>
		/// <returns> the updated folder (note that if there is no such folder, this method will throw Resource Not Found 
		/// Exception rather than returning null). </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Folder UpdateFolder(Folder folder);

		/// <summary>
		/// <para>Delete a folder.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method:<br />
		/// DELETE /folder{Id}</para>
		/// </summary>
		/// <param name="folderId"> the folder Id </param>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		void DeleteFolder(long folderId);

		/// <summary>
		/// <para>List child Folders of a given folder.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method:<br /> GET /folder/{Id}/Folders</para>
		/// </summary>
		/// <param name="parentFolderId"> the parent folder Id </param>
		/// <returns> the child Folders (note that an empty list will be returned if no child folder is found). </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		IList<Folder> ListFolders(long parentFolderId);

		/// <summary>
		/// <para>Create a folder.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method:<br />
		/// POST /folder/{Id}/Folders</para>
		/// </summary>
		/// <param name="parentFolderId"> the parent folder Id </param>
		/// <param name="folder"> the folder To create </param>
		/// <returns> the created folder </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Folder CreateFolder(long parentFolderId, Folder folder);
	}

}