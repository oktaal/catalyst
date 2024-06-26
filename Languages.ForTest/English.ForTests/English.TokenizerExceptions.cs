
using System;
using System.Collections.Generic;
using Catalyst;
using Mosaik.Core;

namespace Catalyst.Models
{
    public static partial class English
    {
        internal sealed class TokenizerExceptions 
        {
            internal static Dictionary<int, TokenizationException> Get()
            {
                var exceptions = Catalyst.TokenizerExceptions.CreateBaseExceptions();

                Catalyst.TokenizerExceptions.Create(exceptions, "i", "'m|'ma", "am|am going to");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "'m|'ma|n't|'s", "am|am going to|not|'s");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "shalln't|shan't", "shall not|shall not");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "I'dn't've|we'ven't|I'ven't|cou'dn't|wou'dn't|shou'dn't|she'sn't|he'sn't", "I would not have|we have not|I have not|could not|would not|should not|she has not|he has not");
                Catalyst.TokenizerExceptions.Create(exceptions, "he|she|it", "'ll|'d|'ll've|'d've", "will|would|will have|would have");
                Catalyst.TokenizerExceptions.Create(exceptions, "i|you|we|they", "'ve|'ll|'d|'ll've|'d've", "have|will|would|will have|would have");
                Catalyst.TokenizerExceptions.Create(exceptions, "you|it|they", "ll", "will");
                Catalyst.TokenizerExceptions.Create(exceptions, "you|they", "'re|re", "are|are");
                Catalyst.TokenizerExceptions.Create(exceptions, "he|she|it", "'s", "is");
                Catalyst.TokenizerExceptions.Create(exceptions, "who|what|when|where|why|how|there|that", "'ll|'d|'ve|'re|'s|'ll've|'d've", "will|would|have|are|is|will have|would have");
                Catalyst.TokenizerExceptions.Create(exceptions, "could|do|does|did|had|may|might|must|need|ought|should|would", "n't|nt|n't've|ntve", "not|not|not have|not have");
                Catalyst.TokenizerExceptions.Create(exceptions, "could|might|must|should|would", "'ve|ve", "have|have");
                Catalyst.TokenizerExceptions.Create(exceptions, "is|are|was|were", "n't|nt", "not|not");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "'ll|'re|'d|'cause|'em|'nuff|doin'|goin'|nothin'|ol'|somethin'", "will|are|had|because|them|enough|doing|going|nothing|old|something");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "can't|cant|shall've|won't|wont|ain't|aint", "can not|can not|shall have|will not|will not|is not|is not");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "and/or|o.k.", "and/or|ok");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "y'all|yall|ma'am|o'clock|oclock|how'd'y|not've|notve|cannot|gonna|gotta|let's|lets",
                                                                    "you all|you all|madam|o'clock|o'clock|how do you|not have|not have|can not|going to|got to|let's|let's");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "a.m.|adm.|bros.|co.|corp.|d.c.|dr.|e.g.|gen.|gov.|i.e.|inc.|jr.|ltd.|md.|messrs.|mo.|mont.|mr.|mrs.|ms.|p.m.|ph.d.|rep.|rev.|sen.|st.|vs.|A.m.|D.c.|E.g.|I.e.|P.m.|Ph.D.",
                                                                    "a.m.|adm.|bros.|co.|corp.|d.c.|dr.|e.g.|gen.|gov.|i.e.|inc.|jr.|ltd.|md.|messrs.|mo.|mont.|mr.|mrs.|ms.|p.m.|ph.d.|rep.|rev.|sen.|st.|vs.|A.m.|D.c.|E.g.|I.e.|P.m.|Ph.D.");

                //TODO: Check if should add any of the contractions here: https://en.wiktionary.org/wiki/Category:English_contractions
                //TODO: Add verbs in gerund having the ending -ing replaced by -in'  , such as lovin' ->loving
                //TODO: Add numbers in this form: 14th

                return exceptions;
            }
        }
    }
}
