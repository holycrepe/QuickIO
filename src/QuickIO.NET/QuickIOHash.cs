﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SchwabenCode.QuickIO
{
    /// <summary>
    /// Hashing and Encryption
    /// </summary>
    public static class QuickIOHash
    {
        /// <summary>
        /// File chunk hash calculation
        /// </summary>
        public static QuickIOHashResult Calculate( QuickIOHashImplementationType hashImplementationType, string content, Encoding encoding = null )
        {
            encoding = encoding ?? Encoding.UTF8;
            return Calculate( hashImplementationType, encoding.GetBytes( content ) );
        }

        /// <summary>
        /// File chunk hash calculation
        /// </summary>
        public static QuickIOHashResult Calculate( QuickIOHashImplementationType hashImplementationType, byte[ ] bytes )
        {
            Contract.Requires( bytes != null );
            Contract.Ensures( Contract.Result<QuickIOHashResult>() != null );

            HashAlgorithm hashAlgorithm;

            switch( hashImplementationType )
            {
                case QuickIOHashImplementationType.SHA1:
                    hashAlgorithm = new SHA1Managed();
                    break;

                case QuickIOHashImplementationType.SHA256:
                    hashAlgorithm = new SHA256Managed();
                    break;

                case QuickIOHashImplementationType.SHA384:
                    hashAlgorithm = new SHA384Managed();
                    break;

                case QuickIOHashImplementationType.SHA512:
                    hashAlgorithm = new SHA512Managed();
                    break;

                case QuickIOHashImplementationType.MD5:
                    hashAlgorithm = new MD5CryptoServiceProvider();
                    break;

                default:
                    throw new NotImplementedException( "Type " + hashImplementationType + " not implemented." );
            }

            return new QuickIOHashResult( hashAlgorithm.ComputeHash( bytes ) );
        }
    }
}