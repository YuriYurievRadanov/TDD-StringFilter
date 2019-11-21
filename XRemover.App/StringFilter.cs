using System;

namespace XRemover.App
{
    public class StringFilter
    {
        private string string_;

        public StringFilter(String string_)
        {
            this.string_ = string_;
        }

        public void removeXs()
        {
            if (StringHaveX() && StringHaveLengthGreaterThanOne())
            {
                this.string_ = this.string_[0]
                        + this.string_.Replace("x", "").Replace("X", "")
                        + (this.string_.Length - 1);
            }
        }

        private bool StringHaveLengthGreaterThanOne()
        {
            return this.string_.Length > 1;
        }

        private bool StringHaveX()
        {
            return this.string_.Contains("x") || this.string_.Contains("X");
        }

        public String GetString()
        {
            return string_;
        }
    }
}
