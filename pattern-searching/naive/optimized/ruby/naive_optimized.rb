class NaiveOptimized
  def self.search(text, pattern)
    text_length = text.length
    pattern_length = pattern.length

    i = 0
    while i <= text_length - pattern_length
      j = 0
      (0...pattern_length).each do
        break if text[i + j] != pattern[j]

        j += 1
      end

      if j == pattern_length
        puts "Pattern found at index #{i}"
        i += pattern_length
      else
        i += 1
      end
    end
  end
end

txt = 'ABCEABCDABCEABCD'
pat = 'ABCD'
NaiveOptimized.search(txt, pat)
