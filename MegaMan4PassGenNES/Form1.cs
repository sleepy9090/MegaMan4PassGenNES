using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaMan4PassGenNES
{
    public partial class FormMegaMan4PassGenNES : Form
    {
        public FormMegaMan4PassGenNES()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            DisablePasswordCheckboxes();
        }

        private void DisablePasswordCheckboxes()
        {
            checkBoxA1.Enabled = false;
            checkBoxA2.Enabled = false;
            checkBoxA3.Enabled = false;
            checkBoxA4.Enabled = false;
            checkBoxA5.Enabled = false;
            checkBoxA6.Enabled = false;

            checkBoxB1.Enabled = false;
            checkBoxB2.Enabled = false;
            checkBoxB3.Enabled = false;
            checkBoxB4.Enabled = false;
            checkBoxB5.Enabled = false;
            checkBoxB6.Enabled = false;

            checkBoxC1.Enabled = false;
            checkBoxC2.Enabled = false;
            checkBoxC3.Enabled = false;
            checkBoxC4.Enabled = false;
            checkBoxC5.Enabled = false;
            checkBoxC6.Enabled = false;

            checkBoxD1.Enabled = false;
            checkBoxD2.Enabled = false;
            checkBoxD3.Enabled = false;
            checkBoxD4.Enabled = false;
            checkBoxD5.Enabled = false;
            checkBoxD6.Enabled = false;

            checkBoxE1.Enabled = false;
            checkBoxE2.Enabled = false;
            checkBoxE3.Enabled = false;
            checkBoxE4.Enabled = false;
            checkBoxE5.Enabled = false;
            checkBoxE6.Enabled = false;

            checkBoxF1.Enabled = false;
            checkBoxF2.Enabled = false;
            checkBoxF3.Enabled = false;
            checkBoxF4.Enabled = false;
            checkBoxF5.Enabled = false;
            checkBoxF6.Enabled = false;
        }

        private void ClearPasswordCheckboxes()
        {
            checkBoxA1.Checked = false;
            checkBoxA2.Checked = false;
            checkBoxA3.Checked = false;
            checkBoxA4.Checked = false;
            checkBoxA5.Checked = false;
            checkBoxA6.Checked = false;

            checkBoxB1.Checked = false;
            checkBoxB2.Checked = false;
            checkBoxB3.Checked = false;
            checkBoxB4.Checked = false;
            checkBoxB5.Checked = false;
            checkBoxB6.Checked = false;

            checkBoxC1.Checked = false;
            checkBoxC2.Checked = false;
            checkBoxC3.Checked = false;
            checkBoxC4.Checked = false;
            checkBoxC5.Checked = false;
            checkBoxC6.Checked = false;

            checkBoxD1.Checked = false;
            checkBoxD2.Checked = false;
            checkBoxD3.Checked = false;
            checkBoxD4.Checked = false;
            checkBoxD5.Checked = false;
            checkBoxD6.Checked = false;

            checkBoxE1.Checked = false;
            checkBoxE2.Checked = false;
            checkBoxE3.Checked = false;
            checkBoxE4.Checked = false;
            checkBoxE5.Checked = false;
            checkBoxE6.Checked = false;

            checkBoxF1.Checked = false;
            checkBoxF2.Checked = false;
            checkBoxF3.Checked = false;
            checkBoxF4.Checked = false;
            checkBoxF5.Checked = false;
            checkBoxF6.Checked = false;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ClearPasswordCheckboxes();

            bool hasRingBoomerang = checkBoxRingBoomerang.Checked;
            bool hasDiveMissile = checkBoxDiveMissile.Checked;
            bool hasSkullBarrier = checkBoxSkullBarrier.Checked;
            bool hasPharoahShot = checkBoxPharaohShot.Checked;
            bool hasFlashStopper = checkBoxFlashStopper.Checked;
            bool hasRainFlush = checkBoxRainFlush.Checked;
            bool hasDrillBomb = checkBoxDrillBomb.Checked;
            bool hasDustCrusher = checkBoxDustCrusher.Checked;
            bool hasWireAdaptor = checkBoxWireAdaptor.Checked;
            bool hasBalloonAdaptor = checkBoxBalloonAdaptor.Checked;

            int totalChecked = 0;
            
            if (hasRainFlush && hasFlashStopper)
            {
                checkBoxA1.Checked = true;
                totalChecked += 2;
            }
            else if (hasRainFlush)
            {
                checkBoxB1.Checked = true;
                totalChecked++;
            }
            else if (hasFlashStopper)
            {
                checkBoxC2.Checked = true;
                totalChecked++;
            }
            else
            {
                checkBoxA2.Checked = true;
            }

            if (hasPharoahShot && hasDrillBomb)
            {
                checkBoxA4.Checked = true;
                totalChecked += 2;
            }
            else if (hasPharoahShot)
            {
                checkBoxB4.Checked = true;
                totalChecked++;
            }
            else if (hasDrillBomb)
            {
                checkBoxC3.Checked = true;
                totalChecked++;
            }
            else
            {
                checkBoxA3.Checked = true;
            }

            if (hasRingBoomerang && hasDustCrusher)
            {
                checkBoxB5.Checked = true;
                totalChecked += 2;
            }
            else if (hasRingBoomerang)
            {
                checkBoxB6.Checked = true;
                totalChecked++;
            }
            else if (hasDustCrusher)
            {
                checkBoxC5.Checked = true;
                totalChecked++;
            }
            else
            {
                checkBoxA5.Checked = true;
            }

            if (hasSkullBarrier && hasDiveMissile)
            {
                checkBoxE2.Checked = true;
                totalChecked += 2;
            }
            else if (hasSkullBarrier)
            {
                checkBoxF2.Checked = true;
                totalChecked++;
            }
            else if (hasDiveMissile)
            {
                checkBoxE1.Checked = true;
                totalChecked++;
            }
            else
            {
                checkBoxD1.Checked = true;
            }

            if (hasWireAdaptor && hasBalloonAdaptor)
            {
                checkBoxF3.Checked = true;
                totalChecked += 2;
            }
            else if (hasWireAdaptor)
            {
                checkBoxD4.Checked = true;
                totalChecked++;
            }
            else if (hasBalloonAdaptor)
            {
                checkBoxD3.Checked = true;
                totalChecked++;
            }
            else
            {
                checkBoxE3.Checked = true;
            }

            switch (totalChecked)
            {
                case 0:
                    checkBoxF5.Checked = true;
                    break;
                case 1:
                    checkBoxA6.Checked = true;
                    break;
                case 2:
                    checkBoxB2.Checked = true;
                    break;
                case 3:
                    checkBoxB3.Checked = true;
                    break;
                case 4:
                    checkBoxC1.Checked = true;
                    break;
                case 5:
                    checkBoxC4.Checked = true;
                    break;
                case 6:
                    checkBoxC6.Checked = true;
                    break;
                case 7:
                    checkBoxD2.Checked = true;
                    break;
                case 8:
                    checkBoxE4.Checked = true;
                    break;
                case 9:
                    checkBoxE6.Checked = true;
                    break;
                case 10:
                    checkBoxF1.Checked = true;
                    break;
                default:
                    // Should not happen
                    break;
            }
        }
    }
}
