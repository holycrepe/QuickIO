﻿
// <copyright file="QuickIODirectory_Attributes.cs" company="Benjamin Abt ( http://www.benjamin-abt.com - http://quickIO.NET )">
// Copyright (c) 2014 PathMatchAll Rights Reserved - DO NOT REMOVE OR EDIT COPYRIGHT
// </copyright>
// <author>Benjamin Abt</author>
// <date>12/03/2015</date>
// <summary>QuickIODirectory_Attributes></summary>

using System;
using System.IO;
using SchwabenCode.QuickIO.Internal;
using System.Diagnostics.Contracts;

namespace SchwabenCode.QuickIO
{
    public partial class QuickIODirectory
    {
        /// <summary>
        /// Gets the <see cref="FileAttributes"/> of the directory or file.
        /// </summary>
        /// <param name="path">The path to the directory or file. </param>
        /// <param name="attributes">New attributes to set.</param>
        /// <returns>The <see cref="FileAttributes"/> of the directory or file.</returns>
        public static void SetAttributes( string path, FileAttributes attributes )
        {
            Contract.Requires( !String.IsNullOrWhiteSpace( path ) );
            SetAttributes( new QuickIOPathInfo( path ), attributes );
        }

        /// <summary>
        /// Gets the <see cref="FileAttributes"/> of the directory or file.
        /// </summary>
        /// <param name="info">A directory or file. </param>
        /// <param name="attributes">New attributes to set.</param>
        /// <returns>The <see cref="FileAttributes"/> of the directory or file.</returns>
        public static void SetAttributes( QuickIOPathInfo info, FileAttributes attributes )
        {
            Contract.Requires( info != null );
            InternalQuickIO.SetAttributes( info.FullNameUnc, attributes );
        }

        /// <summary>
        /// Gets the <see cref="FileAttributes"/> of the directory or file.
        /// </summary>
        /// <param name="info">A directory or file. </param>
        /// <param name="attributes">New attributes to set.</param>
        /// <returns>The <see cref="FileAttributes"/> of the directory or file.</returns>
        public static void SetAttributes( QuickIODirectoryInfo info, FileAttributes attributes )
        {
            Contract.Requires( info != null );
            SetAttributes( info.PathInfo, attributes );
        }

        #region Attributes
        /// <summary>
        /// Gets the <see cref="FileAttributes"/> of the directory or file.
        /// </summary>
        /// <param name="path">The path to the directory or file. </param>
        /// <returns>The <see cref="FileAttributes"/> of the directory or file.</returns>
        public static FileAttributes GetAttributes( string path )
        {
            Contract.Requires( !String.IsNullOrWhiteSpace( path ) );
            return InternalQuickIO.GetAttributes( path );
        }

        /// <summary>
        /// Gets the <see cref="FileAttributes"/> of the directory or file.
        /// </summary>
        /// <param name="info">A directory or file. </param>
        /// <returns>The <see cref="FileAttributes"/> of the directory or file.</returns>
        public static FileAttributes GetAttributes( QuickIOPathInfo info )
        {
            Contract.Requires( info != null );
            return GetAttributes( info.FullNameUnc );
        }

        /// <summary>
        /// Gets the <see cref="FileAttributes"/> of the directory or file.
        /// </summary>
        /// <param name="info">A directory or file. </param>
        /// <returns>The <see cref="FileAttributes"/> of the directory or file.</returns>
        public static FileAttributes GetAttributes( QuickIODirectoryInfo info )
        {
            Contract.Requires( info != null );
            return GetAttributes( info.PathInfo );
        }

        #endregion

        #region Remove Attribute
        /// <summary>
        /// Removes the specified attribute from file or directory
        /// </summary>
        /// <param name="path">A directory or file. </param>
        /// <param name="attribute">Attribute to remove </param>
        /// <returns>true if removed. false if not exists in attributes</returns>
        public static bool RemoveAttribute( string path, FileAttributes attribute )
        {
            return InternalQuickIO.RemoveAttribute( path, attribute );
        }

        /// <summary>
        /// Removes the specified attribute from file or directory
        /// </summary>
        /// <param name="info">A directory or file. </param>
        /// <param name="attribute">Attribute to remove </param>
        /// <returns>true if removed. false if not exists in attributes</returns>
        public static bool RemoveAttribute( QuickIOPathInfo info, FileAttributes attribute )
        {
            return RemoveAttribute( info.FullNameUnc, attribute );
        }

        /// <summary>
        /// Removes the specified attribute from file or directory
        /// </summary>
        /// <param name="info">A directory or file. </param>
        /// <param name="attribute">Attribute to remove </param>
        /// <returns>true if removed. false if not exists in attributes</returns>
        public static bool RemoveAttribute( QuickIODirectoryInfo info, FileAttributes attribute )
        {
            return RemoveAttribute( info.PathInfo, attribute );
        }

        #endregion

        #region Add Attribute
        /// <summary>
        /// Adds the specified attribute to file or directory
        /// </summary>
        /// <param name="path">A directory or file. </param>
        /// <param name="attribute">Attribute to add </param>
        /// <returns>true if added. false if already exists in attributes</returns>
        public static bool AddAttribute( string path, FileAttributes attribute )
        {
            return InternalQuickIO.AddAttribute(  path , attribute );
        }

        /// <summary>
        /// Adds the specified attribute to file or directory
        /// </summary>
        /// <param name="info">A directory or file. </param>
        /// <param name="attribute">Attribute to add </param>
        /// <returns>true if added. false if already exists in attributes</returns>
        public static bool AddAttribute( QuickIOPathInfo info, FileAttributes attribute )
        {
            return InternalQuickIO.AddAttribute( info.FullNameUnc, attribute );
        }

        /// <summary>
        /// Adds the specified attribute to file or directory
        /// </summary>
        /// <param name="info">A directory or file. </param>
        /// <param name="attribute">Attribute to add </param>
        /// <returns>true if added. false if already exists in attributes</returns>
        public static bool AddAttribute( QuickIODirectoryInfo info, FileAttributes attribute )
        {
            return AddAttribute( info.PathInfo, attribute );
        }

        #endregion
    }
}
