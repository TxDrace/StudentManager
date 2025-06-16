using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;



namespace StudentManager
{
    public class RSAEncryption
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(512);
        //private RSAParameters _privateKey;
        //private RSAParameters _publicKey;
        private string private_key_filename = "";
        private string public_key_filename = "";

        public RSAEncryption()
        { 
        }

        public void GenrateKeyPair(string public_key_filename, string private_key_filename)
        {
            this.public_key_filename = public_key_filename;
            this.private_key_filename = private_key_filename;

            //_privateKey = csp.ExportParameters(true);
            //_publicKey = csp.ExportParameters(false);

            // Save the private key to a file
            byte[] privateKeyBytes = csp.ExportCspBlob(true);
            File.WriteAllBytes(this.private_key_filename, privateKeyBytes);

            // Save the public key to a file
            byte[] publicKeyBytes = csp.ExportCspBlob(false);
            File.WriteAllBytes(this.public_key_filename, publicKeyBytes);
        }


        public string GetPublicKey()
        {
            return Convert.ToBase64String(csp.ExportCspBlob(false));
        }

        public byte[] Encrypt(string plainText, string public_key_filename)
        {
            this.public_key_filename = public_key_filename;
            if (File.Exists(this.public_key_filename))
            {
                byte[] publicKeyBytes = File.ReadAllBytes(this.public_key_filename);
                csp.ImportCspBlob(publicKeyBytes);
                //_publicKey = csp.ExportParameters(false);
            }
            else
            {
                throw new FileNotFoundException("Không tìm thấy khóa công khai!");
            }

            byte[] data = Encoding.Unicode.GetBytes(plainText);
            byte[] cypher = csp.Encrypt(data, false);

            return cypher;
        }

        public string Decrypt(byte[] cypherBytes, string private_key_filename)
        {
            this.private_key_filename = private_key_filename;

            if (File.Exists(this.private_key_filename))
            {
                byte[] privateKeyBytes = File.ReadAllBytes(this.private_key_filename);
                csp.ImportCspBlob(privateKeyBytes);
                //_privateKey = csp.ExportParameters(true);
                //_publicKey = csp.ExportParameters(false);
            }
            else
            {
                throw new FileNotFoundException("Không tìm thấy khóa bí mật!");
            }

            byte[] plainText = csp.Decrypt(cypherBytes, false);
            return Encoding.Unicode.GetString(plainText);
        }
    }


}


