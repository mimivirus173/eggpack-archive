using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using eggpack.Elements.NPCs.Banners;
using Microsoft.Xna.Framework;
using System;

namespace eggpack.Elements.NPCs
{
	public class WildEgg : ModNPC
	{
		public bool[] aggressive = { false, false };

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wild Egg");
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.damage = 15;
			npc.defense = 4;
			npc.lifeMax = 50;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 100f;
			npc.knockBackResist = 0.75f;
			npc.aiStyle = -1;
			banner = npc.type;
			bannerItem = ModContent.ItemType<WildEggBanner>();
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDay.Chance * 0.5f;
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(2) == 0) Item.NewItem(npc.getRect(), ItemID.RottenEgg);
		}

		public override void AI()
		{
			npc.ai[1] = -1f;
			bool flag = false;
			if (!Main.dayTime || npc.life != npc.lifeMax || (double)npc.position.Y > Main.worldSurface * 16.0)
			{
				flag = true;
				aggressive[0] = true;
			}
			if (npc.ai[2] > 1f)
			{
				npc.ai[2] -= 1f;
			}
			if (npc.wet)
			{
				if (npc.collideY)
				{
					npc.velocity.Y = -2f;
				}
				if (npc.velocity.Y < 0f && npc.ai[3] == npc.position.X)
				{
					npc.direction *= -1;
					npc.ai[2] = 200f;
				}
				if (npc.velocity.Y > 0f)
				{
					npc.ai[3] = npc.position.X;
				}
				if (npc.velocity.Y > 2f)
				{
					npc.velocity.Y *= 0.9f;
				}
				npc.velocity.Y -= 0.5f;
				if (npc.velocity.Y < -4f)
				{
					npc.velocity.Y = -4f;
				}
				if (npc.ai[2] == 1f && flag)
				{
					npc.TargetClosest();
				}
			}
			npc.aiAction = 0;
			if (npc.ai[2] == 0f)
			{
				npc.ai[0] = -100f;
				npc.ai[2] = 1f;
				npc.TargetClosest();
			}
			if (npc.velocity.Y == 0f)
			{
				if (npc.collideY && npc.oldVelocity.Y != 0f && Collision.SolidCollision(npc.position, npc.width, npc.height))
				{
					npc.position.X -= npc.velocity.X + (float)npc.direction;
				}
				if (npc.ai[3] == npc.position.X)
				{
					npc.direction *= -1;
					npc.ai[2] = 200f;
				}
				npc.ai[3] = 0f;
				npc.velocity.X *= 0.8f;
				if ((double)npc.velocity.X > -0.1 && (double)npc.velocity.X < 0.1)
				{
					npc.velocity.X = 0f;
				}
				if (flag)
				{
					npc.ai[0] += 1f;
				}
				npc.ai[0] += 1f;
				int num11 = 0;
				if (npc.ai[0] >= 0f)
				{
					num11 = 1;
				}
				if (flag)
				{
					if (npc.ai[0] >= -750f && npc.ai[0] <= -250f)
					{
						num11 = 2;
					}
					if (npc.ai[0] >= -1500f && npc.ai[0] <= -1000f)
					{
						num11 = 3;
					}
				}
				else {
					if (npc.ai[0] >= -1000f && npc.ai[0] <= -500f)
					{
						num11 = 2;
					}
					if (npc.ai[0] >= -2000f && npc.ai[0] <= -1500f)
					{
						num11 = 3;
					}
				}
				if (num11 > 0)
				{
					npc.netUpdate = true;
					if (flag && npc.ai[2] == 1f)
					{
						npc.TargetClosest();
					}
					if (num11 == 3)
					{
						npc.velocity.Y = -8f;
						npc.velocity.X += 3 * npc.direction;
						npc.ai[0] = -50f;
						npc.ai[3] = npc.position.X;
					}
					else
					{
						npc.velocity.Y = -6f;
						npc.velocity.X += 2 * npc.direction;
						npc.ai[0] = -120f;
						if (num11 == 1)
						{
							npc.ai[0] -= 1000f;
						}
						else
						{
							npc.ai[0] -= 2000f;
						}
					}
				}
				else if (npc.ai[0] >= -30f)
				{
					npc.aiAction = 1;
				}
			}
			else if (npc.target < 255 && ((npc.direction == 1 && npc.velocity.X < 3f) || (npc.direction == -1 && npc.velocity.X > -3f)))
			{
				if (npc.collideX && Math.Abs(npc.velocity.X) == 0.2f)
				{
					npc.position.X -= 1.4f * (float)npc.direction;
				}
				if (npc.collideY && npc.oldVelocity.Y != 0f && Collision.SolidCollision(npc.position, npc.width, npc.height))
				{
					npc.position.X -= npc.velocity.X + (float)npc.direction;
				}
				if ((npc.direction == -1 && (double)npc.velocity.X < 0.01) || (npc.direction == 1 && (double)npc.velocity.X > -0.01))
				{
					npc.velocity.X += 0.2f * (float)npc.direction;
				}
				else
				{
					npc.velocity.X *= 0.93f;
				}
			}

			if (aggressive[0] && !aggressive[1]) {
				npc.ai[0] = -50f;
				aggressive[0] = false;
				aggressive[1] = true;
			}
		}
	}
}