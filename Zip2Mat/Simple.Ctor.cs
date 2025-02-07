﻿namespace Zip2Mat
{
    /* 
     * VR_Simple:
     * 
     * TextureAmbientOcclusion for AO
     * TextureColor for color
     * TextureNormal for normal map
     * TextureRoughness for roughness map
     * 
     * F_METALNESS_TEXTURE 1 if metalness exists
     * TextureMetalness for metalness
     */

    partial class Simple
    {
        private TextureCollection textures;

        public Simple(TextureCollection textureData)
        {
            this.textures = textureData;
        }
    }
}
